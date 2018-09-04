using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class tinta
    {
        private ConsoleColor _color;
        private eTipoTinta _tipo;


        public tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = eTipoTinta.ConBrillita;
        }

        public tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }

        public tinta(ConsoleColor color, eTipoTinta tipo ) : this(color)
        {
            this._tipo = tipo;
        }


        public static string mostrar(tinta algo)
        {
            return algo.mostrar();
        }

        private string mostrar()
        {

            return "Tipo de tinta: " +  this._tipo + " \nColor de tinta: " + this._color + " " ;
        }

        public static bool operator ==(tinta t1, tinta t2)
        {
            bool retorno= false;

            if (t1._color == t2._color && t1._tipo == t2._tipo)
                retorno = true;

                return retorno;
        }

        public static bool operator !=(tinta t1, tinta t2)
        {
            return !(t1 == t2);
        }

    }
}
