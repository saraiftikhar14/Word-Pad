using System.Windows.Forms;
using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace WordPadLasAssignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void sendInEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*String imageLocation = "";
            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = dialog.FileName;
                    
                   
                }
                
            }
            catch(Exception) 
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg;" +
                    " *.jpeg; *.gif; *.png; *.bmp";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    Clipboard.SetImage(Image.FromFile(op.FileName));
                    richTextBox1.Paste();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Title = "Open";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog open1 = new SaveFileDialog();
            open1.Title = "Save";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog open1 = new SaveFileDialog();
            open1.Title = "Save";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void richTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Title = "Open";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void plainTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Title = "Open";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void otherFormatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog open1 = new SaveFileDialog();
            open1.Title = "Save";
            open1.Filter = "TextDocument(*.txt)|*.txt|All Files(*.*)|*.*";
            if (open1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(open1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open1.FileName;
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pnt = new PrintDialog();
            if (pnt.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void pageSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutWordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WordPad is a basic word processor available in every version of Microsoft's " +
                "operating systems since Windows 95." +
                " It can be used to create and modify documents. Although slower to load than Notepad," +
                " it can handle graphics and rich formatting, unlike notepad, along with handling larger files",
                "About WordPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }

        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fnt.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fnt.Color;
            }
        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
            richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void textAlignLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://www.bing.com/search?q=help+with+wordpad+in+windows&filters=guid:%224462934-en-dia%22%20lang:%22en%22&form=T00032&ocid=HelpPane-BingIA",
                "WordPad Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(wordWrapToolStripMenuItem.Checked==true) 
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap=false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void paintDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void picturesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
            richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void textAlignRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = HorizontalAlignment.Left=0;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void textAlignCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = HorizontalAlignment.Center=0;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void textAlignJustifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = HorizontalAlignment.Justift=0;
           
        }

        private void pencilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}