using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using dal;

namespace bll
{
    public partial class ReportsService : IDbReportsService
    {
        IDbRepository db;

        public ReportsService(IDbRepository repo)
        {
            db = repo;
        }

        /*
        public List<R1Result> report1Execute(groupModel client)
        {
            throw new NotImplementedException();
        }

        public List<R2Result> report2Execute(groupModel client)
        {
            throw new NotImplementedException();
        }
        */
    }

}
