//Variables: Escribe un programa que reciba datos de una persona y genera un mensaje, 
//usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

//Nombre
Console.WriteLine("Ingresa tu nombre: ");
string nombre = Console.ReadLine();

//Apellido
Console.WriteLine("Ingresa tu apellido: ");
string apellido = Console.ReadLine();

//Edad
Console.WriteLine("Ingresa tu edad: ");
string edad = Console.ReadLine();

//Ciudad
Console.WriteLine("Ingresa tu ciudad: ");
string ciudad = Console.ReadLine();

//Nivel de Ingles
Console.WriteLine("Indique un nivel de ingles entre los siguientes: Basico, Intermedio, Avanzando.");
string nivelIngles = Console.ReadLine();

//Mensaje
Console.WriteLine("Mensaje de confirmacion de datos.");
Console.Write("Bienvenido " + nombre + " " +  apellido + ", ");
Console.Write("tienes " + edad + " años, ");
Console.Write("vives en " + ciudad);
Console.Write(" y tu nivel de ingles es " + nivelIngles + ". Cierto?"); 
