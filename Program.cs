// ejercio 1
using System.Runtime;

Console.WriteLine("cual es tu nombre?");
string nombre = Console.ReadLine();


Console.WriteLine("cual es tu apellido?");
string apellido = Console.ReadLine();


Console.WriteLine("cual es tu edad?");
int edad = Convert.ToInt32( Console.ReadLine());




Console.WriteLine("sabes programar?");
string know = Console.ReadLine();



Console.Write(" hola" + " " + nombre + " " + apellido);
Console.Write(" tu edad es de " + edad + " años");
Console.Write( " " + know + " " + ",sabe programar");

//ejercio 2

//objeto coche
int puertas = 4;

int ruedas = 4;

string marca = "ford";

Boolean itvVigente = true;

//objeto mesa 

int peso = 6; //kg

int largo = 2; //metros

string material = "madera de roble";

string color = "rojo"; 

//ejercicio 3
int numero = 1;

char c = 'a';

Console.WriteLine(numero >= 18);
Console.WriteLine(c == 'a');
Console.WriteLine(numero < 18 && c == 'b');
Console.WriteLine(numero < 18 || c == 'b');






