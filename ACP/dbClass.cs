using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;

namespace ACP
{
    public class dbClass
    {
        private string ConnectionString = Properties.Settings.Default.connectionDB;
        DataTable dt;
        public SqlConnection getConnection()
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);
            return conn;
        }

        public DataTable getRecord(string query) {
            //fetch all record
            //try{
                SqlConnection conn = getConnection();
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            return dt;
        }


        //fetch all product and tables connected/ linked to it
        public DataTable getRecords(string query, string action, string desc, string desc2, string id, string id2, string desc3)
        {
            //fetch all record
            //try{
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", action);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@sdGroupID", id);
            cmd.Parameters.AddWithValue("@sdDesc", desc2);
            cmd.Parameters.AddWithValue("@itemModelID", id2);
            cmd.Parameters.AddWithValue("@itemModelDesc", desc3);

            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adt.Fill(dt);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            return dt;
        }
        public void selectRecord(string query) {
            try
                {
                    SqlConnection conn = getConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int autoIncrement(string query)
        {
            int currentMaxValue = 0;
            try
            {
                SqlConnection conn = getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                currentMaxValue = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return currentMaxValue + 1;
        }
    }
}
