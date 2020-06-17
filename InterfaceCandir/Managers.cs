using System;

namespace InterfaceCandir
{
    // Open-Closed Principle(Prensip)

    public class IssueManagerEF : IIssueManager
    {
        public void Add(Issue issue)
        {
            // EF veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }

    public class CategoryManagerEF : ICategoryManager
    {
        public void Add(Category cat)
        {
            // EF veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }

    public class IssueManagerRest : IIssueManager
    {
        public void Add(Issue issue)
        {
            // RestSharp veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }

    public class CategoryManagerRest : ICategoryManager
    {
        public void Add(Category cat)
        {
            // RestSharp veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }

    public class IssueManagerMongo : IIssueManager
    {
        public void Add(Issue issue)
        {
            // Mongo veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }

    public class CategoryManagerMongo : ICategoryManager
    {
        public void Add(Category cat)
        {
            // Mongo veritabanına bağlanıyor..
            throw new NotImplementedException();
        }
    }
}