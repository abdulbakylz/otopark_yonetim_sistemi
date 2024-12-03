namespace otoparkclass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            girisbtn = new Button();
            cikisbtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ARAÇ  TİPİ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(33, 173);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "MİNİBÜS";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(33, 114);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "TİCARİ ARAÇ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 59);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "TAKSİ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 129);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 4;
            label1.Text = "ARAÇ GİRİŞ SAATİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 219);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 5;
            label2.Text = "ARAÇ ÇIKIŞ SAAATİ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 28);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 7;
            label3.Text = "PLAKAYI GİRİNİZ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // girisbtn
            // 
            girisbtn.Location = new Point(533, 48);
            girisbtn.Name = "girisbtn";
            girisbtn.Size = new Size(168, 53);
            girisbtn.TabIndex = 10;
            girisbtn.Text = "OTOPARKA GİRİŞ";
            girisbtn.UseVisualStyleBackColor = true;
            girisbtn.Click += girisbtn_Click_1;
            // 
            // cikisbtn
            // 
            cikisbtn.Location = new Point(533, 201);
            cikisbtn.Name = "cikisbtn";
            cikisbtn.Size = new Size(168, 56);
            cikisbtn.TabIndex = 11;
            cikisbtn.Text = "OTOPARKTAN ÇIKIŞ";
            cikisbtn.TextImageRelation = TextImageRelation.TextAboveImage;
            cikisbtn.UseVisualStyleBackColor = true;
            cikisbtn.Click += cikisbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(766, 359);
            Controls.Add(cikisbtn);
            Controls.Add(girisbtn);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "OTOPARK YÖNETİM SİSTEMİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button girisbtn;
        private Button cikisbtn;
    }
}
