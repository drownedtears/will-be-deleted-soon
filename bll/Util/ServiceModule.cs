using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace bll
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule()
        {
        }

        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IDbRepository>().To<DbReposSQL>().InSingletonScope().WithConstructorArgument(connectionString);
        }
    }
}
