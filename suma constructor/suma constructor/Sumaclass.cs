using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma_constructor
{
    //clase
    internal class Sumaclass
    {
        //campo propiedades, como es
        private int n1;
        private int n2;

        //constructor
        public Sumaclass(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //metodo, accion, lo que hace
        public int sumar()
        {
            return (n1 + n2);
        }

    }
}
