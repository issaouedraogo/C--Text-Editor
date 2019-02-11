namespace Editer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRTFDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsRTFDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.CboFontSize = new System.Windows.Forms.ComboBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openRTFDocumentToolStripMenuItem,
            this.saveAsTextFileToolStripMenuItem,
            this.saveAsRTFDocumentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openToolStripMenuItem.Text = "&Open Text File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openRTFDocumentToolStripMenuItem
            // 
            this.openRTFDocumentToolStripMenuItem.Name = "openRTFDocumentToolStripMenuItem";
            this.openRTFDocumentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openRTFDocumentToolStripMenuItem.Text = "O&pen RTF Document";
            // 
            // saveAsTextFileToolStripMenuItem
            // 
            this.saveAsTextFileToolStripMenuItem.Name = "saveAsTextFileToolStripMenuItem";
            this.saveAsTextFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsTextFileToolStripMenuItem.Text = "Save as &Text File";
            this.saveAsTextFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextFileToolStripMenuItem_Click);
            // 
            // saveAsRTFDocumentToolStripMenuItem
            // 
            this.saveAsRTFDocumentToolStripMenuItem.Name = "saveAsRTFDocumentToolStripMenuItem";
            this.saveAsRTFDocumentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsRTFDocumentToolStripMenuItem.Text = "Save as &RTF Document";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(168, 27);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(64, 29);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(308, 27);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(57, 29);
            this.btnItalic.TabIndex = 2;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(238, 27);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(64, 29);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(371, 27);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(86, 29);
            this.btnUnderline.TabIndex = 5;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // CboFontSize
            // 
            this.CboFontSize.FormattingEnabled = true;
            this.CboFontSize.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "20",
            "21"});
            this.CboFontSize.Location = new System.Drawing.Point(12, 36);
            this.CboFontSize.Name = "CboFontSize";
            this.CboFontSize.Size = new System.Drawing.Size(121, 21);
            this.CboFontSize.TabIndex = 6;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 63);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(534, 430);
            this.rtbDisplay.TabIndex = 7;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 505);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.CboFontSize);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Super Editor";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRTFDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsRTFDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnItalic;
        protected System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.ComboBox CboFontSize;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

