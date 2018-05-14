using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкетирование
{
    public static class my_global
    {
        public static int id_pers = 1;
        public static int id_store = -1;
        //класс
        public static ArrayList bank_anket;
        public static void init_bank_anket()
        {
            bank_anket = new ArrayList();
            read_from_db();
        }
        public static void write_in_db()
        {

        }
        public static void read_from_db()
        {

        }
        //
        public static void init()
        {
            init_bank_anket();
        }
    }
}
