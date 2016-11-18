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
        //server: segir til um hvar serverinn er hýstur, hjá okkur er það localhost
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

        // Aðferð til tengjast gagnagrunn
        public void TengingVidGagnagrunn()
        {
            server = "82.148.66.15"; // ip talan fyrir phpMyadmin.
            database = "1310903079_foodstore";  // Tengin inná sql hjá Gylfa. 
            uid = "1310903079"; // user name að phpmyadmin. 
            password = "gylfusphppw"; // password að Sql.

            tengistrengur = "server= " + server + ";userid= " + uid + ";password= " + password + ";database= " + database;

            sqltenging = new MySqlConnection(tengistrengur);
        } // Tengi við gagnagrunn

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
        } // OpenConnection Endar 

        private bool CloseConnection() // þessi aðferð lokar tenginu. 
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
        } // CloseConnection endar 

        public string FindID(string ID) // Method sem skoðar ID í Sql FoodStore database
        {
            string[] gogn = new string[1];
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


    }
}
