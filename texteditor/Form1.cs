using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texteditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveclick;
        event EventHandler ContentChanged;
    }

    public partial class Form1 : Form, IMainForm
    {
        public Form1()
        {
            InitializeComponent();
            openf.Click += new EventHandler(Openf_Click);
            save.Click += Save_Click;
            content.TextChanged += Content_TextChanged;
            selpath.Click += butSelectFile_Click;
            textsize.ValueChanged += Textsize_ValueChanged;
        }

       
        #region Проброс событий
        private void Content_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(this, EventArgs.Empty);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (FileSaveclick != null)
                FileSaveclick(this, EventArgs.Empty);
        }

        private void Openf_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null)
                FileOpenClick(this, EventArgs.Empty);
        }
        #endregion

        #region IManeForm
        public string FilePath
        {
            get { return fpath.Text; }
        }
        public string Content
        {
            get { return content.Text; }
            set { content.Text = value; }

        }
        public void SetSymbolCount(int count)
        {
            symbolcoun.Text = count.ToString();
                
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveclick;
        public event EventHandler ContentChanged;
        #endregion

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fpath.Text = dlg.FileName;
                if (FileOpenClick != null)
                    FileOpenClick(this, EventArgs.Empty);

            }

        }

        private void Textsize_ValueChanged(object sender, EventArgs e)
        {
            content.Font = new Font("Calibri", (float)textsize.Value);
        }

    }
}
