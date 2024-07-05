using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace MyCourse.Models.Services.Infrastucture
{
    public interface IDatabaseAccessor
    {
        DataSet Query(FormattableString formattableQuery);
        int QueryInsert(FormattableString formattableQuery);
         //int QueryInsert(string query);
    }
}