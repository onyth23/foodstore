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
    public partial class KassiValmyndAvextir : Form
    {
        public KassiValmyndAvextir()
        {
            InitializeComponent();
        }

        // Classar tenging 
        Method method = new Method();
        ValmyndKassaStarfsmadur ValmyndKassi = new ValmyndKassaStarfsmadur();
        
        int Fjoldi { get; set; }
        

        private void ButtonAppelsina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 1;
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

        private void ButtonBanani_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 2;
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

        private void ButtonRaudEpli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 3;
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

        private void ButtonGraenEpli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 4;
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

        private void ButtonJardaber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 5;
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

        private void ButtonAnanas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 6;
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

        private void ButtonPerur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 7;
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

        private void ButtonMango_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiAvextir.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 8;
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

        private void KassiValmyndAvextir_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fjoldi = 2;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fjoldi = 3;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fjoldi = 4;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fjoldi = 5;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fjoldi = 6;
            Fjoldi = fjoldi;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fjoldi = 7;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fjoldi = 8;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fjoldi = 9;
            Fjoldi = fjoldi;
            TextBoxKassiAvextir.Text = fjoldi.ToString();
        }
    }
}
