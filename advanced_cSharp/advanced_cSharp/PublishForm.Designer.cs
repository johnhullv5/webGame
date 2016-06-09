namespace advanced_cSharp
{
    partial class PublishForm
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
            this.news_letter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // news_letter
            // 
            this.news_letter.AutoSize = true;
            this.news_letter.Location = new System.Drawing.Point(97, 137);
            this.news_letter.MaximumSize = new System.Drawing.Size(100, 100);
            this.news_letter.Name = "news_letter";
            this.news_letter.Size = new System.Drawing.Size(90, 20);
            this.news_letter.TabIndex = 0;
            this.news_letter.Text = "NewsLetter";
            this.news_letter.Click += new System.EventHandler(this.news_letter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Leave += new System.EventHandler(this.inputChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pubBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.news_letter);
            this.Name = "PublishForm";
            this.Text = "Publish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label news_letter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}