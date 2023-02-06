using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace PDFGeneratorComparison
{
    public partial class MainForm : Form
    {
        Person samplePerson = new Person(foreName: "Joe", surname: "Bloggs", dateOfBirth: new DateTime(day: 24, month: 2, year: 1987));

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGeneratePDFSharp_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            PdfPage mainPage = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(mainPage);
            XFont titleFont = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont textFont = new XFont("Verdana", 12, XFontStyle.Regular);

            // limitations: better for free writing rather than document creation. Requires that each line use a new gfx.DrawString invocation, as newline characters are not recognised.
            gfx.DrawString($"Biography of {samplePerson.getName()}", titleFont, XBrushes.Black, new XRect(0, 0, mainPage.Width, 150), XStringFormats.Center);
            gfx.DrawString($"Forename: {samplePerson.foreName}\nSurname: {samplePerson.surname}\nDate of birth: {samplePerson.dateOfBirth.Date}\nAge: {samplePerson.getAge()}".Replace("\n", Environment.NewLine), textFont, XBrushes.Black, new XRect(0, 0, mainPage.Width, 300), XStringFormats.Center);






            string fileName = "PDFSharp.pdf";
            document.Save(fileName);
            Process.Start(fileName);
        }
    }
}
