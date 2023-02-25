using Tarea3.Entidades;
using Tarea3.Negocios;

Numeros numero = new Numeros();
ClsNumeros clsnumeros = new ClsNumeros();

Console.WriteLine("Ingresa el numero menor");
numero.numeroMinimo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el numero mayor");
numero.numeroMaximo = int.Parse(Console.ReadLine());

clsnumeros.ImprimirPares(numero);