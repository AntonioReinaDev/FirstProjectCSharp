using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBitcoin
{
    internal class KeyClass
    {
        public int ID; 
        public string Key;
        public static int TotalDeContasFeitas { get; private set; }
        public int numerosContas;

        //OBRIGATORIEDADE PARA TER VALORES NO ID E KEY
        public KeyClass(int id, string key)
        {
                ID = id;
                Key = key;
                TotalDeContasFeitas++;
                numerosContas = TotalDeContasFeitas;
        }

    }
}
