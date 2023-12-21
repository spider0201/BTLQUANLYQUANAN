using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BTLQUANLYQUANAN
{         //coment
    internal class DataAcess
    {
        SqlConnection ObjConnection = new SqlConnection();
        public DataAcess()
        {
            string strConnection = @"Data Source=.\Sqlexpress;Initial Catalog=QLQuanAn;Integrated Security=True";
            ObjConnection = new SqlConnection(strConnection);
        }
        public void UpdateData(string i_updateCommand)
        {
            try
            {
                ObjConnection.Open();
                Console.WriteLine("Connection Succeed");
                SqlCommand cmd = new SqlCommand(i_updateCommand, ObjConnection);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(ObjConnection != null)
                {
                    ObjConnection.Close();
                }
            }
        }
        public DataTable GetDataTable(string i_selectCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                ObjConnection.Open();
                Console.WriteLine("Connection Succeeded");
                SqlDataAdapter objAdapter = new SqlDataAdapter(i_selectCommand,ObjConnection);
                objAdapter.Fill(dt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (ObjConnection != null)
                {
                    ObjConnection.Close();
                }
            }
            return dt;
        }
    }
}
