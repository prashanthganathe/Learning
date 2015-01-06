using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//For converting HTML TO PDF- START
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.util;
using System.Text.RegularExpressions;
using iTextSharp.tool.xml;
using System.Net;
using iTextSharp.tool.xml.parser;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.pipeline.html;
using iTextSharp.tool.xml.html;
using System.Text;
//For converting HTML TO PDF- END

namespace HTMLPDF
{
    public partial class _Default : Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
         
            Generate();
        }


        public void Generate()
        {
            string contents = File.ReadAllText(HttpContext.Current.Server.MapPath("contact.aspx?id=dsfjjj"));
           
           

            string receiptString = contents;// this.GetReceiptString(contents);

            string PdfPathwithName = Server.MapPath("~") + "\\temp\\" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".pdf";

            Document document = new Document(PageSize.B4);

            PdfWriter writer = PdfWriter.GetInstance(

            document,

            new FileStream(PdfPathwithName, FileMode.Create));

            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, document.PageSize.Height, 1.00f);

            document.Open();

            PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, writer);

            writer.SetOpenAction(action);

            XMLWorkerFontProvider fontProvider = new XMLWorkerFontProvider();

            CssAppliers cssAppliers = new CssAppliersImpl(fontProvider);

            HtmlPipelineContext htmlContext = new HtmlPipelineContext(cssAppliers);

            htmlContext.SetTagFactory(Tags.GetHtmlTagProcessorFactory());

            ICSSResolver cssResolver = XMLWorkerHelper.GetInstance().GetDefaultCssResolver(true);

            IPipeline pipeline = new CssResolverPipeline(cssResolver, new HtmlPipeline(htmlContext, new PdfWriterPipeline(document, writer)));

            XMLWorker worker = new XMLWorker(pipeline, true);

            XMLParser p = new XMLParser(true, worker, Encoding.UTF8);

            TextReader reader = new StringReader(receiptString);

            p.Parse(reader);

            p.Flush();

            document.Close();

            document.Dispose();
        }
        

       

    
    }
}