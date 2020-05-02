using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace econ_lab3
{
    public partial class Constructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //Create a pdf document.
            using (PdfDocument doc = new PdfDocument())
            {
                // Create one page
                PdfPageBase page = doc.Pages.Add();

                float fontSize = 10f;
                //Draw a dashed line
                PdfPen pen1 = new PdfPen(PdfBrushes.DarkGray, 1f);
                PdfPen pen2 = new PdfPen(PdfBrushes.DarkGray, 2f);

                page.Canvas.DrawString(TextBox2.Text + " " + TextBox1.Text, new PdfFont(PdfFontFamily.TimesRoman, 24), new PdfSolidBrush(Color.Black), 0, 0);
                page.Canvas.DrawLine(pen2, new PointF(0, 30), new PointF(page.Canvas.Size.Width, 30));
                page.Canvas.DrawString("E-mail: ", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 50);
                page.Canvas.DrawString(TextBox3.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 50);
                page.Canvas.DrawString("Address: ", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 70);
                page.Canvas.DrawString(TextBox4.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 70);
                page.Canvas.DrawString("Phone number: ", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 90);
                page.Canvas.DrawString(TextBox5.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 90);
                page.Canvas.DrawString("Languages:", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 110);
                page.Canvas.DrawString(TextBox21.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 110);
                //Draw the image
                string url = TextBox32.Text;
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(url), @"D:\photo.jpg");
                }
                PdfImage image = PdfImage.FromFile(@"D:\photo.jpg");
                page.Canvas.DrawImage(image, 415, 40, 90, 110);
                page.Canvas.DrawLine(pen1, new PointF(0, 160), new PointF(page.Canvas.Size.Width, 160));
                page.Canvas.DrawString("Objectives", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 175);
                page.Canvas.DrawString(TextBox6.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 175);
                page.Canvas.DrawString("Interests", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 195);
                page.Canvas.DrawString(TextBox22.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 195);
                page.Canvas.DrawLine(pen1, new PointF(0, 220), new PointF(page.Canvas.Size.Width, 220));
                page.Canvas.DrawString("Education", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 235);
                page.Canvas.DrawString(TextBox7.Text + " - " + TextBox28.Text + "\n" + TextBox15.Text + "\n" + TextBox14.Text + "\n" + TextBox13.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 85, 235);
                page.Canvas.DrawLine(pen1, new PointF(0, 290), new PointF(page.Canvas.Size.Width, 290));
                page.Canvas.DrawString("Skills", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 10, 305);
                page.Canvas.DrawString("Programming Languages/Technologies", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 325);
                page.Canvas.DrawString(TextBox16.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 10, 340);
                page.Canvas.DrawString("Frameworks", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 390);
                page.Canvas.DrawString(TextBox17.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 10, 405);
                page.Canvas.DrawString("Databases", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 280, 325);
                page.Canvas.DrawString(TextBox18.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 280, 340);
                page.Canvas.DrawString("Development tools", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 280, 375);
                page.Canvas.DrawString(TextBox19.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 280, 390);
                page.Canvas.DrawString("Operation systems", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 280, 425);
                page.Canvas.DrawString(TextBox20.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 280, 440);
                page.Canvas.DrawLine(pen1, new PointF(0, 475), new PointF(page.Canvas.Size.Width, 475));
                page.Canvas.DrawString("Work experience", new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Blue), 10, 490);
                page.Canvas.DrawString(TextBox11.Text + " - " + TextBox31.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 490);
                page.Canvas.DrawString(TextBox10.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 505);
                page.Canvas.DrawString(TextBox12.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 535);

                if (!string.IsNullOrEmpty(TextBox27.Text))
                {
                    page.Canvas.DrawString(TextBox8.Text + " - " + TextBox9.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 490);
                    page.Canvas.DrawString(TextBox27.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 505);
                    page.Canvas.DrawString(TextBox29.Text, new PdfFont(PdfFontFamily.TimesRoman, fontSize), new PdfSolidBrush(Color.Black), 95, 535);
                }

                //Save pdf file.
                doc.SaveToFile(@"D:\resume.pdf");
            }

            string path = @"D:\resume.pdf";
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=resume.pdf");
            Response.AddHeader("Content-Length", file.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(path);
            Response.Flush();
            Response.End();
        }
    }
}