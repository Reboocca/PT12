using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_EventApp.Classes
{
    class Festival
    {
        public string idFestival { get; private set; }
        public string Name { get; private set; }
        public string Desc { get; private set; }
        public string Join { get; private set; }
        public string Match { get; private set; }
        public Bitmap Foto { get; private set; }

        private float width = 60;
        private float height = 60;

        /// <summary>
        /// Make a new festival
        /// </summary>
        /// <param name="naam">Name of the festival</param>
        /// <param name="url">Url to the picture of the festival</param>
        public Festival(string naam, string url, string id, string l, string p, DateTime d)
        {
            setFoto(url);
            Name = naam;
            Desc = naam + " vind plaats in " + l + " op " + d.ToShortDateString() + " kaartjes kosten: " + p;

            idFestival = id;

            //Buttons for the ObjectListBox
            Join    = "J";
            Match   = "M";
        }

        public Festival()
        {
            //empty constructor
        }

        /// <summary>
        /// Sets the bitmap image of this Festival to the picture in the url
        /// </summary>
        /// <param name="url">Url to the picture</param>
        private void setFoto(string url)
        {
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = request.GetResponse();
            System.IO.Stream respStream = resp.GetResponseStream();
            Bitmap bmp = new Bitmap(respStream);
            respStream.Dispose();

            Foto = resizeImg(bmp);
        }

        //SOURCE: https://stackoverflow.com/questions/10442269/scaling-a-system-drawing-bitmap-to-a-given-size-while-maintaining-aspect-ratio
        private Bitmap resizeImg(Bitmap image)
        {
            var brush   = new SolidBrush(Color.Black);
            float scale = Math.Min(width / image.Width, height / image.Height);

            var bmpResized  = new Bitmap((int)width, (int)height);
            var graph       = Graphics.FromImage(bmpResized);

            graph.InterpolationMode     = InterpolationMode.High;
            graph.CompositingQuality    = CompositingQuality.HighQuality;
            graph.SmoothingMode         = SmoothingMode.AntiAlias;

            float scaleWidth    = (int)(image.Width * scale);
            float scaleHeight   = (int)(image.Height * scale);

            graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
            graph.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);

            return bmpResized;
        }
    }
}