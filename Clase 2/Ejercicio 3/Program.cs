// See https://aka.ms/new-console-template for more information

/*
NUMERO MAYOR O IGUAL A 18
*/
int num;
num = 20;

Console.WriteLine("Condicion " + (num > 18));

/*
UN CHAR ES A
*/

char variable;
variable = 'b';
Console.WriteLine("Condicion " + (variable == 'a'));

/*
SE CUMPLEN DOS CONDICIONES A LA VEZ
*/

Console.WriteLine("Condiciones " + (num > 18 && variable == 'a'));

/*
SE CUMPLE UNA CONDICION A LA VEZ
*/
Console.WriteLine("Condiciones " + (num > 18 || variable == 'a'));
