using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Ármann Hallbert Jónsson
 * Gylfi Þór Helgason
 * Hávar Sigurðarson
 * HáG FoodStore
 * Lokaverkefni haust önn 2016
 */

namespace FoodStore
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        // Classar tenging 
        Method method = new Method();

        private void ButtonPin1_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "1";
        }

        private void ButtonPin2_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "2";
        }

        private void ButtonPin3_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "3";
        }

        private void ButtonPin4_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "4";
        }

        private void ButtonPin5_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "5";
        }

        private void ButtonPin6_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "6";
        }

        private void ButtonPin7_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "7";
        }

        private void ButtonPin8_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "8";
        }

        private void ButtonPin9_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "9";
        }

        private void ButtonPin0_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Text += "0";
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            string ID = TextBoxLoginWindow.Text;
            LoginWindowPassword LoginWindowPasswordDisplay = new LoginWindowPassword(ID);
            try
            {
                method.TengingVidGagnagrunn();
                string rett_ID = method.FindID(ID);

                if (ID == rett_ID)
                {
                    LoginWindowPasswordDisplay.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Þessi aðgangur er ekki skráður hjá okkur.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Getur upplýsingar um error í MsgBox
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxLoginWindow.Clear();
        }
    }
}
