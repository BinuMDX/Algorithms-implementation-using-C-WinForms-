namespace Assignment_V2
{
    partial class Question3
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
            this.firstNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNo
            // 
            this.firstNo.Location = new System.Drawing.Point(185, 65);
            this.firstNo.Name = "firstNo";
            this.firstNo.Size = new System.Drawing.Size(100, 20);
            this.firstNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a number";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(0, 24);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(405, 19);
            this.description.TabIndex = 9;
            this.description.Text = "Enter a number and check whether is it positive or negative";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(53, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Display as a message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(53, 141);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 11;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(182, 141);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "Display Result";
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 211);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.firstNo);
            this.Controls.Add(this.label1);
            this.Name = "Question3";
            this.Text = "Question3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label ResultLabel;
    }
}