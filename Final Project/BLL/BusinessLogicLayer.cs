using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertTopic(Topic topic)
        {
            return dal.InsertTopic(topic);
        }
        public int UpdateTopic(Topic topic)
        {
            return dal.UpdateTopic(topic);
        }
        public DataTable GetTopic()
        {
            return dal.GetTopic();
        }
        public DataTable GetTopicByID(int topicID)
        {
            return dal.GetTopicByID(topicID);
        }
        public int DeleteTopic(Topic topic)
        {
            return dal.DeleteTopic(topic);
        }

        public int InsertModuleTopic(ModuleTopic modTop)
        {
            return dal.InsertModuleTopic(modTop);
        }
        public int UpdateModuleTopic(ModuleTopic modTop)
        {
            return dal.UpdateModuleTopic(modTop);
        }
        public int DeleteModuleTopic(ModuleTopic modTop)
        {
            return dal.DeleteModuleTopic(modTop);
        }
        public DataTable GetModuleTopic()
        {
            return dal.GetModuleTopic();
        }
        public DataTable GetModuleTopicByID(int modTopicID)
        {
            return dal.GetModuleTopicByID(modTopicID);
        }
        public DataTable GetModule()
        {
            return dal.GetModule();
        }
        public int InsertRole(Role role)
        {
            return dal.InsertRole(role);

        }
        public DataTable GetRole()
        {
            return dal.GetRole();
        }
        public int InsertProgLanguage(ProgLanguage prog)
        {
            return dal.InsertProgLanguage(prog);
        }
        public int UpdateProgLanguage(ProgLanguage prog)
        {
            return dal.UpdateProgLanguage(prog);
        }
        public int DeleteProgLanguage(ProgLanguage prog)
        {
            return dal.DeleteProgLanguage(prog);
        }
        public DataTable GetProgLanguageByID(int progLanguageID)
        {
            return dal.GetProgLanguageByID(progLanguageID);
        }
        public DataTable GetProgLanguage()
        {
            return dal.GetProgLanguage();
        }
        public DataTable ReportModule(int moduleID)
        {
            return dal.ReportModule(moduleID);
        }
        public int InsertYear(Year year)
        {
            return dal.InsertYear(year);
        }
        public int UpdateYear(Year year)
        {
            return dal.UpdateYear(year);
        }
        public int DeleteYear(Year year)
        {
            return dal.DeleteYear(year);
        }
        public DataTable GetYearByID(int yearID)
        {
            return dal.GetYearByID(yearID);
        }
        public DataTable GetYear()
        {
            return dal.GetYear();
        }
        public int InsertModule(Module mod)
        {
            return dal.InsertModule(mod);
        }
        public int UpdateModule(Module mod)
        {
            return dal.UpdateModule(mod);
        }
        public int DeleteModule(Module mod)
        {
            return dal.DeleteModule(mod);
        }
        public DataTable GetModuleByID(int moduleID)
        {
            return dal.GetModuleByID(moduleID);
        }

    }
}
