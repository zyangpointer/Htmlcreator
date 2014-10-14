using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Web.UI;

namespace HTMLFileCreator.Pages
{
    public class IndexPage : PageBase
    {
        public IndexPage(string name) : base(name)
        {
            
        }

        protected override void generatePageContent(ref StringWriter stringWriter)
        {
            // Put HtmlTextWriter in using block because it needs to call Dispose.
            using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
            {

                writer.RenderBeginTag(HtmlTextWriterTag.Html);

                // Head tag
                writer.RenderBeginTag(HtmlTextWriterTag.Head);

                // Script block
                string ScriptPath = "libs/";
                string[] ScriptNames = { "backbone-min.js", "require.js", "underscore.js" };

                // Backbone.js
                addScriptTags(writer, ScriptPath, ScriptNames);

                //addScriptBlock(writer, "alert('hello world')");


                writer.RenderEndTag();

                writer.WriteLine();

                // Body tag
                writer.RenderBeginTag(HtmlTextWriterTag.Body);

                // Add a paragraph
                writer.RenderBeginTag("p");
                writer.Write("Hi, there!");
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
