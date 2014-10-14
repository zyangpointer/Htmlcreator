using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.UI;
using System.IO;

namespace HTMLFileCreator.Pages
{
    public class EmptyPage : PageBase
    {
        public EmptyPage(string name) : base(name) { }
    

        protected override void generatePageContent(ref StringWriter stringWriter)
        {
            // Put HtmlTextWriter in using block because it needs to call Dispose.
            using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
            {

                writer.RenderBeginTag(HtmlTextWriterTag.Html);

                // Head tag
                writer.RenderBeginTag(HtmlTextWriterTag.Head);

                writer.RenderEndTag();

                writer.WriteLine();

                // Body tag
                writer.RenderBeginTag(HtmlTextWriterTag.Body);

                // Add a paragraph
                writer.RenderBeginTag("p");
                writer.Write("Empty page");
                writer.RenderEndTag();
                writer.WriteLine();

                // Body tag end
                writer.RenderEndTag();

                // Html tag end
                writer.RenderEndTag();
            }
        }
    }
}
