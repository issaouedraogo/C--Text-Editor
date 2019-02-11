using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFILE = new OpenFileDialog();
            oFILE.Title = "Choose a path and type the file name.";
            oFILE.InitialDirectory = @"U:\Data";
            oFILE.Filter =
                "Text file(*.txt)|*.txt|Log files(*.log)*.log|All files(*.*)|*.*";
            DialogResult x = oFILE.ShowDialog();
            if (x == DialogResult.OK)
            {
                try
                {
                    // streamReader imfiles;
                    // infile = File.OpenText(oFile.FileName);
                    // one line statement is also fine.
                    StreamReader infile = new StreamReader(oFILE.FileName);
                    rtbDisplay.Text = infile.ReadToEnd();
                    //String SomeString;
                    //StreamReader sw = new StreamReader(sd.FileName);
                    //SomeString = sw.ReadToEnd();
                    //rtbDisplay.Text = SomeString;
                    //sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void saveAsTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFile = new SaveFileDialog();
            sFile.Title = "Choose a path and type the file name.";
            sFile.InitialDirectory = @"U:\Data";
            sFile.Filter =
                 "Text file(*.txt)|*.txt|Log files(*.log)*.log|All files(*.*)|*.*";
            DialogResult dResult = sFile.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                try
                {
                    // String SomeString;
                    StreamWriter outFile = new StreamWriter(sFile.FileName);
                    outFile.Write(rtbDisplay.Text);
                    outFile.Close();
                    MessageBox.Show("File Saved.");

                    //SomeString = sw.ReadToEnd();
                    //rtbDisplay.Text = SomeString;
                    //sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Welcome wform = new Welcome();
            wform.ShowDialog();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbDisplay.SelectionFont;
            new1 = new Font(old1, FontStyle.Regular);
            rtbDisplay.SelectionFont = new1;
            rtbDisplay.Focus();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbDisplay.SelectionFont;
            if (old1.Bold)
            {
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            }
            else
            {
                new1 = new Font(old1, old1.Style | FontStyle.Bold);
            }


        }
    }
}
