using ComicStripToKindle.Extensions;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStripToKindle.ComicsPages
{
    public class PdfExtractor
    {
        public List<ExtractedPageResult> ExtractImagesFromPdf(string sourcePdf, string outputPath)
        {

            var numberOfPages = 0;

            using (var pdf = new PdfReader(sourcePdf))
            {
                try
                {
                    numberOfPages = pdf.NumberOfPages;
                }
                finally
                {
                    pdf.Close();
                }
            }

            List<ExtractedPageResult>[] results = { new List<ExtractedPageResult>() };


            var pageNumbers = Enumerable.Range(1, numberOfPages).ToList();

            Parallel.ForEach(
                pageNumbers,
                DegreeOfParallelism.AllProcessorsButOne,
                (pageNumber) =>
                {
                    ExtractPage(sourcePdf, outputPath, pageNumber, results[0]);
                });

            results[0] = results[0].OrderBy(x => x.PageNumber).ToList();


            return results[0];
        }

        // NOTE:  This will only get the first image it finds per page.
        private static void ExtractPage(string sourcePdf, string outputPath, int pageNumber, List<ExtractedPageResult> results)
        {
            using (var pdf = new PdfReader(sourcePdf))
            {
                try
                {
                    var pg = pdf.GetPageN(pageNumber);

                    // recursively search pages, forms and groups for images.
                    var obj = FindImageInPdfDictionary(pg);
                    if (obj == null)
                        return;

                    var xrefIndex =
                        Convert.ToInt32(((PRIndirectReference)obj).Number.ToString(CultureInfo.InvariantCulture));
                    var pdfObj = pdf.GetPdfObject(xrefIndex);
                    var pdfStrem = (PdfStream)pdfObj;
                    var bytes = PdfReader.GetStreamBytesRaw((PRStream)pdfStrem);
                    if (bytes == null)
                        return;

                    using (var memStream = new MemoryStream(bytes))
                    {
                        memStream.Position = 0;

                        try
                        {
                            using (var img = Image.FromStream(memStream))
                            {
                                // must save the file while stream is open.
                                if (!Directory.Exists(outputPath))
                                    Directory.CreateDirectory(outputPath);

                                var path = Path.Combine(outputPath, $@"{pageNumber}.tiff");

                                img.SaveToTiffFile(path);

                                results.Add(new ExtractedPageResult
                                {
                                    PageNumber = pageNumber,
                                    ExtractedPagePath = path
                                });
                            }
                        }
                        catch (Exception e)
                        {
                            results.Add(new ExtractedPageResult
                            {
                                PageNumber = pageNumber,
                                Exception = e
                            });

                            Debug.WriteLine($"Error when extracting image from PDF. {e}");
                        }
                    }
                }
                finally
                {
                    pdf.Close();
                }
            }
        }

        public ExtractedPageResult ExtractRandomImagesFromPdf(string sourcePdf, string outputPath)
        {
            using (var pdf = new PdfReader(sourcePdf))
            {
                var results = new List<ExtractedPageResult>();

                try
                {
                    var pageNumber = (pdf.NumberOfPages / 2) +1 ;

                    while (results.Count == 0)
                        ExtractPage(sourcePdf, outputPath, pageNumber, results);
                }
                finally
                {
                    pdf.Close();
                }

                return results[0];
            }
        }


        private static PdfObject FindImageInPdfDictionary(PdfDictionary pg)
        {
            var res = (PdfDictionary)PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES));
            var xobj = (PdfDictionary)PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT));
            if (xobj == null) return null;
            foreach (var name in xobj.Keys)
            {
                var obj = xobj.Get(name);
                if (!obj.IsIndirect())
                    continue;
                var tg = (PdfDictionary)PdfReader.GetPdfObject(obj);

                var type =
                    (PdfName)PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE));

                //image at the root of the pdf
                if (PdfName.IMAGE.Equals(type))
                    return obj;
                if (PdfName.FORM.Equals(type))
                    return FindImageInPdfDictionary(tg);
                if (PdfName.GROUP.Equals(type))
                    return FindImageInPdfDictionary(tg);
            }

            return null;
        }
    }
}
