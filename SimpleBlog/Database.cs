using NHibernate.Cfg;

namespace SimpleBlog
{
    public static class Database
    {
        public static void Configure()
        {
            var config = new Configuration();

            //configure the connection string
            // we do not provide any arguments here
            // by default nhibernate will look to the web.config and get it from there
            config.Configure(); 
            //add our mappings
             
            //create session factory
        }

        public static void OpenSession()
        {
            
        }

        public static void CloseSession()
        {
            
        }

    }
}