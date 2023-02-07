//Operadores: Determina los operadores para verificar las siguientes condiciones:

//Un número es mayor o igual a 18
int numero = 9;
Console.WriteLine(numero >= 18);

//Un char es ‘a’
char c = 'c';
Console.WriteLine(c == 'a');

//Se cumplen dos conciones a la vez (ambas verdaderas)
Console.WriteLine(c == 'c' && numero > 8);

//Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine(numero < 10 || c == 'b');