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
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
           
        }

        static Publisher publisher = new Publisher("main form");

        SubScribForm secondForm;

        PublishForm thirdForm;

        private void subscripe_Click(object sender, EventArgs e)
        {
            if (secondForm == null || secondForm.IsDisposed)
            {
                secondForm = new SubScribForm(  publisher);
               

            }
            secondForm.Show();
            secondForm.Activate();

        }

        

        private void publish_Click(object sender, EventArgs e)
        {
            if (thirdForm == null || thirdForm.IsDisposed)
            {
                thirdForm = new PublishForm( ref publisher);
            }
            thirdForm.Show();
            thirdForm.Activate();

        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }


}
