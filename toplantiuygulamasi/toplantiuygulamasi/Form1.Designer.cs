namespace toplantiuygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toplantiolustur = new System.Windows.Forms.Button();
            this.toplantiyakatil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhaba Toplantı Uygulamasına Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // toplantiolustur
            // 
            this.toplantiolustur.BackColor = System.Drawing.Color.LavenderBlush;
            this.toplantiolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantiolustur.Location = new System.Drawing.Point(8, 115);
            this.toplantiolustur.Name = "toplantiolustur";
            this.toplantiolustur.Size = new System.Drawing.Size(222, 43);
            this.toplantiolustur.TabIndex = 2;
            this.toplantiolustur.Text = "Toplantı Oluştur";
            this.toplantiolustur.UseVisualStyleBackColor = false;
            this.toplantiolustur.Click += new System.EventHandler(this.toplantiolustur_Click);
            // 
            // toplantiyakatil
            // 
            this.toplantiyakatil.BackColor = System.Drawing.Color.LavenderBlush;
            this.toplantiyakatil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplantiyakatil.Location = new System.Drawing.Point(8, 173);
            this.toplantiyakatil.Name = "toplantiyakatil";
            this.toplantiyakatil.Size = new System.Drawing.Size(209, 43);
            this.toplantiyakatil.TabIndex = 3;
            this.toplantiyakatil.Text = "Toplantıya Katıl";
            this.toplantiyakatil.UseVisualStyleBackColor = false;
            this.toplantiyakatil.Click += new System.EventHandler(this.toplantiyakatil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.toplantiyakatil);
            this.Controls.Add(this.toplantiolustur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toplantiolustur;
        private System.Windows.Forms.Button toplantiyakatil;
    }
}

