using Tareas;
using OperacionesTareas;
using EspacioCalculadora;
using Operaciones;

///* ------------------------------EJERCICIO1 ------------------------------*/
// operadorTareas herramientas = new operadorTareas();

// System.Console.WriteLine("Ingrese la cantidad de tareas pendientes a ingresar: ");
// int.TryParse(System.Console.ReadLine(), out int cantNodos);

// List<Tarea> tareasPendientes = herramientas.generarTarea(cantNodos);
// List<Tarea> tareasRealizadas = new List<Tarea>();

// int seguirOperando = 0;

// while(seguirOperando != 1){
//     System.Console.WriteLine("Elija una opción: ");
//     int.TryParse(Console.ReadLine(), out int opcion);
//     System.Console.WriteLine("1 - Mostrar las tareas");
//     System.Console.WriteLine("2 - Completara tarea");
//     System.Console.WriteLine("3 - Buscar tarea pendiente por descripcion");

//     switch(opcion)
//     {
//         case 1:
//             System.Console.WriteLine("-------------Tarea Pendientes-------------");
//             herramientas.mostrarListaTareas(tareasPendientes);
//             System.Console.WriteLine("------------------------------------------");

//             System.Console.WriteLine("-------------Tarea Realizadas-------------");
//             herramientas.mostrarListaTareas(tareasRealizadas);
//             System.Console.WriteLine("------------------------------------------");
//             break;
//         case 2:
//             herramientas.Completar(tareasPendientes, tareasRealizadas);
//             break;
//         case 3:
//             System.Console.WriteLine("Ingrese alguna subcadena que quiere buscar en productos Pendientes: ");
//             string subcadena = System.Console.ReadLine();
//             herramientas.mostrarTareasPendientesPorDescripcion(tareasPendientes, subcadena);
//             break;        
//         default:
//             System.Console.WriteLine("Ingrese una opcion del 1 al 3");
//             break;
//     }

//     System.Console.WriteLine("Seguir operando?(1:si, 0:no)");
//     int.TryParse(System.Console.ReadLine(), out seguirOperando);
// }

/* ------------------------------EJERCICIO2 ------------------------------*/

Console.Clear();
Calculadora calculadora = new Calculadora();
List<Operacion> historial = new List<Operacion>();
// Si definiera pips?, no se que dijo el profe, pero si quisiera hacer calculador.Sumar(3).Sumar(3), tengo que definirla como lo que comente en la clase calculadora, asi podria hacer que se llamara a sí misma

string aux;
int seguirOperando = 1;
int opcion;
double numero;
System.Console.WriteLine("Ingrese el primer numero con el que iniciar la calculadora:");
aux = Console.ReadLine();
double.TryParse(aux, out numero);


while(seguirOperando!=0)
{
    System.Console.WriteLine("-------------------------------------------Calculadora-------------------------------------------");
    System.Console.WriteLine($"Numero en memoria: {numero}");
    System.Console.WriteLine("Ingrese la operacion a realizar:");
    System.Console.WriteLine("1 - Sumar");
    System.Console.WriteLine("2 - Restar");
    System.Console.WriteLine("3 - Multiplicar");
    System.Console.WriteLine("4 - Dividir");
    System.Console.WriteLine("5 - Limpiar calculadora");
    System.Console.WriteLine("6 - Mostrar Historial");
    System.Console.WriteLine("-------------------------------------------------------------------------------------------------");

    aux = Console.ReadLine();
    int.TryParse(aux, out opcion);

    Operacion operacion = new Operacion();
    if(opcion >= 1 && opcion <= 4)
    {
        System.Console.WriteLine("\nIngrese el numero con el que operar:");
        operacion.NuevoValor = numero;
        aux = Console.ReadLine();
        double.TryParse(aux, out numero);
    }

    switch (opcion){
        case 1:
            calculadora.Sumar(numero, operacion);
            historial.Add(operacion);
            break;
        case 2:
            calculadora.Restar(numero, operacion);
            historial.Add(operacion);
            break;
        case 3:
            calculadora.Multiplicar(numero, operacion);
            historial.Add(operacion);
            break;
        case 4:
            calculadora.Dividir(numero, operacion);
            historial.Add(operacion);
            break;
        case 5:
            calculadora.Limpiar(operacion);
            historial.Add(operacion);
            break;
        case 6:
            System.Console.WriteLine("\t-------------------------------------Historial-------------------------------------");
            calculadora.MostrarHistorial(historial);
            System.Console.WriteLine("\t-----------------------------------------------------------------------------------\n");
            break;
        default:
            System.Console.WriteLine("NO SE REALIZO NINGUNA OPERACION\n Por favor, Ingrese un valor entre 1 y 6");
            break;
    }

    if(opcion >= 1 && opcion <= 5)
    {
        numero = operacion.NuevoValor;
        System.Console.WriteLine("\nQuiere seguir operando?(1:si, 0:no):\n");
        aux = Console.ReadLine();
        Console.Clear();
    }


    int.TryParse(aux, out seguirOperando);
}