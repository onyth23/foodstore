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
    }
}
