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
    public partial class ValmyndLagerstarfsmadur : Form
    {
        public ValmyndLagerstarfsmadur()
        {
            InitializeComponent();
        }

        Method method = new Method();

        private void ValmyndLagerstarfsmadur_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn(); // Tengir við Sql database 
            LagerLoad();
            
        }

        public void LagerLoad()
        {
            // --------------------------------------------------------------------------------------------------------------------
            // Method DisplayLagerDataGridView er notuð hér til að birta lager í ValmyndLagerstarfsmadur.cs 
            //---------------------------------------------------------------------------------------------------------------------
            int DataGridViewNumberUp = 0;
            int IDCounter = 0;
            for (int i = 0; i < 75; i++)
            {
                string[] gognFraSql = new string[5];
                try
                {
                    gognFraSql = method.DisplayLagerDataGridView(IDCounter);

                    string id = gognFraSql[0];
                    string name = gognFraSql[1];
                    string price = gognFraSql[2];
                    string quantity = gognFraSql[3];
                    string lagertype = gognFraSql[4];
                    if (string.IsNullOrEmpty(id))
                    {

                    }
                    else
                    {
                        dataGridViewLagerDisplay.Rows.Add();
                        dataGridViewLagerDisplay.Rows[DataGridViewNumberUp].Cells[0].Value = id;
                        dataGridViewLagerDisplay.Rows[DataGridViewNumberUp].Cells[1].Value = name;
                        dataGridViewLagerDisplay.Rows[DataGridViewNumberUp].Cells[2].Value = price;
                        dataGridViewLagerDisplay.Rows[DataGridViewNumberUp].Cells[3].Value = quantity;
                        dataGridViewLagerDisplay.Rows[DataGridViewNumberUp].Cells[4].Value = lagertype;
                        DataGridViewNumberUp++;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                IDCounter++;
            }
        }
    }
}
