namespace texteditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.fpath = new System.Windows.Forms.TextBox();
            this.selpath = new System.Windows.Forms.Button();
            this.openf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textsize = new System.Windows.Forms.NumericUpDown();
            this.content = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.symbolcoun = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.textsize)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите файл";
            // 
            // fpath
            // 
            this.fpath.Location = new System.Drawing.Point(98, 13);
            this.fpath.Name = "fpath";
            this.fpath.Size = new System.Drawing.Size(377, 20);
            this.fpath.TabIndex = 1;
            // 
            // selpath
            // 
            this.selpath.Location = new System.Drawing.Point(515, 9);
            this.selpath.Name = "selpath";
            this.selpath.Size = new System.Drawing.Size(75, 23);
            this.selpath.TabIndex = 2;
            this.selpath.Text = "Выбрать";
            this.selpath.UseVisualStyleBackColor = true;
            // 
            // openf
            // 
            this.openf.Location = new System.Drawing.Point(596, 9);
            this.openf.Name = "openf";
            this.openf.Size = new System.Drawing.Size(75, 23);
            this.openf.TabIndex = 3;
            this.openf.Text = "Открыть";
            this.openf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Размер шрифта";
            // 
            // textsize
            // 
            this.textsize.Location = new System.Drawing.Point(136, 43);
            this.textsize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.textsize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(120, 20);
            this.textsize.TabIndex = 5;
            this.textsize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // content
            // 
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.Location = new System.Drawing.Point(16, 79);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.content.Size = new System.Drawing.Size(687, 265);
            this.content.TabIndex = 6;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(628, 350);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.symbolcoun});
            this.statusStrip2.Location = new System.Drawing.Point(0, 391);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(715, 22);
            this.statusStrip2.TabIndex = 8;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel2.Text = "Кол-во символов";
            // 
            // symbolcoun
            // 
            this.symbolcoun.Name = "symbolcoun";
            this.symbolcoun.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(715, 413);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.content);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.openf);
            this.Controls.Add(this.selpath);
            this.Controls.Add(this.fpath);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textsize)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Button forSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fpath;
        private System.Windows.Forms.Button selpath;
        private System.Windows.Forms.Button openf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown textsize;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel symbolcoun;
    }
}

