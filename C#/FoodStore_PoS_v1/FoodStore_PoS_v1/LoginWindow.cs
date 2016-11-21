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

namespace FoodStore_PoS_v1
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        // Class 
        Method method = new Method();
        LoginWindowPassword LoginWindowPasswordDisplay = new LoginWindowPassword();
        

        private void Login_Load(object sender, EventArgs e)
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
        
        public void ButtonPinSign_Click(object sender, EventArgs e)
        {
            string ID = TextBoxLoginWindowPin.Text;

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
        
        
        
    }
}
