namespace MouseClick
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nWait = new System.Windows.Forms.NumericUpDown();
            this.nMakro = new System.Windows.Forms.NumericUpDown();
            this.chkMakro = new System.Windows.Forms.CheckBox();
            this.lstBilgi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMakro)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(96, 39);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "c ile konum-s ile start-esc ile iptal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Süre:";
            // 
            // nWait
            // 
            this.nWait.DecimalPlaces = 1;
            this.nWait.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nWait.Location = new System.Drawing.Point(145, 10);
            this.nWait.Name = "nWait";
            this.nWait.Size = new System.Drawing.Size(39, 20);
            this.nWait.TabIndex = 2;
            // 
            // nMakro
            // 
            this.nMakro.Location = new System.Drawing.Point(145, 75);
            this.nMakro.Name = "nMakro";
            this.nMakro.Size = new System.Drawing.Size(39, 20);
            this.nMakro.TabIndex = 7;
            // 
            // chkMakro
            // 
            this.chkMakro.AutoSize = true;
            this.chkMakro.Location = new System.Drawing.Point(83, 78);
            this.chkMakro.Name = "chkMakro";
            this.chkMakro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMakro.Size = new System.Drawing.Size(56, 17);
            this.chkMakro.TabIndex = 8;
            this.chkMakro.Text = "Makro";
            this.chkMakro.UseVisualStyleBackColor = true;
            // 
            // lstBilgi
            // 
            this.lstBilgi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstBilgi.Location = new System.Drawing.Point(190, 12);
            this.lstBilgi.Name = "lstBilgi";
            this.lstBilgi.Size = new System.Drawing.Size(210, 117);
            this.lstBilgi.TabIndex = 9;
            this.lstBilgi.UseCompatibleStateImageBehavior = false;
            this.lstBilgi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nokta";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Süre";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(406, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(406, 42);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(52, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(406, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Durdur";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(116, 42);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRandom.Size = new System.Drawing.Size(68, 17);
            this.chkRandom.TabIndex = 13;
            this.chkRandom.Text = "Rastgele";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 134);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstBilgi);
            this.Controls.Add(this.chkMakro);
            this.Controls.Add(this.nMakro);
            this.Controls.Add(this.nWait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Mouse Click";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.nWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMakro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nWait;
        private System.Windows.Forms.NumericUpDown nMakro;
        private System.Windows.Forms.CheckBox chkMakro;
        private System.Windows.Forms.ListView lstBilgi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Timer timer1;
    }
}

