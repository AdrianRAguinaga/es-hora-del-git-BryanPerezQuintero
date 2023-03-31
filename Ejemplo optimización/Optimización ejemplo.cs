using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Definimos el tamaño de la tabla hash
        const int tamañoTablaHash = 1000000;

        // Definimos la tabla hash
        Dictionary<string, int>[] tablaHash = new Dictionary<string, int>[tamañoTablaHash];
        for (int i = 0; i < tamañoTablaHash; i++)
        {
            tablaHash[i] = new Dictionary<string, int>();
        }

        // Función hash
        int funcionHash(string clave)
        {
            return Math.Abs(clave.GetHashCode()) % tamañoTablaHash;
        }

        // Función para agregar elementos a la tabla hash
        void agregarElemento(string clave, int valor)
        {
            int indice = funcionHash(clave);
            tablaHash[indice].Add(clave, valor);
        }

        // Función para buscar un elemento en la tabla hash
        int buscarElemento(string clave)
        {
            int indice = funcionHash(clave);
            if (tablaHash[indice].ContainsKey(clave))
            {
                return tablaHash[indice][clave];
            }
            else
            {
                return -1; // Si el elemento no existe, devolvemos un valor por defecto (-1 en este caso)
            }
        }

        // Agregamos algunos elementos de ejemplo
        agregarElemento("Juan", 25);
        agregarElemento("Maria", 30);
        agregarElemento("Pedro", 40);
        agregarElemento("Jose", 50);

        // Buscamos algunos elementos de ejemplo
        Console.WriteLine(buscarElemento("Juan"));
        Console.WriteLine(buscarElemento("Pedro"));
        Console.WriteLine(buscarElemento("Ana"));
    }
}
