//Ejercicio 1
using System.Runtime.ConstrainedExecution;

Console.WriteLine(@"Realice un programa que permita ingresar una cadena de caracteres y se evalúe su
tamaño, si el tamaño es menor que 25 caracteres que rellene con el carácter signo
de dólar($), puede ser relleno por la derecha o por la izquierda.");

Console.WriteLine("Ingrese una cadena de caracteres: ");
string C = Console.ReadLine();


int LDeseada = 25;
int LActual = C.Length;


C = C.PadLeft(LDeseada, '$');


C = C.Substring(0, LDeseada);


Console.WriteLine($"Cadena resultante: {C}");