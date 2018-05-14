using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкетирование
{
    class anketa
    {
        public int col;
        public string[] qwestion;
        public int[] type_qwestion;
        public const int da_net = 0;
        public const int ot2_do5 = 1;
        public int[] answer;
        public anketa(int col = 5)
        {
            this.col = col;
            qwestion = new string[col];
            type_qwestion = new int[col];
            answer = new int[col];
        }
 
    }
}
