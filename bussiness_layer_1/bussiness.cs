using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsPerson_namspace;
using data_layer_1;

namespace bussiness_layer_1
{
    public class ClsBussiness
    {
        public static List<ClsPerson> list_all()
        {
            return ClsData.list_all();
        }
    }
}
