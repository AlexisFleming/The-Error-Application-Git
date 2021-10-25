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

    }
}
