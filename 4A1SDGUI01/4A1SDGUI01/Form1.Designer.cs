
namespace _4A1SDGUI01
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
            this.Input = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Instructions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(304, 126);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(75, 23);
            this.Input.TabIndex = 0;
            this.Input.Text = "button1";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(198, 152);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(181, 95);
            this.Output.TabIndex = 1;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(198, 126);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 2;
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(227, 110);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(35, 13);
            this.Instructions.TabIndex = 3;
            this.Instructions.Text = "label1";
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Button button1;
    }
}

