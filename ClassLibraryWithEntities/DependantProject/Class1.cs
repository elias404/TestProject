using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClassLibraryWithEntities;

namespace DependantProject
{
    public class Class1
    {
        List<string> list = new List<string>();
        public void UseLinq()
        {
            new DataTable().DoStaffNonGeneric();

            var x = list.ToList();
        }

    }
}
