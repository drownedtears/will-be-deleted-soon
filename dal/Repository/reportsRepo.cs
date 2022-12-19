using dal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class reportsRepo : IReportsRepository
    {
        private MyTaskContext db;
        public class Result
        {
            public int deal_id { get; set; }
            public decimal price { get; set; }
            public DateTime date { get; set; }
        }

        public reportsRepo(MyTaskContext dbcontext)
        {
            this.db = dbcontext;
        }
        /*
        public List<R1Result> report1Execute(Group client)
        {
            MyTaskContext db = new MyTaskContext();
            var request = db.all_deal
                .Join(db.real_property, rp => rp.real_property_id, d => d.real_property_id, (rp, d) => rp)
                .Where(i => i.client_customer_id == client.client_id || i.client_owner_id == client.client_id)
                .Select(i => new R1Result { type = i.real_property.type, location = i.real_property.location })
                .ToList();
            return request;
            return null;
        }
    

        public List<R2Result> report2Execute(Group client)
        {
            MyTaskContext db = new MyTaskContext();
            SqlParameter param1 = new SqlParameter("@name", client.full_name);
            var result = db.Database.SqlQuery<R2Result>("findByName @name", param1);
            var data = result
            .Select(i => new R2Result
            {
                deal_id = i.deal_id,
                price = i.price,
                date = i.date
            }).ToList();
            return data;
            return null;
        }
        */
    }
}
