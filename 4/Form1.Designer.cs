namespace _4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAlısveris = new System.Windows.Forms.CheckBox();
            this.checkBoxSpor = new System.Windows.Forms.CheckBox();
            this.checkBoxDers = new System.Windows.Forms.CheckBox();
            this.buttonGoster1 = new System.Windows.Forms.Button();
            this.checkedListBoxYapilacaklar = new System.Windows.Forms.CheckedListBox();
            this.buttonGoster2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGoster1);
            this.groupBox1.Controls.Add(this.checkBoxDers);
            this.groupBox1.Controls.Add(this.checkBoxSpor);
            this.groupBox1.Controls.Add(this.checkBoxAlısveris);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılacaklar";
            // 
            // checkBoxAlısveris
            // 
            this.checkBoxAlısveris.AutoSize = true;
            this.checkBoxAlısveris.Location = new System.Drawing.Point(19, 40);
            this.checkBoxAlısveris.Name = "checkBoxAlısveris";
            this.checkBoxAlısveris.Size = new System.Drawing.Size(92, 24);
            this.checkBoxAlısveris.TabIndex = 0;
            this.checkBoxAlısveris.Text = "Alışveriş";
            this.checkBoxAlısveris.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpor
            // 
            this.checkBoxSpor.AutoSize = true;
            this.checkBoxSpor.Location = new System.Drawing.Point(19, 82);
            this.checkBoxSpor.Name = "checkBoxSpor";
            this.checkBoxSpor.Size = new System.Drawing.Size(69, 24);
            this.checkBoxSpor.TabIndex = 1;
            this.checkBoxSpor.Text = "Spor";
            this.checkBoxSpor.UseVisualStyleBackColor = true;
            // 
            // checkBoxDers
            // 
            this.checkBoxDers.AutoSize = true;
            this.checkBoxDers.Location = new System.Drawing.Point(19, 128);
            this.checkBoxDers.Name = "checkBoxDers";
            this.checkBoxDers.Size = new System.Drawing.Size(69, 24);
            this.checkBoxDers.TabIndex = 2;
            this.checkBoxDers.Text = "Ders";
            this.checkBoxDers.UseVisualStyleBackColor = true;
            // 
            // buttonGoster1
            // 
            this.buttonGoster1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGoster1.Location = new System.Drawing.Point(59, 185);
            this.buttonGoster1.Name = "buttonGoster1";
            this.buttonGoster1.Size = new System.Drawing.Size(167, 91);
            this.buttonGoster1.TabIndex = 3;
            this.buttonGoster1.Text = "Seçilenleri Göster";
            this.buttonGoster1.UseVisualStyleBackColor = true;
            this.buttonGoster1.Click += new System.EventHandler(this.buttonGoster1_Click);
            // 
            // checkedListBoxYapilacaklar
            // 
            this.checkedListBoxYapilacaklar.FormattingEnabled = true;
            this.checkedListBoxYapilacaklar.Items.AddRange(new object[] {
            "Alışveriş",
            "Spor",
            "Ders"});
            this.checkedListBoxYapilacaklar.Location = new System.Drawing.Point(389, 33);
            this.checkedListBoxYapilacaklar.Name = "checkedListBoxYapilacaklar";
            this.checkedListBoxYapilacaklar.Size = new System.Drawing.Size(246, 277);
            this.checkedListBoxYapilacaklar.TabIndex = 1;
            // 
            // buttonGoster2
            // 
            this.buttonGoster2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGoster2.Location = new System.Drawing.Point(444, 208);
            this.buttonGoster2.Name = "buttonGoster2";
            this.buttonGoster2.Size = new System.Drawing.Size(122, 69);
            this.buttonGoster2.TabIndex = 2;
            this.buttonGoster2.Text = "Seçilenleri Göster";
            this.buttonGoster2.UseVisualStyleBackColor = true;
            this.buttonGoster2.Click += new System.EventHandler(this.buttonGoster2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGoster2);
            this.Controls.Add(this.checkedListBoxYapilacaklar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGoster1;
        private System.Windows.Forms.CheckBox checkBoxDers;
        private System.Windows.Forms.CheckBox checkBoxSpor;
        private System.Windows.Forms.CheckBox checkBoxAlısveris;
        private System.Windows.Forms.CheckedListBox checkedListBoxYapilacaklar;
        private System.Windows.Forms.Button buttonGoster2;
    }
}

