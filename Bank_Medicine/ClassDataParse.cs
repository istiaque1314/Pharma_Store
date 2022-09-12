using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Medicine
{
    internal class ClassDataParse
    {

        static string medicine_name, qty;
        public static string name
        {
            get
            {
                return medicine_name;
            }
            set
            {
                medicine_name = value;
            }
        }
        public static string quantity
        {
            get
            {
                return qty;

            }
            set
            {
                qty = value;
            }
        }



    }
}
