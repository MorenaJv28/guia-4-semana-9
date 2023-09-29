// Ejercicio 3 
Console.WriteLine(@"Dada la siguiente cadena de caracteres: “MI MAMA ME MIMA, AMO A MI MAMA”
realizar lo siguiente
- convertir la frase a letras minúsculas
- separar la frase cada vez que se encuentre un espacio en blanco
- si la longitud de la frase separada es menor que 3, concatenar la frase con el
signo de porcentaje %
");

string Frase = "MI MAMA ME MIMA, AMO A MI MAMA";

Frase = Frase.ToLower();

string[] Palabras = Frase.Split(' ');

string Resultado = "";

foreach (string palabra in Palabras)
{
    if (palabra.Length < 3)
    {
        Resultado += palabra + "% ";
    }
    else
    {
        Resultado += palabra + " ";
    }
}
Resultado = Resultado.Trim();
Console.WriteLine(Resultado);

