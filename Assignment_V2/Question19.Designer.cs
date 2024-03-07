namespace Assignment_V2
{
    partial class Question19
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.monthText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(230, 105);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 24;
            this.ResultLabel.Text = "Display Result";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(101, 105);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 23;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(24, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(655, 19);
            this.description.TabIndex = 21;
            this.description.Text = " Read any Month Number in integer and display the Month name & number of days for" +
    " this month.";
            // 
            // monthText
            // 
            this.monthText.Location = new System.Drawing.Point(209, 62);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(100, 20);
            this.monthText.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter month number";
            // 
            // Question19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.description);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.label1);
            this.Name = "Question19";
            this.Text = "Question19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox monthText;
        private System.Windows.Forms.Label label1;
    }
}