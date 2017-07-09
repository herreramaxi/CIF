using CIF.Model;
using CIF.Repositories.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIF.Repositories
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<EntityModel.CIFEntities>
    {
        protected override void Seed(CIFEntities context)
        {
            var repo = new UserRepository();        

            var user = new CIF.Model.User { FirstName = "Max", LastName = "Herrera" };
            repo.Add(user);
            repo.SaveChanges();
        }
    }
}
