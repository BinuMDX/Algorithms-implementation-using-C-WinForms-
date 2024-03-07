namespace Assignment_V2
{
    partial class Question1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNo = new System.Windows.Forms.TextBox();
            this.secondNo = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your first number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your second number";
            // 
            // firstNo
            // 
            this.firstNo.Location = new System.Drawing.Point(190, 55);
            this.firstNo.Name = "firstNo";
            this.firstNo.Size = new System.Drawing.Size(100, 20);
            this.firstNo.TabIndex = 2;
            // 
            // secondNo
            // 
            this.secondNo.Location = new System.Drawing.Point(190, 91);
            this.secondNo.Name = "secondNo";
            this.secondNo.Size = new System.Drawing.Size(100, 20);
            this.secondNo.TabIndex = 3;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(50, 126);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 25);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Display as a message";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(8, 20);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(328, 19);
            this.description.TabIndex = 5;
            this.description.Text = "Enter two numbers and check their equivalance.";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(175, 126);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(102, 25);
            this.display.TabIndex = 6;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(47, 163);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Display Result";
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 192);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.description);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.secondNo);
            this.Controls.Add(this.firstNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Question1";
            this.Text = "Question1";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNo;
        private System.Windows.Forms.TextBox secondNo;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label ResultLabel;
    }
}