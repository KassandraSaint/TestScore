
namespace TestScore
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
            this.testScoreBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aboveLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.belowLabel = new System.Windows.Forms.Label();
            this.getBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScoreBox
            // 
            this.testScoreBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testScoreBox.FormattingEnabled = true;
            this.testScoreBox.ItemHeight = 36;
            this.testScoreBox.Location = new System.Drawing.Point(49, 64);
            this.testScoreBox.Name = "testScoreBox";
            this.testScoreBox.Size = new System.Drawing.Size(384, 436);
            this.testScoreBox.TabIndex = 0;
            this.testScoreBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average score:";
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(973, 64);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(280, 45);
            this.averageLabel.TabIndex = 2;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Scores Above Average:";
            // 
            // aboveLabel
            // 
            this.aboveLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.aboveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboveLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboveLabel.Location = new System.Drawing.Point(973, 165);
            this.aboveLabel.Name = "aboveLabel";
            this.aboveLabel.Size = new System.Drawing.Size(280, 45);
            this.aboveLabel.TabIndex = 4;
            this.aboveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Scores Below Average:";
            // 
            // belowLabel
            // 
            this.belowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.belowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belowLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belowLabel.Location = new System.Drawing.Point(973, 267);
            this.belowLabel.Name = "belowLabel";
            this.belowLabel.Size = new System.Drawing.Size(280, 45);
            this.belowLabel.TabIndex = 6;
            this.belowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getBtn
            // 
            this.getBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBtn.Location = new System.Drawing.Point(583, 410);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(260, 90);
            this.getBtn.TabIndex = 7;
            this.getBtn.Text = "Get Scores";
            this.getBtn.UseVisualStyleBackColor = false;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(905, 410);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(260, 90);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.getBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1298, 572);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.belowLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aboveLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testScoreBox);
            this.Name = "Form1";
            this.Text = "Test Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aboveLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label belowLabel;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

