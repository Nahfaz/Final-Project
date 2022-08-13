using System;
using System.IO;
using System.Windows.Forms;

namespace lab5
{
    public partial class frmTextEditor : Form
    {


        public frmTextEditor()
        {
            InitializeComponent();
        }



        private void NewTool_Click(object sender, EventArgs e)
        {
            txtEditor.Text = String.Empty;
           // openFileDialog.FileName = String.Empty;
        }

        private void SaveAsTool_Click(object sender, EventArgs e)
        {
            StreamWriter outputStream;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                outputStream = new StreamWriter(saveFileDialog.FileName);
                outputStream.Write(txtEditor.Text);
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
                outputStream.Close();

            }
        }
        /// <summary>
        /// occurs when copy from edit menu clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void ExitTool_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CopyTool_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEditor.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEditor.SelectedText);
            txtEditor.SelectedText = "";
        }

        private void AboutTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NETD 2202 \n\n Lab 5 \n\n Syed Ahmed");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectedText = Clipboard.GetText();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == String.Empty)
            {
                StreamWriter outputStream;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    outputStream = new StreamWriter(saveFileDialog.FileName);
                    outputStream.Write(txtEditor.Text);
                    saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
                    outputStream.Close();
                }

            }

            else
            {
                SaveFile(openFileDialog.FileName, txtEditor.Text);
            }
        }

        private void SaveFile(String fileNAme, String textToWrite)
        {
            FileStream fWrite = new FileStream(fileNAme, (FileMode)ImeMode.On, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fWrite);
            sw.Write(textToWrite);
            fWrite.Close();
            sw.Close();

        }
        /// <summary>
        /// ocurs when open button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader inputStream;

            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                inputStream = new StreamReader(openFileDialog.FileName);
                txtEditor.Text = inputStream.ReadToEnd();
                inputStream.Close();

            }
        }
    }
}
