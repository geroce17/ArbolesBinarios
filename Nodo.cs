using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolesBinarios
{
    class Nodo
    {
        public int dato { get; set; }
        Nodo izquierdo { get; set; }
        Nodo derecho { get; set; }

        Nodo raiz;
        Nodo padre;

        public void agregar(int dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            if (raiz == null)
                raiz = nuevo;
            else
                Agregar(nuevo, raiz);
        }

        private void Agregar(Nodo N, Nodo padre)
        {
            if (N.dato < padre.dato)
                if (padre.izquierdo == null)
                    padre.izquierdo = N;
                else
                    Agregar(N, padre=padre.izquierdo);
            else
            {
                if (padre.derecho == null)
                    padre.derecho = N;
                else
                    Agregar(N, padre = padre.derecho);
            }
        }


        public string inOrden()
        {
            if (raiz == null)
                return "";
            else
            {
                return InOrden(raiz);
            }
        }

        private string InOrden(Nodo n)
        {
            string res = "";
            if (n.izquierdo != null)
                res += InOrden(n.izquierdo);
            res += n.dato;
            if (n.derecho != null)
                res += InOrden(n.derecho);

            return res;
        }

        public string preOrden()
        {
            if (raiz == null)
                return "";
            else
            {
                return PreOrden(raiz);
            }
        }

        private string PreOrden(Nodo n)
        {
            string res = "";
            res += n.dato;
            if (n.izquierdo != null)
                res += PreOrden(n.izquierdo);
            if (n.derecho != null)
                res += PreOrden(n.derecho);

            return res;
        }

        public string postOrden()
        {
            if (raiz == null)
                return "";
            else
            {
                return PostOrden(raiz);
            }
        }

        private string PostOrden(Nodo n)
        {
            string res = "";
            if (n.izquierdo != null)
                res += PostOrden(n.izquierdo);
            if (n.derecho != null)
                res += PostOrden(n.derecho);
            res += n.dato;

            return res;
        }

        public string busqueda(int numero)
        {
            if (raiz != null && numero == raiz.dato)
                return Convert.ToString(raiz.dato);
            else
            {
                return Busqueda(numero, raiz);
            }
        }

        private string Busqueda(int num, Nodo n)
        {
            bool existe = false;

            if (n != null)
            {
                if (n != null && num > n.dato)
                    if (n.derecho != null && num == n.derecho.dato)
                    {
                        return Convert.ToString(n.derecho.dato);
                        existe = true;
                    }
                    else
                        return Busqueda(num, n.derecho);
                else
                {
                    if (n.izquierdo != null && num == n.izquierdo.dato)
                    {
                        return Convert.ToString(n.izquierdo.dato);
                        existe = true;
                    }
                    else
                        return Busqueda(num, n.izquierdo);
                }

                if(existe==false)
                    return "NO SE ENCUENTRA EL DATO BUSCADO";
            }
            else
            {
                return "NO SE ENCUENTRA EL DATO BUSCADO";
            }
        }
    }
}
