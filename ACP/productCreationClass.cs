using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ACP
{
    class productCreationClass
    {
        dbClass db = new dbClass();
        
        public int sdGroupID()
        {
            int currentMaxValue = 0;
            currentMaxValue = db.autoIncrement("SELECT count(*) FROM storageDmnsnGroup");
            return currentMaxValue;
        }
        public int itemModelID()
        {
            int currentMaxValue = 0;
            currentMaxValue = db.autoIncrement("SELECT count(*) FROM itemModelGroup");
            return currentMaxValue;
        }
        
        //get all product and tables connected/ linked connected to it and validation for create and update if desc is already exist
        public DataTable fetchRecord(string action, string desc, string desc2, string id, string id2, string desc3)
        {
            return db.getRecords("sp_Product", action, desc, desc2, id, id2, desc3);
        }

        public DataTable fetchStorageGroupUpdate(string id, string description)
        {
            return db.getRecord("SELECT * FROM vwStorageDmnsnGroup WHERE sdGroupDesc = '" + description + "' AND sdGroupID != '" + id + "'");
        }

        public DataTable fetchItemModel()
        {
            return db.getRecord("SELECT itemModelID as 'Item ID', sdGroupDesc as 'Storage Group', itemModelDesc as 'Item Desciption'  FROM vwItemModelGroup");
        }
        public DataTable fetchItemModelDesc()
        {
            return db.getRecord("SELECT itemModelID as 'Item ID', sdGroupDesc as 'Storage Group', itemModelDesc as 'Item Desciption'  FROM vwItemModelGroup");
        }

        //Insert, update, delete of product and tables connected / linked to it
        public void modifyProduct(string id, string id2, string description, string action, string desc, string desc2)
        {
            try
            {
                SqlConnection conn = db.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Product", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@Id", "");
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@sdGroupID", id);
                cmd.Parameters.AddWithValue("@sdDesc", description);
                cmd.Parameters.AddWithValue("@itemModelID", id2);
                cmd.Parameters.AddWithValue("@itemModelDesc", desc2);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        //public int itemModelID()
        //{
        //    int currentMaxValue = 0;
        //    currentMaxValue = db.autoIncrement("SELECT ISNULL(MAX(itemModelID), 0) FROM itemModelGroup");
        //    return currentMaxValue;
        //}
        //public int sdGroupID()
        //{
        //    int currentMaxValue = 0;
        //    currentMaxValue = db.autoIncrement("SELECT ISNULL(MAX(tdGroupID), 0) FROM trackingDmnsnGroup");
        //    return currentMaxValue;
        //}
        //public int sdGroupID()
        //{
        //    int currentMaxValue = 0;
        //    currentMaxValue = db.autoIncrement("SELECT ISNULL(MAX(rsrvID), 0) FROM rsrvtnHierarchy");
        //    return currentMaxValue;
        //}
    
  
    }
}


