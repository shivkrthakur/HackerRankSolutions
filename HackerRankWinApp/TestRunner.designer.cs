namespace HackerRank
{
    partial class TestRunner
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
            this.txtConsoleInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Location = new System.Drawing.Point(12, 12);
            this.txtConsoleInput.MaxLength = 99999999;
            this.txtConsoleInput.Multiline = true;
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsoleInput.Size = new System.Drawing.Size(358, 450);
            this.txtConsoleInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.Location = new System.Drawing.Point(422, 12);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsoleOutput.Size = new System.Drawing.Size(352, 450);
            this.txtConsoleOutput.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClearResults_Click);
            // 
            // TestRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtConsoleOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsoleInput);
            this.Name = "TestRunner";
            this.Text = "TestRunner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsoleInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private System.Windows.Forms.Button button2;
    }
}