using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
 * Ármann Hallbert Jónsson
 * Gylfi Þór Helgason
 * Hávar Sigurðarson
 * HáG FoodStore
 * Lokaverkefni haust önn 2016
 */ 

namespace FoodStore_PoS_v1
{
    class Method
    {
        //server: segir til um hvar serverinn er hýstur, hjá okkur er það phpmyadmin hjá tsuts.tskoli.is
        private string server;
        //database: nafnið á gagnagrunninum sem verið er að nota
        private string database;
        // uid:er MySQL notendanafnið
        private string uid;
        // password: er MySQL lykilorðið
        private string password;
        //tengistrengur: contains the connection string to connect ot the database
        //and will be assigned to the connection variable
        string tengistrengur = null;
        //fyrirspurn: inniheldur viðeigandi fyrispurn hverju sinni
        string fyrirspurn = null;

        MySqlConnection sqltenging; //Þetta er notað til þess að opna tengingu við gagnagrunn
        MySqlCommand nySQLskipun; //Þetta er notað til þesss að framkvæma SQL fyrirspurnina
        MySqlDataReader sqllesari = null; //Lesari sem getur lesið úr SQL gagnagrunninum

        // --------------------------------------------------------------------------------------------------------------------
        // Method til að tengja forrit við Sql gagnagrunn
        //---------------------------------------------------------------------------------------------------------------------

        public void TengingVidGagnagrunn()
        {
            server = "82.148.66.15"; // ip talan fyrir phpMyadmin.
            database = "1310903079_foodstore";  // Tengin inná sql hjá Gylfa. 
            uid = "1310903079"; // user name að phpmyadmin. 
            password = "gylfusphppw"; // password að Sql.

            tengistrengur = "server= " + server + ";userid= " + uid + ";password= " + password + ";database= " + database;

            sqltenging = new MySqlConnection(tengistrengur);
        }

        // --------------------------------------------------------------------------------------------------------------------
        // TengingVidGagnagrunn endar hér 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method OpenConnection sem opnar tengingu við phpadmin datebase 
        //---------------------------------------------------------------------------------------------------------------------

        private bool OpenConnection() // Athugar hvort tengin sé kominn á. 
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method OpenConnection endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method CloseConnection lokar tenginu við database
        //---------------------------------------------------------------------------------------------------------------------

        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method CloseConnection endar.
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method FindID byrjar, finnur ID í foodstore datebase undir employee.
        // Notað fyrir LoginWindow.cs glugga til að skrá sig inn.
        //---------------------------------------------------------------------------------------------------------------------

        public string FindID(string ID)
        {
            string[] gogn = new string[4];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ID FROM employee where ID='" + ID + "'";

                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                }
                sqllesari.Close();
                CloseConnection();
            }
            return gogn[0];
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method FindID endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method FindPin byrjar, finnur PIN í foodstore datebase undir employee.
        // Notað fyrir LoginWindowPassword.cs glugga til passa 
        //---------------------------------------------------------------------------------------------------------------------

        public string FindPIN(string ID)
        {
            string[] gogn = new string[1];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT password FROM employee where ID='" + ID + "'";

                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                }
                sqllesari.Close();
                CloseConnection();
            }
            return gogn[0];
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method FindPIN endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method Find JobTitle byrjar, næ í jobtitle starfsmann í sql
        //---------------------------------------------------------------------------------------------------------------------

        public string FindJobTitle(string ID)
        {
            string[] gogn = new string[1];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT jobtitle FROM employee where ID='" + ID + "'";

                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                }
                sqllesari.Close();
                CloseConnection();
            }
            return gogn[0];
        }

        // --------------------------------------------------------------------------------------------------------------------
        // Method FindJobTitle endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagerDataGridView 
        // Nær í lager í database og linkar í datagridview fyrir lagerstarfsmann
        //---------------------------------------------------------------------------------------------------------------------
        public string[] DisplayLagerDataGridView(int ID)
        {
            string[] gogn = new string[5];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ID, productname, productprice, quantity, lagertype_id from lager where ID='" + ID + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                    gogn[1] = sqllesari.GetValue(1).ToString();
                    gogn[2] = sqllesari.GetValue(2).ToString();
                    gogn[3] = sqllesari.GetValue(3).ToString();
                    gogn[4] = sqllesari.GetValue(4).ToString();
                }
                sqllesari.Close();
                CloseConnection();
                return gogn;
            }
            return gogn;
        }
        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagerDataGridView endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagertypeIDGridView 
        // Nær í lagertype og linkar í datagrid fyrir lagerstarfsmann
        //---------------------------------------------------------------------------------------------------------------------
        public string[] DisplayLagerTypeIDGridView(int ID)
        {
            string[] gogn = new string[2];
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT ID, Name from lagertype where ID='" + ID + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    gogn[0] = sqllesari.GetValue(0).ToString();
                    gogn[1] = sqllesari.GetValue(1).ToString();
                }
                sqllesari.Close();
                CloseConnection();
                return gogn;
            }
            return gogn;
        }
        // --------------------------------------------------------------------------------------------------------------------
        // Method DisplayLagerTypeIDDataGridView endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method SetjaNyjarVoruLager byrjar
        // Situr nyja vöru í sql database i lager, ID er auto. 
        // Er notuð af ValmyndLagerstarfsmadur.cs 
        //---------------------------------------------------------------------------------------------------------------------
        public void SetjaNyjaVoruLager(string ProductName, int ProductPrice, int Quantity, int LagerTypeID)
        {
            if (OpenConnection() == true)
            {

                fyrirspurn = "INSERT INTO lager (productname, productprice, quantity, lagertype_id) VALUES ('" + ProductName + "','" + ProductPrice + "','" + Quantity + "','" + LagerTypeID + "')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
            else
            {
                CloseConnection();
            }
        }
        // --------------------------------------------------------------------------------------------------------------------
        // Method SetjaNjaVoruLager endar 
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method UppfaeraLagerVoru byrjar
        //---------------------------------------------------------------------------------------------------------------------
        public void UppfaeraLagerVoru(int id, string ProductName, int ProductPrice, int Quantity, int LagerTypeID)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "Update lager set productname='" + ProductName + "', productprice='" + ProductPrice + "', quantity='" + Quantity + "', lagertype_id='" + LagerTypeID + "' where ID='" + id + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        // --------------------------------------------------------------------------------------------------------------------
        // Method UppfæraLagerVoru endar
        //---------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------
        // Method BuaTilLagerTypeID byrjar
        //---------------------------------------------------------------------------------------------------------------------
        public void BuaTilLagerTypeID(int ID, string name)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO lagertype (Id, name) VALUES ('" + ID + "','" + name + "')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }


    }
}
