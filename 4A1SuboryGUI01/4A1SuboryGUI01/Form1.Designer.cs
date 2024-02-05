
namespace _4A1SuboryGUI01
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
            this.Enter = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.ListBox();
            this.SaveChar = new System.Windows.Forms.Button();
            this.Answers = new System.Windows.Forms.ListBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(375, 137);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Input";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(249, 111);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 1;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(249, 137);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(120, 82);
            this.Output.TabIndex = 2;
            this.Output.SelectedIndexChanged += new System.EventHandler(this.Output_SelectedIndexChanged);
            // 
            // SaveChar
            // 
            this.SaveChar.Location = new System.Drawing.Point(375, 166);
            this.SaveChar.Name = "SaveChar";
            this.SaveChar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveChar.Size = new System.Drawing.Size(75, 23);
            this.SaveChar.TabIndex = 3;
            this.SaveChar.Text = "Save";
            this.SaveChar.UseVisualStyleBackColor = true;
            this.SaveChar.Click += new System.EventHandler(this.SaveChar_Click);
            // 
            // Answers
            // 
            this.Answers.FormattingEnabled = true;
            this.Answers.Location = new System.Drawing.Point(456, 137);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(120, 82);
            this.Answers.TabIndex = 4;
            this.Answers.SelectedIndexChanged += new System.EventHandler(this.Answers_SelectedIndexChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(375, 195);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.SaveChar);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button SaveChar;
        private System.Windows.Forms.ListBox Answers;
        private System.Windows.Forms.Button Calculate;
    }
}

