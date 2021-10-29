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
        public int InsertRole(Role role)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertRole";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetRole()
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetRole";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
        public int InsertProgLanguage(ProgLanguage prog)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageDesc", prog.ProgLanguageDesc);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateProgLanguage(ProgLanguage prog)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_UpdateProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageDesc", prog.ProgLanguageDesc);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", prog.ProgLanguageID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteProgLanguage(ProgLanguage prog)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_DeleteProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID", prog.ProgLanguageID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetProgLanguageByID(int progLanguageID)
        {
            try { dbConn.Open(); }
            catch { }
            string sql = "sp_GetProgLanguageByID";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ProgLanguageID", progLanguageID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetProgLanguage()
        {
            try { dbConn.Open(); }
            catch { }
            string sql = "sp_GetProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable ReportModule(int moduleID)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_ReportModule";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", moduleID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        public int InsertYear(Year year)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertYear";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearDescription", year.YearDescription);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateYear(Year year)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_UpdateYear";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearDescription", year.YearDescription);
            dbComm.Parameters.AddWithValue("@YearID", year.YearID);

            int x = dbComm.ExecuteNonQuery();
            return x;

        }
        public DataTable GetYearByID(int yearID)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetYearByID";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearID", yearID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetYear()
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetYear";
            dbComm = new SqlCommand(sql, dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int DeleteYear(Year year)
        {

            try { dbConn.Open(); }
            catch { }

            string sql = "sp_DeleteYear";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@YearID", year.YearID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int InsertModule(Module mod)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_InsertModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleDescription", mod.ModuleDescription);
            dbComm.Parameters.AddWithValue("@YearID", mod.YearID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int UpdateModule(Module mod)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_UpdateModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", mod.ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleDescription", mod.ModuleDescription);
            dbComm.Parameters.AddWithValue("@YearID", mod.YearID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public int DeleteModule(Module mod)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_DeleteModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", mod.ModuleID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }
        public DataTable GetModuleByID(int moduleID)
        {
            try { dbConn.Open(); }
            catch { }

            string sql = "sp_GetModuleByID";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", moduleID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;

        }
    }
}
