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
    public partial class KassiValmyndMjolkuvorur : Form
    {
        public KassiValmyndMjolkuvorur()
        {
            InitializeComponent();
        }

        // Classar tenging 
        Method method = new Method();
        ValmyndKassaStarfsmadur ValmyndKassi = new ValmyndKassaStarfsmadur();

        int Fjoldi { get; set; }

        private void ButtonNymjolk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 16;
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

        private void ButtonLettmjolk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 17;
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

        private void ButtonFjormjolk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 18;
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

        private void ButtonUndarenna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 19;
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

        private void ButtonOstur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 20;
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

        private void ButtonSkyr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 21;
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

        private void ButtonSmjor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 22;
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

        private void ButtonJogurt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 23;
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

        private void ButtonRjomi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiMjolkuvorur.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 24;
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

        private void KassiValmyndMjolkuvorur_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int fjoldi = 2;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int fjoldi = 3;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int fjoldi = 4;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int fjoldi = 5;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int fjoldi = 6;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int fjoldi = 7;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int fjoldi = 8;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int fjoldi = 9;
            Fjoldi = fjoldi;
            TextBoxKassiMjolkuvorur.Text = fjoldi.ToString();
        }
    }
}
