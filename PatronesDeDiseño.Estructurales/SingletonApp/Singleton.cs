using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Singleton
    {
        private static Singleton instancia;

        private Singleton() { }

        public static Singleton GetInstancia()
        {
            if(instancia == null)
            {
                instancia = new Singleton();
            }

            return instancia;
        }

        public string Valor { set; get; }
    }
}
