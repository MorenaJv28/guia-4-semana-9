//Ejercicio 2

Console.WriteLine(@"Aplicar las funciones de cadenas vistas en clases para la codificación de un
programa que permita ingresar al usuario 2 cadenas y que verifique a través de los
métodos CompareTo() y Equals() si las cadenas son iguales, mostrando el mensaje
según los resultados de la evaluación de cada método.");

Console.WriteLine("Ingrese la primera cadena:");
string C1 = Console.ReadLine();

Console.WriteLine("Ingrese la segunda cadena:");
string C2 = Console.ReadLine();

int ResCompareTo = C1.CompareTo(C2);

if (ResCompareTo == 0)
{
    Console.WriteLine("Las 2 cadenas son iguales.");
}
else if (ResCompareTo < 0)
{
    Console.WriteLine("La  cadena 1 es menor que la cadena 2.");
}
else
{
    Console.WriteLine("La cadena 1  es mayor que la cadena 2.");
}
