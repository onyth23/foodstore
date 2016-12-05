using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodStore
{
    public partial class KassiValmyndKjotvorur : Form
    {
        public KassiValmyndKjotvorur()
        {
            InitializeComponent();
        }
        Method method = new Method();
        ValmyndKassaStarfsmadur ValmyndKassi = new ValmyndKassaStarfsmadur();

        int Fjoldi { get; set; }

        private void ButtonNautakjöt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 26;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonNautahakk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 27;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonLambakjot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 28;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonHeilKjuklingur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 29;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonKjuklingavaengir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 30;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonKjuklingalaeri_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKjotvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 31;
                string[] gognFraSQL = new string[2];
                int VerdIntSql = method.KassiFinnaVerdSemInt(ID);
                int HeildarVerd = Fjoldi * VerdIntSql;
                gognFraSQL = method.KassiFinnaVoru(ID);
                string name = gognFraSQL[0];
                string verd = gognFraSQL[1];
                this.Close();
                ValmyndKassi.Setja(name, verd, Fjoldi, HeildarVerd);
                ValmyndKassi.DisplayDataGrid();
            }
        }

        private void ButtonOvirkur1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtonOvirkur3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void KassiValmyndKjotvorur_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fjoldi = 2;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fjoldi = 3;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fjoldi = 4;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fjoldi = 5;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fjoldi = 6;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fjoldi = 7;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fjoldi = 8;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fjoldi = 9;
            Fjoldi = fjoldi;
            TextBoxKjotvorur.Text = fjoldi.ToString();
        }
    }
}
