using System;

namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.NumericUpDown();
            this.times = new System.Windows.Forms.NumericUpDown();
            this.divided = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.times)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divided)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(172, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time left";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 60);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 52);
            this.plusLeftLabel.TabIndex = 3;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equal.Location = new System.Drawing.Point(215, 61);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 50);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.equal.Click += new System.EventHandler(this.label2_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(107, 62);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 50);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plus.Click += new System.EventHandler(this.label3_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusRightLabel.Location = new System.Drawing.Point(163, 62);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 6;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusRightLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum.Location = new System.Drawing.Point(281, 71);
            this.sum.MaximumSize = new System.Drawing.Size(100, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 122);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 52);
            this.minusLeftLabel.TabIndex = 8;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(107, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 52);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusRightLabel.Location = new System.Drawing.Point(163, 122);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 52);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(215, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 52);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(215, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 52);
            this.label6.TabIndex = 15;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel.Location = new System.Drawing.Point(163, 190);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 52);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(107, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 52);
            this.label8.TabIndex = 13;
            this.label8.Text = "×";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 190);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 52);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(215, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 52);
            this.label10.TabIndex = 19;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel.Location = new System.Drawing.Point(163, 255);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 52);
            this.dividedRightLabel.TabIndex = 18;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(107, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 52);
            this.label12.TabIndex = 17;
            this.label12.Text = "÷";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 255);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 52);
            this.dividedLeftLabel.TabIndex = 16;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(281, 132);
            this.minus.MaximumSize = new System.Drawing.Size(100, 0);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(100, 35);
            this.minus.TabIndex = 2;
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.times.Location = new System.Drawing.Point(281, 200);
            this.times.MaximumSize = new System.Drawing.Size(100, 0);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(100, 35);
            this.times.TabIndex = 3;
            // 
            // divided
            // 
            this.divided.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divided.Location = new System.Drawing.Point(281, 265);
            this.divided.MaximumSize = new System.Drawing.Size(100, 0);
            this.divided.Name = "divided";
            this.divided.Size = new System.Drawing.Size(100, 35);
            this.divided.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(146, 310);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.divided);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.times)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divided)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.NumericUpDown minus;
        private System.Windows.Forms.NumericUpDown times;
        private System.Windows.Forms.NumericUpDown divided;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

