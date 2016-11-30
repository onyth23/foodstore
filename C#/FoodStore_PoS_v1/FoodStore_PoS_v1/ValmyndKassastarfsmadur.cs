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
    public partial class ValmyndKassastarfsmadur : Form
    {
        public ValmyndKassastarfsmadur()
        {
            InitializeComponent();
        }
        // Classar til að tengja allt saman
        Method method = new Method();
        KassiValmyndAvextir KassaValmyndAvextir = new KassiValmyndAvextir();
        KassiValmyndGraenmeti KassaValmyndGraenmeti = new KassiValmyndGraenmeti();
        KassiValmyndMjolkvorur KassaValmyndMjolkvorur = new KassiValmyndMjolkvorur();
        KassiValmyndKjotvorur KassaValmyndKjotvorur = new KassiValmyndKjotvorur();
        KassiValmyndGos KassaValmyndGos = new KassiValmyndGos();
        KassiValmyndNammi KassaValmyndNammi = new KassiValmyndNammi();


        private void ButtonAvextir101_Click(object sender, EventArgs e)
        {
            KassaValmyndAvextir.Show();
        }

        private void ButtonGraenmeti201_Click(object sender, EventArgs e)
        {
            KassaValmyndGraenmeti.Show();
        }

        private void ButtonOvirkur103_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonMjolkvorur201_Click(object sender, EventArgs e)
        {
            KassaValmyndKjotvorur.Show();
        }

        private void ButtonOvirkur201_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur203_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonKjotvorur301_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOvirkur302_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur303_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonGos401_Click(object sender, EventArgs e)
        {
            KassaValmyndGos.Show();
        }

        private void ButtonNammi402_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOvirkur403_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }
    }
}
