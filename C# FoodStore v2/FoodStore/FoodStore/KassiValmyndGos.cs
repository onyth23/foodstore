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
    public partial class KassiValmyndGos : Form
    {
        public KassiValmyndGos()
        {
            InitializeComponent();
        }

        Method method = new Method();
        ValmyndKassaStarfsmadur ValmyndKassi = new ValmyndKassaStarfsmadur();

        int Fjoldi { get; set; }

        private void ButtonKok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 32;
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

        private void ButtonAppelsin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 33;
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

        private void ButtonMtDew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 34;
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

        private void ButtonDrPepper_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 35;
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

        private void ButtonKokzero_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 36;
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

        private void ButtonPepsi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 37;
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

        private void ButtonPepsiMax_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 38;
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

        private void ButtonMonster_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 39;
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

        private void ButtonRedBull_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxGos.Text))
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

        private void KassiValmyndGos_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fjoldi = 2;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fjoldi = 3;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fjoldi = 4;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fjoldi = 5;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fjoldi = 6;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fjoldi = 7;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fjoldi = 8;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fjoldi = 9;
            Fjoldi = fjoldi;
            TextBoxGos.Text = fjoldi.ToString();
        }
    }
}
