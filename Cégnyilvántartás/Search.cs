using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cégnyilvántartás
{
    public static class Search
    {

        public static T SearchSecond<T>(this List<T> list)
        {
            if (list != null)
            {
                foreach (var t in list)
                {
                  
                }
            }
            return list[1];
        }
    }
}
