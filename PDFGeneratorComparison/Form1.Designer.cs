namespace PDFGeneratorComparison
{
    partial class MainForm
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
            this.btnGeneratePDFSharp = new System.Windows.Forms.Button();
            this.btnGeneratePDFSharpCore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePDFSharp
            // 
            this.btnGeneratePDFSharp.AutoSize = true;
            this.btnGeneratePDFSharp.Location = new System.Drawing.Point(119, 129);
            this.btnGeneratePDFSharp.Name = "btnGeneratePDFSharp";
            this.btnGeneratePDFSharp.Size = new System.Drawing.Size(421, 42);
            this.btnGeneratePDFSharp.TabIndex = 0;
            this.btnGeneratePDFSharp.Text = "Generate PDF using PDFSharp";
            this.btnGeneratePDFSharp.UseVisualStyleBackColor = true;
            this.btnGeneratePDFSharp.Click += new System.EventHandler(this.btnGeneratePDFSharp_Click);
            // 
            // btnGeneratePDFSharpCore
            // 
            this.btnGeneratePDFSharpCore.AutoSize = true;
            this.btnGeneratePDFSharpCore.Location = new System.Drawing.Point(119, 227);
            this.btnGeneratePDFSharpCore.Name = "btnGeneratePDFSharpCore";
            this.btnGeneratePDFSharpCore.Size = new System.Drawing.Size(482, 42);
            this.btnGeneratePDFSharpCore.TabIndex = 1;
            this.btnGeneratePDFSharpCore.Text = "Generate PDF using PDFSharpCore";
            this.btnGeneratePDFSharpCore.UseVisualStyleBackColor = true;
            this.btnGeneratePDFSharpCore.Click += new System.EventHandler(this.btnGeneratePDFSharpCore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 680);
            this.Controls.Add(this.btnGeneratePDFSharpCore);
            this.Controls.Add(this.btnGeneratePDFSharp);
            this.Name = "MainForm";
            this.Text = "Generate a PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePDFSharp;
        private System.Windows.Forms.Button btnGeneratePDFSharpCore;
    }
}

