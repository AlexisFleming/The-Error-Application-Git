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

//////////////////////////////////////////////////////////////////////////////////////
///                                 START OF GetLogin                              ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetLogin(string UserName, string Password)
        {
        /*
<<<<<<< HEAD
        Runs the CheckLogin Procedure which compares the given username and password
        to the respective fields in the database and if both values match it fills
        a datatable with the information on the logged in user.
=======
            Runs the CheckLogin Procedure which compares the given username and password
            to the respective fields in the database and if both values match it fills
            a datatable with the information on the logged in user.
>>>>>>> 9424b37831c5d8fbcc4fde51946af10e80bee1b4

            NOTE: Case sensitivity is already handled within the procedure.
            */
            dbComm = new SqlCommand("sp_CheckLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Username", UserName);
            dbComm.Parameters.AddWithValue("@Password", Password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);          

            return dt;

        }
//////////////////////////////////////////////////////////////////////////////////////
///                                 END OF GetLogin                              /////
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                                 START OF GetUserInfo                           ///
//////////////////////////////////////////////////////////////////////////////////////

        public DataTable GetUserInfo()
        {
            /*
             Runs the GetUserInfo Procedure which fills a data table with all data
             from tblUsers
             */

            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetUserInfo", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

//////////////////////////////////////////////////////////////////////////////////////
///                                 END OF GetUserInfo                            ////
//////////////////////////////////////////////////////////////////////////////////////



//////////////////////////////////////////////////////////////////////////////////////
///                              START OF InsertUser                               ///
//////////////////////////////////////////////////////////////////////////////////////
        public int InsertUser(UserData userData)
        {/*
          Runs InsertUser Procedure which Inserts a record into tblUser
<<<<<<< HEAD
          */


            try
            {
                dbConn.Open();
            }
            catch
            { }

            dbComm = new SqlCommand("sp_InsertUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserName", userData.Username);
            dbComm.Parameters.AddWithValue("@Surname", userData.Surname);
            dbComm.Parameters.AddWithValue("@Email", userData.Email);
            dbComm.Parameters.AddWithValue("@Password", userData.Password);
            dbComm.Parameters.AddWithValue("@RoleID", userData.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
//////////////////////////////////////////////////////////////////////////////////////
///                              END OF InsertUser                                 ///
//////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////////////
///                                 START OF GetRoleByID                           ///
//////////////////////////////////////////////////////////////////////////////////////

        public int GetRoleByID(string RoleDescription)
        {
         // Runs the GetRoleByID Procedure which returns the RoleID for the
          //RoleDescription given and returns the RoleID in a string.


            try
            {
                dbConn.Open();
            }
            catch
            { }

            dbComm = new SqlCommand("sp_GetRoleByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleDescription", RoleDescription);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            int x = int.Parse(dt.Rows[0]["RoleID"].ToString());

            return x;


        }

//////////////////////////////////////////////////////////////////////////////////////
///                                 END OF GetRoleByID                             ///
//////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////////////
///                               START OF GetUserByID                             ///
////////////////////////////////////////////////////////////////////////////////////// 
        public DataTable GetUserByID(int UserID)
        {
            /*
          Runs GetUserByID procedure which fills a datatable with the information
          from a specific record based on what user ID was given.
          */


            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            dbComm = new SqlCommand("GetUserByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);


            dbComm = new SqlCommand("sp_GetUserByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", UserID);
            //Yes EXample

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

//////////////////////////////////////////////////////////////////////////////////////
///                               END OF GetUserByID                               ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF UpdateUser                              ///
//////////////////////////////////////////////////////////////////////////////////////
        public int UpdateUser(UserData userdata)
        {/*
          Runs the UpdateUser Procedure which updates a chosen record in tblUser
<<<<<<< HEAD
          */


            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateUser", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userdata.UserID);
            dbComm.Parameters.AddWithValue("@Username", userdata.Username);
            dbComm.Parameters.AddWithValue("@Surname", userdata.Surname);
            dbComm.Parameters.AddWithValue("@Email", userdata.Email);
            dbComm.Parameters.AddWithValue("@Password", userdata.Password);
            dbComm.Parameters.AddWithValue("@RoleID", userdata.RoleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
//////////////////////////////////////////////////////////////////////////////////////
///                               END OF UpdateUser                                ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF DeleteUser                              ///
//////////////////////////////////////////////////////////////////////////////////////
         public int DeleteUser(UserData userData)
        {/*
          Runs the DeleteUser Procedure which deletes a record from tblUser.
<<<<<<< HEAD
          */

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteUser", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userData.UserID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

         }

//////////////////////////////////////////////////////////////////////////////////////
///                               END OF DeleteUser                                ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF AdminFilterReport                       ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable AdminFilterReport()
        {
            //This procedure fills a data table with information from tblUser but

            //only for users with the admin role

            //Only for users with the admin role

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_AdminReport", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
//////////////////////////////////////////////////////////////////////////////////////
///                               END OF AdminFilterReport                         ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF LecturerFilterReport                    ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable LecturerFilterReport()
        {
            //This procedure fills a data table with information from tblUser but

            //only for users with the Lecturer role

            //Only for users with the Lecturer role

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_LecturerReport", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
//////////////////////////////////////////////////////////////////////////////////////
///                               END OF LecturerFilterReport                      ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF StudentFilterReport                     ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable StudentFilterReport()
        {
            //This procedure fills a data table with information from tblUser but

            //only for users with the Student role

            //Only for users with the Student role

            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_StudentsReport", dbConn);



            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
//////////////////////////////////////////////////////////////////////////////////////
///                               END OF StudentFilterReport                       ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF LecturerInformationReport               ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable LecturerInformationReport(UserData userData)
        {
            //This procedure returns information of a Lecturer when given a userID that

            //is linked to the Lecturer role the information is UserID, Username,

            //-is linked to the Lecturer role the information is UserID, Username,

            //Surname and number of Solutions submitted
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_LecturerInformationReport", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userData.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;


        }
//////////////////////////////////////////////////////////////////////////////////////
///                               END OF LecturerInformationReport                 ///
//////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////
///                               START OF StudentInformationReport                ///
//////////////////////////////////////////////////////////////////////////////////////
        public DataTable StudentInformationReport(UserData userData)
        {
            //This procedure returns information of a student when given a userID that

            //is linked to the student role the information is UserID, Username,

            //-is linked to the student role the information is UserID, Username,

            //Surname, ProgLanguageDesc, TopicDescription, ModuleDescription and
            //YearDescription
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_StudentInformationReport", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userData.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;


        }


        //////////////////////////////////////////////////////////////////////////////////////
        ///                               EMD OF StudentInformationReport                  ///
        //////////////////////////////////////////////////////////////////////////////////////
        ///


        //////////////////////////////////////////////////////////////////////////////////////
        ///                               START OF GetRoleID                               ///
        //////////////////////////////////////////////////////////////////////////////////////

        public DataTable GetRoleID()
        {
            //Gets a roleID based on what Role Description is given
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetRoleID", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);

            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;




        }
        //////////////////////////////////////////////////////////////////////////////////////
        ///                               END OF GetRoleID                                 ///
        //////////////////////////////////////////////////////////////////////////////////////

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
            dbComm = new SqlCommand("sp_AddError", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
           
            dbComm.Parameters.AddWithValue("@ErrorDescription", Error.ErrorDescription);
            dbComm.Parameters.AddWithValue("@StudentID", Error.StudentID);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", Error.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ModuleTopicID", Error.ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", Error.ErrorStatus);

            int x = dbComm.ExecuteNonQuery();
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
            dbComm = new SqlCommand("sp_tblError_SelectAll", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetErrorByID(int errorID)
        {
            try
            {
                dbConn.Open();

            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetErrorByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", errorID);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);
            return dt;
        }

        public int DeleteError(error Error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            string sql = "sp_tblError_Delete";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ErrorID", Error.ErrorID);

            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        // methods for FrmSolution
        public int AddSolution(solution Solution)
        {
            try
            {
                dbConn.Open();

            }
            catch
            {
            }
            dbComm = new SqlCommand("sp_tblSolution_Add", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
           
            dbComm.Parameters.AddWithValue("@SolutionDescription", Solution.SolutionDescription);
            dbComm.Parameters.AddWithValue("@LectureID", Solution.LecturerID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }




        public int DeleteSolution(solution Solution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            string sql = "sp_tblSolution_Delete";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SolutionID", Solution.SolutionID);

            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int UpdateError(error Error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            string sql = "sp_tblError_Update";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@ErrorDesciption", Error.ErrorDescription);
            dbComm.Parameters.AddWithValue("@StudentID", Error.StudentID);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", Error.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ModuleTopicID", Error.ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", Error.ErrorStatus);
            dbComm.Parameters.AddWithValue("@ErrorID", Error.ErrorID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int UpdateSolution(solution Solution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_tblSolution_Update";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SolutionDescription", Solution.SolutionDescription);
            dbComm.Parameters.AddWithValue("@LectureID", Solution.LecturerID);

            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        
        public DataTable GetSolution()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            string sql = "sp_GetSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }
        public DataTable GetSolutionByID(int solutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            string sql = "sp_GetSolutionByID";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SolutionID", solutionID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            return dt;
        }

        //Need a GetSolutionByID

        //methods for the ErrorSolution Form 
        public int ErrorSolutionUpdate(ErrorSolution errorSolution )
        {
            try
            {
                dbConn.Open();
            }

            catch 
            {
                
            }
            string sql = "sp_tblErrorSolution_Update";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID",errorSolution.ErrorID);
            dbComm.Parameters.AddWithValue("@SolutionID", errorSolution.SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", errorSolution.SolutionDate);
            int x = dbComm.ExecuteNonQuery();
            return x;
        }

        public int ErrorSolutionDelete(ErrorSolution errorSolution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            { 
            
            }

            string sql = "sp_tblErrorSolution_Delete";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorSolutionID", errorSolution.ErrorSolutionID);

            int x = dbComm.ExecuteNonQuery();

            return x;
        }

        public int ErrorSolutionAdd(ErrorSolution errorSolution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
                
            }
            string sql = "sp_tblErrorSolution_Add";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", errorSolution.ErrorID);
            dbComm.Parameters.AddWithValue("@SolutionID", errorSolution.SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", errorSolution.SolutionDate);

            int x = dbComm.ExecuteNonQuery();

            return x;
        }
        
        public DataTable GetErrorSolution()
        {
            try
            {
                dbConn.Open();
            }
            catch {  }

            dbComm = new SqlCommand("sp_tblErrorSolution_SelectAll", dbConn);
            
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;                    

        }
        public DataTable GetErrorSolutionByID(int errorSolutionID)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_GetErrorSolutionByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorSolutionID", errorSolutionID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetMostProgQuest()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_ProgLangMostQuest", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetLeastProgAnswered()
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_ProgLangLeastAnswered", dbConn);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable ProgLangDiffLang(string sErrorDescrtiption)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbComm = new SqlCommand("sp_ProgLangDiffLang", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorDiscription",sErrorDescrtiption);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;


        }

    }
}
