// Creamos un arreglo tradicional con algunos valores
int[] miArreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Definimos una tabla de hash
Dictionary<int, int> miTablaHash = new Dictionary<int, int>();

// Agregamos los valores del arreglo a la tabla de hash utilizando su índice como clave
for (int i = 0; i < miArreglo.Length; i++)
{
    miTablaHash.Add(i, miArreglo[i]);
}

// Buscamos un valor en la tabla de hash utilizando su índice como clave
int valorBuscado = miTablaHash[5]; // Devuelve el valor 6

// Agregamos un nuevo valor a la tabla de hash
miTablaHash.Add(miArreglo.Length, 11);

// Modificamos un valor existente en la tabla de hash
miTablaHash[3] = 400;

// Eliminamos un valor de la tabla de hash
miTablaHash.Remove(2);