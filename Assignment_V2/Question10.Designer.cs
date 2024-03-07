namespace Assignment_V2
{
    partial class Question10
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
            this.admissionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chemText
            // 
            this.chemText.Location = new System.Drawing.Point(175, 160);
            this.chemText.Name = "chemText";
            this.chemText.Size = new System.Drawing.Size(100, 20);
            this.chemText.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Chemistry";
            // 
            // physicsText
            // 
            this.physicsText.Location = new System.Drawing.Point(175, 135);
            this.physicsText.Name = "physicsText";
            this.physicsText.Size = new System.Drawing.Size(100, 20);
            this.physicsText.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Physics";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(356, 59);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(92, 16);
            this.ResultLabel.TabIndex = 61;
            this.ResultLabel.Text = "Display Result";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(52, 229);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(119, 25);
            this.display.TabIndex = 60;
            this.display.Text = "Calculate";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(52, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 59;
            this.button1.Text = "Display as a message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(21, 28);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(693, 19);
            this.description.TabIndex = 58;
            this.description.Text = "Read admission no, name and marks of three subjects and calculate the total, perc" +
    "entage and division.";
            // 
            // mathsText
            // 
            this.mathsText.Location = new System.Drawing.Point(175, 109);
            this.mathsText.Name = "mathsText";
            this.mathsText.Size = new System.Drawing.Size(100, 20);
            this.mathsText.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Maths";
            // 
            // admissionText
            // 
            this.admissionText.Location = new System.Drawing.Point(175, 59);
            this.admissionText.Name = "admissionText";
            this.admissionText.Size = new System.Drawing.Size(100, 20);
            this.admissionText.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Admission No";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(175, 85);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Student Name";
            // 
            // Question10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.admissionText);
            this.Controls.Add(this.label4);
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
            this.Name = "Question10";
            this.Text = "Question10";
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
        private System.Windows.Forms.TextBox admissionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label5;
    }
}