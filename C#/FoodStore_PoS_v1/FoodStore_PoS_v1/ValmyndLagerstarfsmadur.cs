﻿using System;
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

        Method method = new Method(); // Tengja glugga við method.cs

        private void ValmyndLagerstarfsmadur_Load(object sender, EventArgs e)
        {
            method.TengingVidGagnagrunn(); // Tengir við Sql database 
            LagerLoad();
            LagerTypeIDLoad();
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagerDataGridView er notuð hér til að birta lager í ValmyndLagerstarfsmadur.cs 
        //---------------------------------------------------------------------------------------------------------------------
        public void LagerLoad()
        {
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

        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagerTypeIDDataGridView er notuð hér til að birta lagertype_id í ValmyndLagerstarfsmadur.cs 
        //---------------------------------------------------------------------------------------------------------------------
        public void LagerTypeIDLoad()
        {
            int DataGridViewNumberUp = 0;
            int IDCounter = 0;

            for (int i = 0; i < 450; i++)
            {
                string[] gognFraSql = new string[2];
                try
                {
                    gognFraSql = method.DisplayLagerTypeIDGridView(IDCounter);

                    string id = gognFraSql[0];
                    string name = gognFraSql[1];
                    if (string.IsNullOrEmpty(id))
                    {

                    }
                    else
                    {
                        dataGridViewLagertypeIDDisplay.Rows.Add();
                        dataGridViewLagertypeIDDisplay.Rows[DataGridViewNumberUp].Cells[0].Value = id;
                        dataGridViewLagertypeIDDisplay.Rows[DataGridViewNumberUp].Cells[1].Value = name;
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

        // --------------------------------------------------------------------------------------------------------------------
        // Refresh button kallar í báðar lager method, 
        // ---------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewLagerDisplay.ClearSelection();
            dataGridViewLagertypeIDDisplay.ClearSelection();
            LagerLoad();
            LagerTypeIDLoad();
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Button setja nýjar vörur í lager. 
        // Setur vörur inn með input frá textbox í ValmyndLagerstarfsmadur
        // Notar method SetjaNyjaVorurLager í method.cs
        // ---------------------------------------------------------------------------------------------------------------------
        private void ButtonSetjaNyjaVoruLager_Click(object sender, EventArgs e)
        {
            string ProductName = TextBoxLagerProductName.Text;
            int ProductPrice = Convert.ToInt32(TextBoxLagerProductPrice.Text);
            int Quantity = Convert.ToInt32(TextBoxLagerQuantity.Text);
            int LagerTypeID = Convert.ToInt32(TextBoxLagerLagerTypeID.Text);

            if (string.IsNullOrEmpty(ProductName) || Quantity == null || LagerTypeID == null)
            {
                MessageBox.Show("Eitthvað box er tómt hjá þér");
            }
            else
            {
                try
                {
                    method.SetjaNyjaVoruLager(ProductName, ProductPrice, Quantity, LagerTypeID);
                    MessageBox.Show("Vara hefur verið sett inn í lager skv upplýsingum frá þér.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); // Error msg
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------
        // SelectionChanged Method sem tekur upplýsingar úr datagridvewLagerDisplay og fyllir út textbox sem tengjast því
        // ---------------------------------------------------------------------------------------------------------------------
        private void dataGridViewLagerDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLagerDisplay.SelectedRows.Count <= 0)
            {
                return;
            }
            else
            {
                if (dataGridViewLagerDisplay.SelectedRows[0].Cells[0].Value.ToString() != null)
                {
                    TextBoxLagerIDvoru.Text = dataGridViewLagerDisplay.SelectedRows[0].Cells[0].Value.ToString();
                }
                if (dataGridViewLagerDisplay.SelectedRows[0].Cells[1].Value.ToString() != null)
                {
                    TextBoxLagerProductName.Text = dataGridViewLagerDisplay.SelectedRows[0].Cells[1].Value.ToString();
                }
                if (dataGridViewLagerDisplay.SelectedRows[0].Cells[2].Value.ToString() != null)
                {
                    TextBoxLagerProductPrice.Text = dataGridViewLagerDisplay.SelectedRows[0].Cells[2].Value.ToString();
                }
                if (dataGridViewLagerDisplay.SelectedRows[0].Cells[3].Value.ToString() != null)
                {
                    TextBoxLagerQuantity.Text = dataGridViewLagerDisplay.SelectedRows[0].Cells[3].Value.ToString();
                }
                if (dataGridViewLagerDisplay.SelectedRows[0].Cells[4].Value.ToString() != null)
                {
                    TextBoxLagerLagerTypeID.Text = dataGridViewLagerDisplay.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------
        // SelectionChanged Method sem tekur upplýsingar út DataGridViewLagerIdDisplay og fyllir út textbox sem tengjast því
        // ---------------------------------------------------------------------------------------------------------------------
        private void dataGridViewLagerIdDisplay_SelectionChange(object sender, EventArgs e)
        {
            if (dataGridViewLagertypeIDDisplay.SelectedRows.Count <= 0) 
            {
                return;
            }
            else
            {
                if (dataGridViewLagertypeIDDisplay.SelectedRows[0].Cells[0].Value.ToString() != null)
                {
                    TextBoxLagerTypeIDLagerTypeID.Text = dataGridViewLagertypeIDDisplay.SelectedRows[0].Cells[0].Value.ToString();
                }
                if (dataGridViewLagertypeIDDisplay.SelectedRows[0].Cells[1].Value.ToString() != null)
                {
                    TextBoxLagerTypeIDName.Text = dataGridViewLagertypeIDDisplay.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------
        // SelectionChanged Method sem tekur upplýsingar út DataGridViewLagerIdDisplay og fyllir út textbox sem tengjast því
        // ---------------------------------------------------------------------------------------------------------------------
        private void ButtonUppfaeraVoruLager_Click(object sender, EventArgs e)
        {

        }
    }
}
    

