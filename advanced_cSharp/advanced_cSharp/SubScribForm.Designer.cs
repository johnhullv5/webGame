namespace advanced_cSharp
{
    partial class SubScribForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.mobileInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.wrong_email = new System.Windows.Forms.Label();
            this.wrong_tel_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(56, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 33);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Message Sent by Email";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.email_Checked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(56, 159);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(304, 33);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Message Sent by Mobile";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.mobile_Checked);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(352, 85);
            this.emailInput.Name = "emailInput";
            this.emailInput.ReadOnly = true;
            this.emailInput.Size = new System.Drawing.Size(216, 26);
            this.emailInput.TabIndex = 2;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            this.emailInput.Leave += new System.EventHandler(this.emailInput_Leave);
            // 
            // mobileInput
            // 
            this.mobileInput.Location = new System.Drawing.Point(352, 163);
            this.mobileInput.Name = "mobileInput";
            this.mobileInput.ReadOnly = true;
            this.mobileInput.Size = new System.Drawing.Size(216, 26);
            this.mobileInput.TabIndex = 3;
            this.mobileInput.TextChanged += new System.EventHandler(this.mobileInput_TextChanged);
            this.mobileInput.Leave += new System.EventHandler(this.mobileInput_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 83);
            this.button1.TabIndex = 4;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 83);
            this.button2.TabIndex = 5;
            this.button2.Text = "Unsubscribe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.unsubBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 83);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // wrong_email
            // 
            this.wrong_email.AutoSize = true;
            this.wrong_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrong_email.ForeColor = System.Drawing.Color.Red;
            this.wrong_email.Location = new System.Drawing.Point(576, 85);
            this.wrong_email.Name = "wrong_email";
            this.wrong_email.Size = new System.Drawing.Size(258, 25);
            this.wrong_email.TabIndex = 7;
            this.wrong_email.Text = "invalid email address format!";
            this.wrong_email.Visible = false;
            // 
            // wrong_tel_num
            // 
            this.wrong_tel_num.AutoSize = true;
            this.wrong_tel_num.BackColor = System.Drawing.SystemColors.Control;
            this.wrong_tel_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrong_tel_num.ForeColor = System.Drawing.Color.Red;
            this.wrong_tel_num.Location = new System.Drawing.Point(576, 164);
            this.wrong_tel_num.Name = "wrong_tel_num";
            this.wrong_tel_num.Size = new System.Drawing.Size(275, 25);
            this.wrong_tel_num.TabIndex = 8;
            this.wrong_tel_num.Text = "invalid tel num address format!";
            this.wrong_tel_num.Visible = false;
            // 
            // SubScribForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 422);
            this.Controls.Add(this.wrong_tel_num);
            this.Controls.Add(this.wrong_email);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mobileInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "SubScribForm";
            this.Text = "Subscribe Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox mobileInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label wrong_email;
        private System.Windows.Forms.Label wrong_tel_num;
    }
}