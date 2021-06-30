
namespace Glowing
{
    partial class GlowingMainForm
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
            this.JsonTextBox = new System.Windows.Forms.RichTextBox();
            this.JsonLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.RichTextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CodeGenerationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JsonTextBox
            // 
            this.JsonTextBox.Location = new System.Drawing.Point(12, 31);
            this.JsonTextBox.Name = "JsonTextBox";
            this.JsonTextBox.Size = new System.Drawing.Size(337, 321);
            this.JsonTextBox.TabIndex = 0;
            this.JsonTextBox.Text = "";
            // 
            // JsonLabel
            // 
            this.JsonLabel.AutoSize = true;
            this.JsonLabel.CausesValidation = false;
            this.JsonLabel.Location = new System.Drawing.Point(12, 10);
            this.JsonLabel.Name = "JsonLabel";
            this.JsonLabel.Size = new System.Drawing.Size(30, 15);
            this.JsonLabel.TabIndex = 1;
            this.JsonLabel.Text = "Json";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(447, 27);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(337, 321);
            this.CodeTextBox.TabIndex = 2;
            this.CodeTextBox.Text = "";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(749, 9);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(35, 15);
            this.CodeLabel.TabIndex = 3;
            this.CodeLabel.Text = "Code";
            // 
            // CodeGenerationButton
            // 
            this.CodeGenerationButton.Location = new System.Drawing.Point(355, 39);
            this.CodeGenerationButton.Name = "CodeGenerationButton";
            this.CodeGenerationButton.Size = new System.Drawing.Size(75, 54);
            this.CodeGenerationButton.TabIndex = 5;
            this.CodeGenerationButton.Text = "Generate classes";
            this.CodeGenerationButton.UseVisualStyleBackColor = true;
            this.CodeGenerationButton.Click += new System.EventHandler(this.CodeGenerationButton_Click);
            // 
            // GlowingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CodeGenerationButton);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.JsonLabel);
            this.Controls.Add(this.JsonTextBox);
            this.Name = "GlowingMainForm";
            this.Text = "Glowing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox JsonTextBox;
        private System.Windows.Forms.Label JsonLabel;
        private System.Windows.Forms.RichTextBox CodeTextBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Button CodeGenerationButton;
    }
}

