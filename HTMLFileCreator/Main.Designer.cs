namespace HTMLFileCreator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_dstDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(41, 114);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(149, 49);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_dstDir
            // 
            this.txt_dstDir.Location = new System.Drawing.Point(78, 49);
            this.txt_dstDir.Name = "txt_dstDir";
            this.txt_dstDir.Size = new System.Drawing.Size(220, 20);
            this.txt_dstDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addPage
            // 
            this.btn_addPage.Location = new System.Drawing.Point(196, 114);
            this.btn_addPage.Name = "btn_addPage";
            this.btn_addPage.Size = new System.Drawing.Size(149, 49);
            this.btn_addPage.TabIndex = 4;
            this.btn_addPage.Text = "Add Page";
            this.btn_addPage.UseVisualStyleBackColor = true;
            this.btn_addPage.Click += new System.EventHandler(this.btn_addPage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 175);
            this.Controls.Add(this.btn_addPage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dstDir);
            this.Controls.Add(this.btn_create);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_dstDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addPage;
    }
}

