using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace advanced_cSharp
{
    public partial class PublishForm : Form
    {
        private Publisher publisher;
        private string msg;
        public PublishForm( ref Publisher publisher)
        {
            InitializeComponent();
            this.publisher = publisher;
        }

        

        private void pubBtn_Click(object sender, EventArgs e)
        {
           
            if (this.msg != String.Empty)
            {
                
                this.publisher.PublishMessage(this.msg);
            }

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputChanged(object sender, EventArgs e)
        {
            this.msg = this.textBox1.Text;
            
        }

        private void news_letter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
