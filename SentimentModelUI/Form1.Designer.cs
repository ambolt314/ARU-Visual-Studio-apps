namespace SentimentModelUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.pnlSentiment = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a review:";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(559, 154);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(188, 58);
            this.btnSubmitReview.TabIndex = 1;
            this.btnSubmitReview.Text = "Submit";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(27, 154);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(490, 47);
            this.txtReview.TabIndex = 2;
            // 
            // pnlSentiment
            // 
            this.pnlSentiment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSentiment.Enabled = false;
            this.pnlSentiment.Location = new System.Drawing.Point(27, 244);
            this.pnlSentiment.Name = "pnlSentiment";
            this.pnlSentiment.Size = new System.Drawing.Size(720, 184);
            this.pnlSentiment.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSentiment);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sentiment analyser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSubmitReview;
        private TextBox txtReview;
        private Panel pnlSentiment;
    }
}