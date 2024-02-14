int dia;
int op;

Console.WriteLine("Coloca un numero: ");
op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine("Es Lunes");
        break;
    case 2:
        Console.WriteLine("Es Martes");
        break;
    case 3:
        Console.WriteLine("Es Miercoles");
        break;
    case 4:
        Console.WriteLine("Es Jueves");
        break;
    case 5:
        Console.WriteLine("Es Viernes");
        break;
    case 6:
        Console.WriteLine("Es Sabado");
        break;
    case 7:
        Console.WriteLine("Es Domingo");
        break;

}