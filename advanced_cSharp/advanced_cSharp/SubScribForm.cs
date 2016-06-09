using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace advanced_cSharp
{
    public partial class SubScribForm : Form
    {
        private Publisher publisher;
        private string emailAddress = String.Empty;
        private string mobileNumber = String.Empty;

        public Boolean validEmailValue { set; get; }
        public Boolean validCellPhoneValue { set; get; }

        public SubScribForm(  Publisher publisher)
        {
            InitializeComponent();
            this.publisher = publisher;
        }



        private void subBtn_Click(object sender, EventArgs e)
        {
            bool flg = false;
            if (this.emailAddress != String.Empty)
            {
                SendViaEmail sendViaEmail = new SendViaEmail(this.emailAddress);
                sendViaEmail.Subscribe(this.publisher);
                MessageBox.Show(this.emailAddress + " subscribe succesfully!");
                flg = true;
            }

            if (this.mobileNumber != String.Empty)
            {
               
                SendViaMobile sendViaMobile = new SendViaMobile(this.mobileNumber);
                sendViaMobile.Subscribe(this.publisher);
                MessageBox.Show(this.mobileNumber + " subscribe succesfully!");
                flg = true;
            }
            if (flg == true)
            {

                this.Close();
            }
              

        }



        private  void validEmail(string emailAddress)
        {
            if(Regex.IsMatch(emailAddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                

                this.validEmailValue = true;
           else
                this.validEmailValue = false;
            
        }

        private void validCellphone(string cellPhone)
        {
            Regex regexPhoneNumber = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (regexPhoneNumber.IsMatch(cellPhone))
                this.validCellPhoneValue = true;
            else
            {
                this.validCellPhoneValue = false;
                this.wrong_tel_num.Visible = true;
            }

        }

        private void emailInput_Leave(object sender, EventArgs e)
        {
            if (this.emailInput.Text != String.Empty)
            {
                validEmail(this.emailInput.Text);

                if (this.validEmailValue)
                {
                    this.emailAddress = this.emailInput.Text;
                    
                }
                else
                {
                    Console.WriteLine("wrong email format:" + this.emailInput.Text);
                    this.wrong_email.Visible = true;
                }
            }


        }

       

        private void mobileInput_Leave(object sender, EventArgs e)
        {
            if (this.mobileInput.Text != String.Empty)
            {
                validCellphone(this.mobileInput.Text);

                if (this.validCellPhoneValue)
                {
                    this.mobileNumber = this.mobileInput.Text;

                    Console.WriteLine("right cellphone format:" + this.mobileInput.Text);
                }
                else
                {
                    Console.WriteLine("wrong cellphone format:" + this.mobileInput.Text);
                    this.wrong_tel_num.Visible = true;
                }
            }


        }

        private  void email_Checked(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked==true)
                this.emailInput.ReadOnly = false;
            else
            {
                this.emailInput.ReadOnly = true;
                this.emailInput.Text = String.Empty;
            }
               

        }

        private void mobile_Checked(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
                this.mobileInput.ReadOnly = false;
            else
            {
                this.mobileInput.ReadOnly = true;
                this.mobileInput.Text = String.Empty;
            }
                
        }

        private void mobileInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            
            this.emailAddress = String.Empty;
            this.mobileNumber = String.Empty;
            this.Close();
        }

        private void unsubBtn_Click(object sender, EventArgs e)
        {
            bool flg = false;
            if (this.emailAddress != String.Empty)
            {
                SendViaEmail sendViaEmail = new SendViaEmail(this.emailAddress);
                sendViaEmail.Unsubscribe(this.publisher);
                MessageBox.Show(this.emailAddress + " unsubscribe succesfully!");
                this.emailAddress = String.Empty;
               
                flg = true;
            }

            if (this.mobileNumber != String.Empty)
            {
                SendViaMobile sendViaMobile = new SendViaMobile(this.mobileNumber);
                sendViaMobile.Unsubscribe(this.publisher);
                MessageBox.Show(this.mobileNumber + " unsubscribe succesfully!");
                this.mobileNumber = String.Empty;
                flg = true;
            }

            if (flg == true)
            {
                this.Close();
            }
        }
    }
}
