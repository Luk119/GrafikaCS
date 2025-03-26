namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Close = new System.Windows.Forms.Button();
            this.SetBackgroundColor = new System.Windows.Forms.Button();
            this.ClearPicture = new System.Windows.Forms.Button();
            this.showPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.Location = new System.Drawing.Point(3, 410);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(60, 17);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Stretch";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 401);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Controls.Add(this.Close);
            this.flowLayoutPanel1.Controls.Add(this.SetBackgroundColor);
            this.flowLayoutPanel1.Controls.Add(this.ClearPicture);
            this.flowLayoutPanel1.Controls.Add(this.showPicture);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(112, 410);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 32);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Location = new System.Drawing.Point(539, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 12;
            this.Close.Text = "Zamknij";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SetBackgroundColor
            // 
            this.SetBackgroundColor.AutoSize = true;
            this.SetBackgroundColor.Location = new System.Drawing.Point(444, 3);
            this.SetBackgroundColor.Name = "SetBackgroundColor";
            this.SetBackgroundColor.Size = new System.Drawing.Size(89, 23);
            this.SetBackgroundColor.TabIndex = 11;
            this.SetBackgroundColor.Text = "Ustaw kolor tła";
            this.SetBackgroundColor.UseVisualStyleBackColor = true;
            this.SetBackgroundColor.Click += new System.EventHandler(this.SetBackgroundColor_Click);
            // 
            // ClearPicture
            // 
            this.ClearPicture.AutoSize = true;
            this.ClearPicture.Location = new System.Drawing.Point(348, 3);
            this.ClearPicture.Name = "ClearPicture";
            this.ClearPicture.Size = new System.Drawing.Size(90, 23);
            this.ClearPicture.TabIndex = 10;
            this.ClearPicture.Text = "Wyczyść obraz";
            this.ClearPicture.UseVisualStyleBackColor = true;
            this.ClearPicture.Click += new System.EventHandler(this.ClearPicture_Click);
            // 
            // showPicture
            // 
            this.showPicture.AutoSize = true;
            this.showPicture.Location = new System.Drawing.Point(266, 3);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(76, 23);
            this.showPicture.TabIndex = 9;
            this.showPicture.Text = "Pokaż obraz";
            this.showPicture.UseVisualStyleBackColor = true;
            this.showPicture.Click += new System.EventHandler(this.ShowPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Wybierz plik obrazzu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "przeglądarki obrazów";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox Button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button SetBackgroundColor;
        private System.Windows.Forms.Button ClearPicture;
        private System.Windows.Forms.Button showPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

