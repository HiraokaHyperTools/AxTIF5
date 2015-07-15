using System;
using System.Collections.Generic;
using System.Text;
using FreeImageAPI;
using System.Drawing;
using System.IO;
using Mktiffs.Properties;

namespace Mktiffs {
    class Program {
        static void Main(string[] args) {
            new Program().Run();

        }

        void Run() {
            Bitmap pic = new Bitmap("Base.png");

            {
                String fn = "1bpp-CCITTFAX3";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_CCITTFAX3);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "1bpp-CCITTFAX4";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_CCITTFAX4);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "1bpp-DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "1bpp-LZW";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "1bpp-PACKBITS";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_PACKBITS);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "1bpp-ADOBE_DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE | FREE_IMAGE_COLOR_DEPTH.FICD_01_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_ADOBE_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }




            {
                String fn = "4bpp-DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_04_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "4bpp-LZW";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_04_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "4bpp-PACKBITS";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_04_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_PACKBITS);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "4bpp-ADOBE_DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_04_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_ADOBE_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }




            {
                String fn = "8bpp-DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_08_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "8bpp-LZW";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_08_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "8bpp-PACKBITS";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_08_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_PACKBITS);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "8bpp-ADOBE_DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_08_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_ADOBE_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "8bppGrayscale-JPEG";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_08_BPP | FREE_IMAGE_COLOR_DEPTH.FICD_FORCE_GREYSCALE);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_JPEG);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }



            {
                String fn = "24bpp-DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_24_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "24bpp-LZW";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_24_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "24bpp-PACKBITS";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_24_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_PACKBITS);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "24bpp-ADOBE_DEFLATE";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_24_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_ADOBE_DEFLATE);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }
            {
                String fn = "24bpp-JPEG";
                FIBITMAP p32 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FIBITMAP p1 = FreeImage.ConvertColorDepth(p32, FREE_IMAGE_COLOR_DEPTH.FICD_24_BPP);
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_JPEG);
                FreeImage.Unload(p1);
                FreeImage.Unload(p32);
            }




            {
                String fn = "32bpp-DEFLATE";
                FIBITMAP p1 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_DEFLATE);
                FreeImage.Unload(p1);
            }
            {
                String fn = "32bpp-LZW";
                FIBITMAP p1 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
            }
            {
                String fn = "32bpp-PACKBITS";
                FIBITMAP p1 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_PACKBITS);
                FreeImage.Unload(p1);
            }
            {
                String fn = "32bpp-ADOBE_DEFLATE";
                FIBITMAP p1 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_ADOBE_DEFLATE);
                FreeImage.Unload(p1);
            }



            {
                String fn = "8bppGrayscale-JPEG-ExtraSamples";
                FIBITMAP p1 = FreeImage.CreateFromBitmap(Draws(fn, pic));
                //FreeImage.Save(FREE_IMAGE_FORMAT.FIF_TIFF, p1, fn + ".tif", FREE_IMAGE_SAVE_FLAGS.TIFF_LZW);
                FreeImage.Unload(p1);
            }


            StringWriter wr = new StringWriter();
            foreach (String fp in Directory.GetFiles(".", "*.tif")) {
                wr.WriteLine(Resources.Templ
                    .Replace("*", Path.GetFileName(fp))
                    .Replace("?", Path.GetFileName(fp))
                    );
            }
            File.WriteAllText("Templ.txt", wr.ToString());
        }

        Font font = new Font(FontFamily.GenericSansSerif, 18);

        Bitmap Draws(String s, Bitmap pic) {
            pic = (Bitmap)pic.Clone();
            using (Graphics cv = Graphics.FromImage(pic)) {
                cv.DrawString(s, font, Brushes.Black, 120, 180);
                return pic;
            }
        }
    }
}
