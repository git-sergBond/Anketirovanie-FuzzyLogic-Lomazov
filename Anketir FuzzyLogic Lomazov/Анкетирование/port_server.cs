using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анкетирование
{
    public static class port_server
    {
        public const int ERROR = -1;
        public const int OK = 1;
        public static int sign_in(string login, string pass)
        {
            //есть ли чел в базе
            if (port_db_helper.is_valid_pers(login, pass) > 0)
            {// да - получить ID

                int id = port_db_helper.get_ID_pers(login);
                return id;
            }
            return ERROR;
        }
        public static int sign_up(string login, string pass, string group, string id_type_person)
        {
            int id = -1;
            id = 1;
            if (port_db_helper.registrazia(login, pass, group, id_type_person))
            {
                //    id = port_db_helper.get_ID_pers(login);
            }
            return id;
        }
    }
}
