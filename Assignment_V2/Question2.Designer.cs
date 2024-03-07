namespace Assignment_V2
{
    partial class Question2
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
            this.checkButton = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNo
            // 
            this.firstNo.Location = new System.Drawing.Point(176, 64);
            this.firstNo.Name = "firstNo";
            this.firstNo.Size = new System.Drawing.Size(100, 20);
            this.firstNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a number";
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(44, 102);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 25);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Display as a message";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 20);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(353, 19);
            this.description.TabIndex = 6;
            this.description.Text = "Enter a number and check whether is it even or odd";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(44, 133);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 7;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click_1);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(188, 133);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Display Result";
            // 
            // Question2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 204);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.description);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.firstNo);
            this.Controls.Add(this.label1);
            this.Name = "Question2";
            this.Text = "Question2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label ResultLabel;
    }
}