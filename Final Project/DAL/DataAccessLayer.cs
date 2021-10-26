using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = localhost; Initial Catalog = ErrorDB; Integrated Security = true;";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;
        
        public int InsertTopic(Topic topic)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicDescription", topic.TopicDescription);
           
            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateTopic(Topic topic)
        {

            try { dbConn.Open(); }
            catch { }

            string sql = "sp_UpdateTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicDescription", topic.TopicDescription);
            
            dbComm.Parameters.AddWithValue("@TopicID", topic.TopicID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetTopic()
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetTopic";
            dbComm = new SqlCommand(sql, dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
        public DataTable GetTopicByID(int topicID)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetTopicByID";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TopicID", topicID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        public int DeleteTopic (Topic topic)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_DeleteTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TopicID", topic.TopicID);

            int x = dbComm.ExecuteNonQuery();            
            
            return x;
        }
        public int InsertModuleTopic (ModuleTopic modTop)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertModuleTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", modTop.ModuleID);
            dbComm.Parameters.AddWithValue("@TopicID", modTop.TopicID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateModuleTopic (ModuleTopic modTop)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_UpdateModuleTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleTopicID", modTop.ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ModuleID", modTop.ModuleID);
            dbComm.Parameters.AddWithValue("@TopicID", modTop.TopicID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetModuleTopic()
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetModuleTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;

        }
        public DataTable GetModuleTopicByID(int modTopicID)
        {
            try { dbConn.Open(); }
            catch {}
            string sql = "sp_GetModuleTopicByID";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTopicID", modTopicID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        public int DeleteModuleTopic(ModuleTopic modTop)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_DeleteModuleTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTopicID", modTop.ModuleTopicID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetModule()
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
         //methods for FrmError
        public int AddError(error Error)
        {
            try
            {
                dbConn.Open();

            }
            catch
            { 
            }
            dbCmd = new SqlCommand("sp_tblError_Add", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@ErrorID", Error.ErrorID);
            dbCmd.Parameters.AddWithValue("@ErrorDesc",Error.ErrorDesc);
            dbCmd.Parameters.AddWithValue("@StudentID", Error.StudentID);
            dbCmd.Parameters.AddWithValue("@ProgLanguageID", Error.ProgLanguageID);
            dbCmd.Parameters.AddWithValue("@ModuleTopicID", Error.ModuleTopicID);
            dbCmd.Parameters.AddWithValue("@ErrorStatus", Error.ErrorStatus);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetError()
        { 
            try
            {
                dbConn.Open();

            }
            catch
            {
                
            }
            dbCmd = new SqlCommand("sp_tblError_SelectAll", dbConn);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }
        // methods for FrmSolution
        public int AddSolutions(solution Solution)
        {
            try
            {
                dbConn.Open();

            }
            catch
            {
            }
            dbCmd = new SqlCommand("sp_tblSolution_Add", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@SolutionID", Solution.SolutionID);
            dbCmd.Parameters.AddWithValue("@SolutionDescription", Solution.SolutionDescription);
            dbCmd.Parameters.AddWithValue("@LectureID", Solution.LecturerID);

            int x = dbCmd.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetSolution()
        {
            try
            {
                dbConn.Open();

            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_tblSolution_SelectAll", dbConn);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }






    }


    public class solution
    {
        public int SolutionID { get; set; }
        public string SolutionDescription { get; set; }
        public int LecturerID { get; set; }
    }
    public class error
    { 
        public int ErrorID { get; set; }
        public string ErrorDesc { get; set; }
        public int StudentID { get; set ; }
        public string ProgLanguageID { get; set; }
        public string ModuleTopicID { get; set; }
        public string ErrorStatus { get; set; }
    }
    }
}
