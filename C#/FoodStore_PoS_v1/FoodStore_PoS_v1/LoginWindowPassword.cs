using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStore_PoS_v1
{
    public partial class LoginWindowPassword : Form
    {
        public LoginWindowPassword()
        {
            InitializeComponent();
        }

        ValmyndKassastarfsmadur ValmyndKassastarfsmadurDisplay = new ValmyndKassastarfsmadur();
        ValmyndLagerstarfsmadur ValmyndLagerstarfsmadurDisplay = new ValmyndLagerstarfsmadur();
        ValmyndVerslunarstjori ValmyndverslunarstjoriDisplay = new ValmyndVerslunarstjori();

        private void LoginWindowPassword_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPin1_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "1"; 
        }

        private void ButtonPin2_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "2"; 
        }

        private void ButtonPin3_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "3"; 
        }

        private void ButtonPin4_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "4"; 
        }

        private void ButtonPin5_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "5"; 
        }

        private void ButtonPin6_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "6"; 
        }

        private void ButtonPin7_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "7"; 
        }

        private void ButtonPin8_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "8"; 
        }

        private void ButtonPin9_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "9"; 
        }

        private void ButtonPin0_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Text += "0"; 
        }

        private void ButtonPinClear_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindowPin.Clear();
        }

        private void ButtonPinSign_Click(object sender, EventArgs e)
        {

        }
    }
}
