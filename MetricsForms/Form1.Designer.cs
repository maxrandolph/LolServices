namespace MetricsForms
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
            this.resultsDisplay = new System.Windows.Forms.TextBox();
            this.summonerName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsDisplay
            // 
            this.resultsDisplay.Location = new System.Drawing.Point(161, 180);
            this.resultsDisplay.Multiline = true;
            this.resultsDisplay.Name = "resultsDisplay";
            this.resultsDisplay.Size = new System.Drawing.Size(454, 136);
            this.resultsDisplay.TabIndex = 0;
            this.resultsDisplay.TextChanged += new System.EventHandler(this.resultsDisplay_TextChanged);
            // 
            // summonerName
            // 
            this.summonerName.Location = new System.Drawing.Point(169, 117);
            this.summonerName.Name = "summonerName";
            this.summonerName.Size = new System.Drawing.Size(286, 22);
            this.summonerName.TabIndex = 1;
            this.summonerName.TextChanged += new System.EventHandler(this.summonerName_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(503, 116);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 468);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.summonerName);
            this.Controls.Add(this.resultsDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultsDisplay;
        private System.Windows.Forms.TextBox summonerName;
        private System.Windows.Forms.Button submit;
    }
}

