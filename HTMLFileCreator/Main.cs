using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HTMLFileCreator.Pages;
using System.IO;


namespace HTMLFileCreator
{
    public partial class Main : Form
    {
        static string[] _words = { "Sam", "Dot", "Perls" };
        string destinationDir = @"C:\Users\Zheng\Desktop\WebGeneratedFile";
        int pageCounts = 1;

        public Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load current working folder to text box
            this.txt_dstDir.Text = destinationDir;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            IndexPage indexPage = new IndexPage("index");
            indexPage.generatePage(destinationDir);

            EmptyPage emptyPage = new EmptyPage("page" + pageCounts++);
            emptyPage.generatePage(destinationDir);

            // Copy lib, js template files to desination folder
            try
            {
                string path = destinationDir + "/libs";
                Utils.Util.DirectoryCopy("libs", path, true);

                string jsTemplatePath = destinationDir + "/jstemplate/backbone";
                Utils.Util.DirectoryCopy("jstemplate/backbone", jsTemplatePath, true);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();

            folderBrowserDialog1.Description =
            "Select the directory that you want to use as the default.";


            // Do not allow the user to create new files via the FolderBrowserDialog. 
            folderBrowserDialog1.ShowNewFolderButton = false;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                
                // No file is opened, bring up openFileDialog in selected path.
                this.txt_dstDir.Text = folderName;
            }

            destinationDir = this.txt_dstDir.Text;
        }

        private void btn_addPage_Click(object sender, EventArgs e)
        {
            EmptyPage emptyPage = new EmptyPage("page" + pageCounts++);
            emptyPage.generatePage(destinationDir);
        }
    }
}
