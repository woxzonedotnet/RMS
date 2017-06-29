using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess
{ 
    public class clsDBConnection
    {
        #region Objects
        SqlConnection dbConn = new SqlConnection();
        #endregion

        #region Variables
        private string strServerName;
        private string strDatabaseName;
        private string strSecurity;
        public string m_strFileName;
        int rows=-1;
        string db_loc;
        #endregion


        #region Server Connection
        public clsDBConnection() 
        {
            //Data Source=.;Initial Catalog=time_attendence;Integrated Security=True

            db_loc = @"Data Source=THARINDU\SQLEXPRESS;Initial Catalog=RMS;Integrated Security=True";

            //m_strFileName = @"C:\Users\kanchana\Desktop\Time Attendance 3Tire\Time_Attendance\Time_Attendance\serverConfig.xml";

            m_strFileName = System.AppDomain.CurrentDomain.BaseDirectory + "serverConfig.xml";
            XmlTextReader bankReader = null;

            bankReader = new XmlTextReader(m_strFileName);

            while (bankReader.Read())
            {
                if (bankReader.NodeType == XmlNodeType.Element)
                {
                    if (bankReader.LocalName.Equals("ServerName"))
                    {
                        strServerName = bankReader.ReadString();
                    }

                    if (bankReader.LocalName.Equals("DatabaseName"))
                    {
                        strDatabaseName = bankReader.ReadString();
                    }

                    if (bankReader.LocalName.Equals("security"))
                    {
                        strSecurity = bankReader.ReadString();
                    }
                }
            }
        }
        #endregion

        #region Connection State
        private void Connection()
        {
            string strConnectionString;
            strConnectionString = "Data Source=" + strServerName;
            strConnectionString += ";Initial Catalog=" + strDatabaseName;
            strConnectionString += ";Integrated Security=" + strSecurity;
            strConnectionString += ";";

            try
            {
                dbConn.ConnectionString = strConnectionString;

                if (dbConn.State == ConnectionState.Open)
                {
                    dbConn.Close();
                }

                dbConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        #endregion

        #region Insert_SP
        public int Insert(string SpName, System.Object[,] arrParameter)
        {
            try
            {
                SqlCommand command = new SqlCommand(SpName);
                command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i <= arrParameter.GetLength(0) - 1; i++)
                {
                    command.Parameters.AddWithValue(arrParameter[i, 0].ToString(), arrParameter[i, 1]);
                }

                Connection();
                command.CommandTimeout = 1000;
                command.Connection = dbConn;
                rows = command.ExecuteNonQuery();
                
                return rows;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return rows;
            }
            finally 
            {
                dbConn.Close();
            }
        }
        #endregion



    }
}
