namespace Assignment4
{
    partial class Main
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFork = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTextBox1 = new Assignment4.FormulasTextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(589, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 80);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Press TAB or click Submit to complete input";
            // 
            // lblFork
            // 
            this.lblFork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFork.AutoSize = true;
            this.lblFork.Location = new System.Drawing.Point(551, 123);
            this.lblFork.Name = "lblFork";
            this.lblFork.Size = new System.Drawing.Size(123, 13);
            this.lblFork.TabIndex = 5;
            this.lblFork.TabStop = true;
            this.lblFork.Text = "Like? Fork me on Github";
            this.lblFork.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFork_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "A control for .Net Winform Application to process Input with formulas like an Exc" +
    "el cell";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox1.InputFormulasColor = System.Drawing.Color.White;
            this.numberTextBox1.InvalidFormulasColor = System.Drawing.Color.Red;
            this.numberTextBox1.Location = new System.Drawing.Point(12, 37);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.NumericOnly = false;
            this.numberTextBox1.Size = new System.Drawing.Size(571, 80);
            this.numberTextBox1.TabIndex = 4;
            this.numberTextBox1.ValidFormulasColor = System.Drawing.Color.Blue;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFork);
            this.Controls.Add(this.numberTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private FormulasTextBox numberTextBox1;
        private System.Windows.Forms.LinkLabel lblFork;
        private System.Windows.Forms.Label label2;
    }
}