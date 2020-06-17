using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCandir
{
    public static class ManagerHelper
    {
        public readonly static IIssueManager IssueManager = new IssueManagerRest();
        public readonly static ICategoryManager CategoryManager = new CategoryManagerEF();
    }

    public static class ManagerFactory
    {
        public static IIssueManager CreateIssueManager()
        {
            return new IssueManagerMongo();
        }

        public static ICategoryManager CreateCategoryManager()
        {
            return new CategoryManagerEF();
        }
    }
}
