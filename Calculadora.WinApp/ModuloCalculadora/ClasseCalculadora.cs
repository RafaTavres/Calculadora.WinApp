using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.WinApp.ModuloCalculadora
{
    public class ClasseCalculadora
    {
        public string numero1;
        public string numero2;
        public decimal resultado;
        public List<string> historico;
        public delegate decimal Operacao(decimal numero1,decimal numero2);


    }
}
