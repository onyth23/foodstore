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
    public partial class KassiValmyndGraen : Form
    {
        public KassiValmyndGraen()
        {
            InitializeComponent();
        }

        // Classar tenging 
        Method method = new Method();
        ValmyndKassaStarfsmadur ValmyndKassi = new ValmyndKassaStarfsmadur();
        
        int Fjoldi { get; set; }
        

        private void ButtongKal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 9;
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

        private void ButtongTomatar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 10;
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

        private void ButtongSpinat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 11;
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

        private void ButtongGulraetur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 12;
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

        private void ButtongKarolfur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 13;
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

        private void ButtongLaukur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 14;
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

        private void ButtongSveppir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxKassiGraen.Text))
            {
                MessageBox.Show("Þarft að velja fjölda fyrst, takk!");
            }
            else
            {
                int ID = 15;
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

        private void ButtongOvirkur1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void ButtongOvirkur2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þessi button er óvirkur!");
        }

        private void KassiValmyndGraen_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int fjoldi = 1;
            Fjoldi = fjoldi;
            TextBoxKassiGraen.Text = fjoldi.ToString();
        }
    }
}
