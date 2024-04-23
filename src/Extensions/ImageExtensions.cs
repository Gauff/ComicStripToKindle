using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace ComicStripToKindle.Extensions
{
    public static class ImageExtensions
    {
        public static Stream ToStream(this Image image, ImageFormat format)
        {
            var stream = new System.IO.MemoryStream();
            image.Save(stream, format);
            stream.Position = 0;
            return stream;
        }

        public static void SaveToJpegFile(this Image image, string path, long jpegQuality)
        {
            try
            {
                //if (!File.Exists(path))
                //    return;

                var jgpEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID
                // for the Quality parameter category.
                var myEncoder = Encoder.Quality;

                // Create an EncoderParameters object.
                // An EncoderParameters object has an array of EncoderParameter
                // objects. In this case, there is only one
                // EncoderParameter object in the array.
                var myEncoderParameters = new EncoderParameters(1);

                using (var myEncoderParameter = new EncoderParameter(myEncoder, jpegQuality))
                {
                    myEncoderParameters.Param[0] = myEncoderParameter;

                    image.Save(path, jgpEncoder, myEncoderParameters);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException exception)
            {
                Debug.WriteLine(exception.ToString());
            }
            catch (System.Exception exception)
            {
                Debug.WriteLine(exception.ToString());
            }
        }
        public static Bitmap ApplyToJpegCompression(this Image image, long jpegQuality, out long sizeInBytes)
        {
            var jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            var myEncoder = Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            var myEncoderParameters = new EncoderParameters(1);

            using (var myEncoderParameter = new EncoderParameter(myEncoder, jpegQuality))
            {
                myEncoderParameters.Param[0] = myEncoderParameter;
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, jgpEncoder, myEncoderParameters);
                    sizeInBytes = m.Length;
                    return new Bitmap(m);
                }
            }
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            return codecs.FirstOrDefault(codec => codec.FormatID == format.Guid);
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            var encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public static void SaveToTiffFile(this Image image, string path)
        {
            try
            {
                // Get an ImageCodecInfo object that represents the TIFF codec.
                var myImageCodecInfo = GetEncoderInfo("image/tiff");

                using (var myEncoderParameters = new EncoderParameters(2)
                {
                    Param =
                            {
                                [0] = new EncoderParameter(Encoder.Compression, (long) EncoderValue.CompressionLZW),
                                [1] = new EncoderParameter(Encoder.ColorDepth, 24L)
                            }
                })
                {
                    image.Save(path, myImageCodecInfo, myEncoderParameters);
                }
            }
            catch (System.Runtime.InteropServices.ExternalException exception)
            {
                Debug.WriteLine(exception.ToString());
            }
        }
    }
}
