using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    class DataAccess
    {
        string connectionString = "Data Source=DESKTOP-MFDDN1I\\SQLEXPRESS;Initial Catalog=AirforceDB;Integrated Security=True"; //DESKTOP-MFDDN1I\SQLEXPRESS

        SqlConnection connectionObject = null;
        SqlCommand sqlCommandObject = null;
        SqlDataReader sqlReader = null;

        public List<Jets> ReadJets()
        {
            List<Jets> jetList = new List<Jets>();
            try
            {
                connectionObject = new SqlConnection(connectionString);
                connectionObject.Open();

                string sqlSelectCommand = "SELECT * FROM Jet";
                sqlCommandObject = new SqlCommand(sqlSelectCommand, connectionObject);

                sqlReader = sqlCommandObject.ExecuteReader();

                while (sqlReader.Read())
                {
                    jetList.Add(new Jets(int.Parse(sqlReader["JetID"].ToString()), sqlReader["JetName"].ToString(), int.Parse(sqlReader["JetSpeed"].ToString()), int.Parse(sqlReader["JetAlt"].ToString()), int.Parse(sqlReader["JetCam"].ToString()), int.Parse(sqlReader["JetGun"].ToString()), int.Parse(sqlReader["JetAmmo"].ToString()), int.Parse(sqlReader["JetBomb"].ToString()), int.Parse(sqlReader["JetDamage"].ToString()), int.Parse(sqlReader["JetFuel"].ToString())));
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("List<Jets> ReadJets() "+ e.Message);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                if (connectionObject != null)
                {
                    connectionObject.Close();
                }
            }

            return jetList;
        }

        public List<EnemyCamp> ReadCamp()
        {
            List<EnemyCamp> campList = new List<EnemyCamp>();
            try
            {
                connectionObject = new SqlConnection(connectionString);
                connectionObject.Open();

                string sqlSelectCommand = "SELECT * FROM EnemyCamp";
                sqlCommandObject = new SqlCommand(sqlSelectCommand, connectionObject);

                sqlReader = sqlCommandObject.ExecuteReader();

                while (sqlReader.Read())
                {
                    campList.Add(new EnemyCamp(int.Parse(sqlReader["BuildingID"].ToString()), sqlReader["BuildingType"].ToString(), int.Parse(sqlReader["BuildingCap"].ToString()),int.Parse(sqlReader["BuildingDamage"].ToString())));
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("List<EnemyCamp> ReadCamp() " + e.Message);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                if (connectionObject != null)
                {
                    connectionObject.Close();
                }
            }

            return campList;
        }

        public List<Obstacle> ReadObstacle()
        {
            List<Obstacle> obstacleList = new List<Obstacle>();
            try
            {
                connectionObject = new SqlConnection(connectionString);
                connectionObject.Open();

                string sqlSelectCommand = "SELECT * FROM Obstacle";
                sqlCommandObject = new SqlCommand(sqlSelectCommand, connectionObject);

                sqlReader = sqlCommandObject.ExecuteReader();

                while (sqlReader.Read())
                {
                    obstacleList.Add(new Obstacle(int.Parse(sqlReader["ObstacleID"].ToString()),sqlReader["ObstacleName"].ToString(), sqlReader["ObstacleAmmo"].ToString(), int.Parse(sqlReader["ObstacleAlt"].ToString())));
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("List<Obstacle> ReadObstacle() " + e.Message);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }

                if (connectionObject != null)
                {
                    connectionObject.Close();
                }
            }

            return obstacleList;
        }

 
    }
}
