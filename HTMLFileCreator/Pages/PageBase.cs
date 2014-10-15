using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.UI;
using System.IO;

namespace HTMLFileCreator.Pages
{
   

    public abstract class PageBase
    {
        string pageName =  "";
        string htmlExt = ".html";

        public PageBase(string name)
        {
            this.pageName = name;
        }

        public void generatePage(string dstDir)
        {
            // Initialize StringWriter instance.
            StringWriter stringWriter = new StringWriter();

            generatePageContent(ref stringWriter);

            string result = stringWriter.ToString();

            writeOutpage(dstDir, result);
        }

        protected abstract void generatePageContent(ref  StringWriter stringWriter);


        protected void addScriptTags(HtmlTextWriter writer, string ScriptPath, string[] ScriptNames)
        {
            foreach (string name in ScriptNames)
            {
                writer.WriteBeginTag("script");
                writer.WriteAttribute("type", "text/javascript");
                writer.WriteAttribute("src", ScriptPath + name);
                writer.Write(HtmlTextWriter.TagRightChar);
                writer.WriteEndTag("script");
                writer.WriteLine();
            }
        }

        protected void addScriptBlock(HtmlTextWriter writer, string content)
        {
            writer.RenderBeginTag("script");
            writer.Write(content);
            writer.RenderEndTag();
            writer.WriteLine();
        }


        protected void writeOutpage(string dstDir, string content)
        {
            string destinationPath = dstDir.Trim() + "\\" + pageName + htmlExt;
            using (StreamWriter outfile = new StreamWriter(destinationPath)) 
            {
                outfile.Write(content);
            }
        }

    }
}
