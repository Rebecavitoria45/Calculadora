using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;
        public Calculadora(string data)
        {
           listahistorico = new List<string>();
            this.data = data;
        }
        public int somar(int v1, int v2)
        {
            int res = v1 + v2;
            listahistorico.Insert(0, "Res:" + res + "-data:" + data );
            return res;
        }
        public int subtrair(int v1, int v2)
        {
            int res = v1 - v2;
            listahistorico.Insert(0, "Res:" + res + "-data:" + data);
            return res;
        }
        public int multiplicar(int v1, int v2)
        {
            int res = v1 * v2;
            listahistorico.Insert(0, "Res:" + res + "-data:" + data);
            return res;
        }
        public int dividir(int v1, int v2)
        {
          int res = v1/v2;
            listahistorico.Insert(0, "Res:" + res + "-data:"+ data);
            return res;
        }
        public List<string> historico()
        {

            listahistorico.RemoveRange(3,listahistorico.Count-3);
            return listahistorico;
        }
    }
}
     
