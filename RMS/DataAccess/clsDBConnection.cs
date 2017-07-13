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
        string strConnectionString;
        private string strServerName;
        private string strDatabaseName;
        private string strUsername;
        private string strPassword;
        private string strSecurity;
        public string m_strFileName;
        int rows=-1;
        #endregion


        #region Server Connection
        public clsDBConnection() 
        {
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

                    if (bankReader.LocalName.Equals("username"))
                    {
                        strUsername = bankReader.ReadString();
                    }

                    if (bankReader.LocalName.Equals("password"))
                    {
                        strPassword = bankReader.ReadString();
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
            strConnectionString = "Data Source=" + strServerName;
            strConnectionString += ";Initial Catalog=" + strDatabaseName;
            strConnectionString += ";Persist Security Info=" + strSecurity;
            strConnectionString += ";User ID=" + strUsername;
            strConnectionString += ";Password=" + strPassword;
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
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                dbConn.Close();
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

        #region Search Data and Return Table
        public DataTable SearchData(string strTableName, string strWhereClause)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_SEARCH_DATA");

                Connection();

                command.Connection = dbConn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tblName", strTableName);
                command.Parameters.AddWithValue("@WhereClause", strWhereClause);

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                dataadapter.Fill(datatable);
                return datatable;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            { 
                dbConn.Close();
            } 
        }
        #endregion

        #region SearchData_SP Table Name
        public DataTable SearchData(string strTableName)
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_SELECT_TABLE");
                Connection();
                command.Connection = dbConn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TableName", strTableName);

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                dataadapter.Fill(datatable);
                return datatable;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dbConn.Close();
            }

        }
        #endregion

        #region Execute
        public DataTable Execute(string SpName, System.Object[,] arrParameter)
        {
            try
            {
                SqlCommand command = new SqlCommand(SpName);
                Connection();
                command.Connection = dbConn;
                command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i <= arrParameter.GetLength(0) - 1; i++)
                {
                    command.Parameters.AddWithValue(arrParameter[i, 0].ToString(), arrParameter[i, 1]);
                }

                SqlDataAdapter dataadapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                dataadapter.Fill(datatable);
                return datatable;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dbConn.Close();
            }
        }
        #endregion

        #region DeleteData_SP
        public int DeleteData(string strTableName, string strWhereClause)
        {
            try
            {
                SqlCommand command = new SqlCommand("sp_DeleteData");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@varTableName", strTableName);
                command.Parameters.AddWithValue("@varSearchString", strWhereClause);
                Connection();
                command.Connection = dbConn;
                rows = command.ExecuteNonQuery();
                return rows;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return -1;
            }
            finally 
            {
                dbConn.Close();
            }
        }
        #endregion
    }
}
