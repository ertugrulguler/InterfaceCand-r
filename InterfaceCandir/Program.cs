using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCandir
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManagerHelper.IssueManager.Add(new Issue());

            //    IIssueManager issueManager = ManagerFactory.CreateIssueManager();
            //    issueManager.Add(new Issue());

            
            ManagerFactory.CreateIssueManager().Add(new Issue());
        }
    }
}
