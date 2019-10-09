namespace WindowsFormsApp1
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
            this.buttonPara = new System.Windows.Forms.Button();
            this.listBoxPrimes = new System.Windows.Forms.ListBox();
            this.inputEnd = new System.Windows.Forms.NumericUpDown();
            this.inputStart = new System.Windows.Forms.NumericUpDown();
            this.buttonSeq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPara
            // 
            this.buttonPara.Location = new System.Drawing.Point(193, 451);
            this.buttonPara.Name = "buttonPara";
            this.buttonPara.Size = new System.Drawing.Size(175, 100);
            this.buttonPara.TabIndex = 0;
            this.buttonPara.Text = "Search for primes parallel!";
            this.buttonPara.UseVisualStyleBackColor = true;
            this.buttonPara.Click += new System.EventHandler(this.PrimesButtonPara);
            // 
            // listBoxPrimes
            // 
            this.listBoxPrimes.FormattingEnabled = true;
            this.listBoxPrimes.Location = new System.Drawing.Point(12, 12);
            this.listBoxPrimes.Name = "listBoxPrimes";
            this.listBoxPrimes.Size = new System.Drawing.Size(356, 368);
            this.listBoxPrimes.TabIndex = 1;
            // 
            // inputEnd
            // 
            this.inputEnd.Location = new System.Drawing.Point(12, 414);
            this.inputEnd.Name = "inputEnd";
            this.inputEnd.Size = new System.Drawing.Size(356, 20);
            this.inputEnd.TabIndex = 5;
            // 
            // inputStart
            // 
            this.inputStart.Location = new System.Drawing.Point(12, 386);
            this.inputStart.Name = "inputStart";
            this.inputStart.Size = new System.Drawing.Size(356, 20);
            this.inputStart.TabIndex = 4;
            // 
            // buttonSeq
            // 
            this.buttonSeq.Location = new System.Drawing.Point(12, 451);
            this.buttonSeq.Name = "buttonSeq";
            this.buttonSeq.Size = new System.Drawing.Size(175, 100);
            this.buttonSeq.TabIndex = 6;
            this.buttonSeq.Text = "Search for primes sequential!";
            this.buttonSeq.UseVisualStyleBackColor = true;
            this.buttonSeq.Click += new System.EventHandler(this.PrimesButtonSequ);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 563);
            this.Controls.Add(this.buttonSeq);
            this.Controls.Add(this.inputStart);
            this.Controls.Add(this.inputEnd);
            this.Controls.Add(this.listBoxPrimes);
            this.Controls.Add(this.buttonPara);
            this.Name = "Form1";
            this.Text = "FormPrimes";
            ((System.ComponentModel.ISupportInitialize)(this.inputEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPara;
        private System.Windows.Forms.ListBox listBoxPrimes;
        private System.Windows.Forms.NumericUpDown inputEnd;
        private System.Windows.Forms.NumericUpDown inputStart;
        private System.Windows.Forms.Button buttonSeq;
    }
}

