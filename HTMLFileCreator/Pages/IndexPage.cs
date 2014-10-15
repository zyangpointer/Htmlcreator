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
                string LibsScriptPath = "libs/";
                string JSTemplateScriptPath = "jstemplate/";

                // ! underscore declaration must be before backbone
                /// TODO: Adding funcionality of choosing js libs and automatically detect depencies and 
                /// generating loading order
                string[] ScriptNames = { "jquery-2.1.1.min.js", "underscore-min.js", "backbone-min.js", "require.js" };

                string[] JSTemplateScriptNames = { "backbone/backbone-template.js" };

                addScriptTags(writer, LibsScriptPath, ScriptNames);
                addScriptTags(writer, JSTemplateScriptPath, JSTemplateScriptNames);

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
