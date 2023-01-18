namespace SymulatorRS232
{
    partial class Odbiornik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public bool[][] odbTextBin;

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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.konwertuj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wybierzPlik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(570, 118);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 338);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(570, 80);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SymulatorRS232.Properties.Resources.png_transparent_arrow_free_content_quiver_arrow_line_s_angle_text_bow_and_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(363, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // konwertuj
            // 
            this.konwertuj.Location = new System.Drawing.Point(341, 177);
            this.konwertuj.Name = "konwertuj";
            this.konwertuj.Size = new System.Drawing.Size(112, 47);
            this.konwertuj.TabIndex = 4;
            this.konwertuj.Text = "Konwertuj";
            this.konwertuj.UseVisualStyleBackColor = true;
            this.konwertuj.Click += new System.EventHandler(this.konwertuj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "TXT files|*.txt";
            this.openFileDialog1.Title = "Wybierz plik ze słownikiem";
            // 
            // wybierzPlik
            // 
            this.wybierzPlik.Location = new System.Drawing.Point(551, 230);
            this.wybierzPlik.Name = "wybierzPlik";
            this.wybierzPlik.Size = new System.Drawing.Size(196, 32);
            this.wybierzPlik.TabIndex = 6;
            this.wybierzPlik.Text = "Wybierz plik do cenzury";
            this.wybierzPlik.UseVisualStyleBackColor = true;
            this.wybierzPlik.Click += new System.EventHandler(this.wybierzPlik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ścieżka do pliku:";
            // 
            // Odbiornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wybierzPlik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.konwertuj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Location = new System.Drawing.Point(500, 100);
            this.Name = "Odbiornik";
            this.Text = "Odbiornik";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBox2;
        public TextBox textBox1;
        private PictureBox pictureBox1;
        public Button konwertuj;
        private OpenFileDialog openFileDialog1;
        private Button wybierzPlik;
        private Label label1;
        private Label label2;
    }
}