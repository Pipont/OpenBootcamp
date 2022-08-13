// See https://aka.ms/new-console-template for more information

//Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

string nombre, apellido, sabeprogramar;
int edad;

Console.WriteLine("Ingrese el nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese el apellido");
apellido = Console.ReadLine();
Console.WriteLine("Sabe programar? (Y/N)");
sabeprogramar = Console.ReadLine();
Console.WriteLine("Ingrese la edad");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(nombre + " " + apellido + " " + sabeprogramar + " " + edad.ToString());
