using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Amiola
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;

                display_error.Text = "Width cannot be in alphabets characters";
                display_error.ForeColor = Color.Red;
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            display_error.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;

                display_error.Text = "Depth cannot be in alphabets characters";
                display_error.ForeColor = Color.Red;
            }


           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            display_error.Text = "";
        }

        private void AddQuote_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {






        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

           

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
