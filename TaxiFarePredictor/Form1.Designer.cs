namespace TaxiFarePredictor
{
    partial class frmTaxiFarePredictor
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
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnPredictFare = new System.Windows.Forms.Button();
            this.lblPredictedFare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(43, 44);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(131, 41);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(204, 44);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(250, 47);
            this.txtDistance.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(43, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(218, 41);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time (seconds)";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(280, 115);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(174, 47);
            this.txtTime.TabIndex = 3;
            // 
            // btnPredictFare
            // 
            this.btnPredictFare.Location = new System.Drawing.Point(526, 104);
            this.btnPredictFare.Name = "btnPredictFare";
            this.btnPredictFare.Size = new System.Drawing.Size(188, 58);
            this.btnPredictFare.TabIndex = 4;
            this.btnPredictFare.Text = "Predict fare";
            this.btnPredictFare.UseVisualStyleBackColor = true;
            this.btnPredictFare.Click += new System.EventHandler(this.btnPredictFare_Click);
            // 
            // lblPredictedFare
            // 
            this.lblPredictedFare.AutoSize = true;
            this.lblPredictedFare.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPredictedFare.Location = new System.Drawing.Point(43, 264);
            this.lblPredictedFare.Name = "lblPredictedFare";
            this.lblPredictedFare.Size = new System.Drawing.Size(416, 81);
            this.lblPredictedFare.TabIndex = 5;
            this.lblPredictedFare.Text = "Predicted fare:";
            this.lblPredictedFare.Visible = false;
            // 
            // frmTaxiFarePredictor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPredictedFare);
            this.Controls.Add(this.btnPredictFare);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Name = "frmTaxiFarePredictor";
            this.Text = "Taxi fare predictor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblTime;
        private TextBox txtTime;
        private Button btnPredictFare;
        private Label lblPredictedFare;
    }
}