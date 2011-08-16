using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ClassLibraryWithEntities
{
    public class DataTable
    {
        //protected TEntities genericShit<TEntities>()
        //    where TEntities : ObjectContext, new()
        //{
        //    return new TEntities();
        //}

        protected ObjectContext createEntitiesFactoryMethod()
        {
            return  new MeerkatEntities();
        }

        public IEnumerable<long> DoStaffNonGeneric()
        {
            return new MeerkatEntities().Bloomberg_User.Select(x => x.ID).ToList();
        }
    }
}
