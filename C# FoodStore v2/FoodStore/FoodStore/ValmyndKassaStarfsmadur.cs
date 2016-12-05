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
    public partial class ValmyndKassaStarfsmadur : Form
    {
        public ValmyndKassaStarfsmadur()
        {
            InitializeComponent();
        }

        // Classar tenging
        Method method = new Method();

        private void ValmyndKassaStarfsmadur_Load(object sender, EventArgs e)
        {
            
            
            
        }

        string nafn1 { get; set; }
        string verd1 { get; set; }
        int fjoldi1 { get; set; }
        int heildarverd1 { get; set; }
        public void Setja(string nafn, string verd, int fjoldi, int heildarverd)
        {
            nafn1 = nafn;
            verd1 = verd;
            fjoldi1 = fjoldi;
            heildarverd1 = heildarverd;

        }

        public void DisplayDataGrid()
        {
            Test(nafn1, verd1, fjoldi1, heildarverd1);
        }

        int DataGridViewNumberUp = 0;
        public void Test(string nafn1, string verd1, int fjoldi, int heildarverd)
        {
            method.TengingVidGagnagrunn();

            
            try
            {
                dataGridViewKassi.Rows.Add();
                dataGridViewKassi.Rows[DataGridViewNumberUp].Cells[0].Value = nafn1;
                dataGridViewKassi.Rows[DataGridViewNumberUp].Cells[1].Value = verd1;
                dataGridViewKassi.Rows[DataGridViewNumberUp].Cells[2].Value = verd1;
                dataGridViewKassi.Rows[DataGridViewNumberUp].Cells[3].Value = verd1;
                DataGridViewNumberUp++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ButtonAvextir_Click(object sender, EventArgs e)
        {
            KassiValmyndAvextir KassaValmyndAvextir = new KassiValmyndAvextir();
            KassaValmyndAvextir.Show();
        }

        private void ButtonGraenmeti_Click(object sender, EventArgs e)
        {
            KassiValmyndGraen KassaValmyndGraenmeti = new KassiValmyndGraen();
            KassaValmyndGraenmeti.Show();
        }

        private void ButtonOvirkur1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonMjolkuvorur_Click(object sender, EventArgs e)
        {
            KassiValmyndMjolkuvorur KassaValmyndMjolkuvorur = new KassiValmyndMjolkuvorur();
            KassaValmyndMjolkuvorur.Show();
        }

        private void ButtonOvirkur2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonKjotvorur_Click(object sender, EventArgs e)
        {
            KassiValmyndKjotvorur KassaValmyndKjotvorur = new KassiValmyndKjotvorur();
            KassaValmyndKjotvorur.Show();
        }

        private void ButtonOvirkur4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonGos_Click(object sender, EventArgs e)
        {
            KassiValmyndGos KassaValmyndGos = new KassiValmyndGos();
            KassaValmyndGos.Show();
        }

        private void ButtonNammi_Click(object sender, EventArgs e)
        {
            KassiValmyndNammi KassaValmyndNammi = new KassiValmyndNammi();
            KassaValmyndNammi.Show();
        }

        private void ButtonOvirkur6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }
    }
}
