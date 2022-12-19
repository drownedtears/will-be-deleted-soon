using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using bll;

namespace wpf
{
    public class NinjectReg : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbReportsService>().To<ReportsService>();
            Bind<IDbCrud>().To<Dao>();
        }
    }
}