namespace Assignment_V2
{
    partial class Question9
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
            this.chemText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.physicsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.mathsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chemText
            // 
            this.chemText.Location = new System.Drawing.Point(261, 136);
            this.chemText.Name = "chemText";
            this.chemText.Size = new System.Drawing.Size(100, 20);
            this.chemText.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Chemistry";
            // 
            // physicsText
            // 
            this.physicsText.Location = new System.Drawing.Point(261, 111);
            this.physicsText.Name = "physicsText";
            this.physicsText.Size = new System.Drawing.Size(100, 20);
            this.physicsText.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Physics";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(267, 205);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(74, 13);
            this.ResultLabel.TabIndex = 51;
            this.ResultLabel.Text = "Display Result";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(138, 205);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 50;
            this.display.Text = "Display as a text";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(138, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 49;
            this.button1.Text = "Display as a message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(42, 44);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(618, 19);
            this.description.TabIndex = 48;
            this.description.Text = "Enter your subject marks to determine the eligibility for admission to a professi" +
    "onal course.";
            // 
            // mathsText
            // 
            this.mathsText.Location = new System.Drawing.Point(261, 85);
            this.mathsText.Name = "mathsText";
            this.mathsText.Size = new System.Drawing.Size(100, 20);
            this.mathsText.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Maths";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(494, 121);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 20);
            this.totalLabel.TabIndex = 56;
            this.totalLabel.Text = "Total";
            // 
            // Question9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.chemText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.physicsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.mathsText);
            this.Controls.Add(this.label1);
            this.Name = "Question9";
            this.Text = "Question9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chemText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox physicsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox mathsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLabel;
    }
}