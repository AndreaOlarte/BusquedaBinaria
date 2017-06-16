using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_23.BusquedaBinaria
{
    class Vector
    {
        static Random aleatorio = new Random();
        private int[] _numeros;
        private int _comparaciones;
        public int comparaciones
        {
            get { return _comparaciones; }
            private set { _comparaciones = value; }
        }

        public Vector(int tamaño)
        {
            _numeros = new int[tamaño];
        }

        public void llenar(int limite)
        {
            for(short i = 0; i < _numeros.Length; i++)
            {
                _numeros[i] = aleatorio.Next(0, limite + 1);
            }
        }

        public void ordenar()
        {
            Array.Sort(_numeros);
        }

        public override string ToString()
        {
            string cadena = "";
            for (short i = 0; i < _numeros.Length; i++)
                cadena += _numeros[i].ToString() + Environment.NewLine;
            return cadena;
        }

        public int busquedaBinaria(int numero)
        {
            _comparaciones = 0;
            int li = 0;
            int ls = _numeros.Length - 1;
            if (numero < _numeros[li] || numero > _numeros[ls])
                return -2; 
            else
                return busquedaBinaria(li, ls, numero);
        }

        private int busquedaBinaria(int li, int ls, int numero)
        {
            int comparando = li + (ls - li) / 2;
            if (li + 1 == ls && li != 0)
            {
                comparaciones++;
                if (_numeros[ls] == numero)
                    return ls;
                else
                    return -1;
            }
            else if (li + 1 == ls)
            {
                comparaciones++;
                if (numero == _numeros[comparando])
                    return comparando;
                else
                    return -1;
            }
            else
            {
                comparaciones++;
                if (numero == _numeros[comparando])
                    return comparando;
                else if (numero < _numeros[comparando])
                {
                    ls = comparando;
                    return busquedaBinaria(li, ls, numero);
                }
                else
                {
                    li = comparando;
                    return busquedaBinaria(li, ls, numero);
                }
            }
        }
    }
}
