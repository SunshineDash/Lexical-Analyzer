namespace Lexical_Analyzer
{
    partial class LexicalAnalyzer
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
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.errorManager = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.Location = new System.Drawing.Point(21, 81);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(308, 360);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Location = new System.Drawing.Point(335, 81);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(308, 360);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            // 
            // errorManager
            // 
            this.errorManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorManager.Location = new System.Drawing.Point(21, 447);
            this.errorManager.Name = "errorManager";
            this.errorManager.ReadOnly = true;
            this.errorManager.Size = new System.Drawing.Size(467, 117);
            this.errorManager.TabIndex = 2;
            this.errorManager.Text = "";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(494, 447);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(149, 117);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // LexicalAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 576);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.errorManager);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "LexicalAnalyzer";
            this.Load += new System.EventHandler(this.LexicalAnalyzer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox errorManager;
        private System.Windows.Forms.Button runButton;
    }
}

