using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ComicStripToKindle.Pdf
{
    public class PdfWriter
    {
        public void WritePdf(List<string> imageFilePaths, string pdfFilePath)
        {
            using (var fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (var doc = new Document())
                {
                    using (var writer = GetPdfWriterInstance(doc, fs))
                    {
                        doc.Open();

                        foreach (var imageFilePath in imageFilePaths)
                        {
                            try
                            {
                                var image = Image.GetInstance(imageFilePath);

                                image.SetAbsolutePosition(0, 0);
                                doc.SetPageSize(new Rectangle(0, 0, image.Width, image.Height, 0));
                                doc.NewPage();

                                writer.DirectContent.AddImage(image, false);
                            }
                            catch (Exception e)
                            {
                                Debug.WriteLine($"WritePdf: {e}");
                            }
                        }

                        for (int repeat = 0; repeat < 6; repeat++)
                        {
                            try
                            {
                                doc.Close();
                                break; //created, then exit loop
                            }
                            catch // instantiation of PdfWriter failed, then pause
                            {
                                System.Threading.Thread.Sleep(300);
                            }
                        }
                    }
                }
            }
        }

        public iTextSharp.text.pdf.PdfWriter GetPdfWriterInstance(Document document, FileStream filestrm)
        {
            iTextSharp.text.pdf.PdfWriter pdfwr = null;

            for (int repeat = 0; repeat < 6; repeat++)
            {
                try
                {
                    pdfwr = iTextSharp.text.pdf.PdfWriter.GetInstance(document, filestrm);
                    break; //created, then exit loop
                }
                catch // instantiation of PdfWriter failed, then pause
                {
                    System.Threading.Thread.Sleep(300);
                }
            }
            if (pdfwr == null)
            {
                throw new Exception("iTextSharp PdfWriter was not instantiated");
            }

            return pdfwr;
        }

        public static void ConcatenatePdfFiles(string[] sourceFiles, string outputFilePath)
        {
            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
            {
                Document document = new Document();
                PdfCopy pdfCopy = new PdfCopy(document, outputStream);
                document.Open();

                foreach (string sourceFile in sourceFiles)
                {
                    using (PdfReader pdfReader = new PdfReader(sourceFile))
                    {
                        for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                        {
                            PdfImportedPage importedPage = pdfCopy.GetImportedPage(pdfReader, page);
                            pdfCopy.AddPage(importedPage);
                        }
                    }
                }

                document.Close();
            }
        }
    }
}
