namespace Assignment_V2
{
    partial class Question8
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
            this.button1 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.firstNoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thirdNoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(249, 182);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 41;
            this.ResultLabel.Text = "Display Result";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(120, 182);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 40;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(120, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 39;
            this.button1.Text = "Display as a message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(24, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(668, 19);
            this.description.TabIndex = 38;
            this.description.Text = "Let\'s find largest number. Enter you preferred three numbers. I will give what is" +
    " the largest number";
            // 
            // firstNoText
            // 
            this.firstNoText.Location = new System.Drawing.Point(243, 62);
            this.firstNoText.Name = "firstNoText";
            this.firstNoText.Size = new System.Drawing.Size(100, 20);
            this.firstNoText.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Enter first number";
            // 
            // secondNoText
            // 
            this.secondNoText.Location = new System.Drawing.Point(243, 88);
            this.secondNoText.Name = "secondNoText";
            this.secondNoText.Size = new System.Drawing.Size(100, 20);
            this.secondNoText.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter second number";
            // 
            // thirdNoText
            // 
            this.thirdNoText.Location = new System.Drawing.Point(243, 113);
            this.thirdNoText.Name = "thirdNoText";
            this.thirdNoText.Size = new System.Drawing.Size(100, 20);
            this.thirdNoText.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Enter third number";
            // 
            // Question8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thirdNoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.firstNoText);
            this.Controls.Add(this.label1);
            this.Name = "Question8";
            this.Text = "Question8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox firstNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondNoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox thirdNoText;
        private System.Windows.Forms.Label label3;
    }
}