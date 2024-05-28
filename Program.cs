using Tareas;
using OperacionesTareas;

operadorTareas herramientas = new operadorTareas();

System.Console.WriteLine("Ingrese la cantidad de tareas pendientes a ingresar: ");
int.TryParse(System.Console.ReadLine(), out int cantNodos);

List<Tarea> tareasPendientes = herramientas.generarTarea(cantNodos);
List<Tarea> tareasRealizadas = new List<Tarea>();

int seguirOperando = 0;

while(){
    System.Console.WriteLine();


    System.Console.WriteLine("Seguir operando?(1:si, 0:no)");
    int.TryParse(System.Console.ReadLine(), out seguirOperando);
}



System.Console.WriteLine("-------------Tarea Pendientes-------------");
herramientas.mostrarListaTareas(tareasPendientes);
System.Console.WriteLine("------------------------------------------");

System.Console.WriteLine("-------------Tarea Realizadas-------------");
herramientas.mostrarListaTareas(tareasRealizadas);
System.Console.WriteLine("------------------------------------------");


herramientas.Completar(tareasPendientes, tareasRealizadas);

System.Console.WriteLine("-------------Tarea Pendientes-------------");
herramientas.mostrarListaTareas(tareasPendientes);
System.Console.WriteLine("------------------------------------------");

System.Console.WriteLine("-------------Tarea Realizadas-------------");
herramientas.mostrarListaTareas(tareasRealizadas);
System.Console.WriteLine("------------------------------------------");

System.Console.WriteLine("Ingrese alguna subcadena que quiere buscar en productos Pendientes: ");

string subcadena = System.Console.ReadLine();
herramientas.mostrarTareasPendientesPorDescripcion(tareasPendientes, subcadena);

