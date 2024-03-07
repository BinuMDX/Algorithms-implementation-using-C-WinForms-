namespace Assignment_V2
{
    partial class Question20
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
            this.thirdNoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secondNoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.firstNoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thirdNoText
            // 
            this.thirdNoText.Location = new System.Drawing.Point(231, 113);
            this.thirdNoText.Name = "thirdNoText";
            this.thirdNoText.Size = new System.Drawing.Size(100, 20);
            this.thirdNoText.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Enter your choice";
            // 
            // secondNoText
            // 
            this.secondNoText.Location = new System.Drawing.Point(231, 88);
            this.secondNoText.Name = "secondNoText";
            this.secondNoText.Size = new System.Drawing.Size(100, 20);
            this.secondNoText.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Enter second number";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(237, 161);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 51;
            this.ResultLabel.Text = "Display Result";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(108, 161);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 50;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 21);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(371, 19);
            this.description.TabIndex = 48;
            this.description.Text = "Menu-driven program to perform simple calculations.";
            // 
            // firstNoText
            // 
            this.firstNoText.Location = new System.Drawing.Point(231, 62);
            this.firstNoText.Name = "firstNoText";
            this.firstNoText.Size = new System.Drawing.Size(100, 20);
            this.firstNoText.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter first number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 91);
            this.label4.TabIndex = 56;
            this.label4.Text = "Here are the options :\r\n\r\n1-Addition.\r\n2-Substraction.\r\n3-Multiplication.\r\n4-Divi" +
    "sion.\r\n5-Exit.";
            // 
            // Question20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thirdNoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.description);
            this.Controls.Add(this.firstNoText);
            this.Controls.Add(this.label1);
            this.Name = "Question20";
            this.Text = "Question20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox thirdNoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secondNoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox firstNoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}