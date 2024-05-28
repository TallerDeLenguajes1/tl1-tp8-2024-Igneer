namespace OperacionesTareas;

using System.Security.Cryptography.X509Certificates;
using Tareas;
class operadorTareas
{
    private int i = 0;
    private Random random = new Random();
    public List<Tarea> generarTarea(int cantNodos) //Factory, fabrica las tareas
    {
        List<Tarea> ListaGenerada = new List<Tarea>();

        for(int j = 0; j<cantNodos; j++)
        {
            Tarea tareaGenerada = new Tarea();

            tareaGenerada.TareaID = i;
            System.Console.WriteLine("Ingrese la descripcion de la tarea: ");
            tareaGenerada.Descripcion = System.Console.ReadLine();
            tareaGenerada.Duracion = random.Next(1,101);
            i++;

            ListaGenerada.Add(tareaGenerada);
        }

        return ListaGenerada;
    } 

    public void Completar(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
    {
        System.Console.WriteLine("Ingrese el ID de la tarea a realizar: ");
        int.TryParse(System.Console.ReadLine(), out int ID);
        var tareaAmover = tareasPendientes.SingleOrDefault(tarea => tarea.TareaID == ID); //Devuelve el elemento que satisface la condicion que le ingreso, la condicion se pone como si fuea un foreach
        tareasRealizadas.Add(tareaAmover);
        tareasPendientes.RemoveAll(tarea => tarea.TareaID == ID);
    }

    public void mostrarTareasPendientesPorDescripcion(List<Tarea> tareasPendientes, string cadenaBuscada)
    {
        if(tareasPendientes.Exists(tarea => tarea.Descripcion.Contains(cadenaBuscada) == true)){
            foreach(Tarea x in tareasPendientes)
            {
                if(x.Descripcion.Contains(cadenaBuscada))
                {
                    System.Console.WriteLine("---------Tarea Encontrada:---------");
                    System.Console.WriteLine($"Tarea ID: {x.TareaID}");
                    System.Console.WriteLine($"Descripcion: {x.Descripcion}");
                    System.Console.WriteLine($"Duracion: {x.Duracion}");
                    System.Console.WriteLine("-----------------------------------");
                }
            }
        }else
        {
            System.Console.WriteLine("Tarea no encontrada");
        }
    }

    public void mostrarListaTareas(List<Tarea> Lista)
    {
        foreach(Tarea x in Lista)
        {    
            System.Console.WriteLine("-------------Tarea-------------");
            System.Console.WriteLine($"TareaID: {x.TareaID}");
            System.Console.WriteLine($"Descripcion: {x.Descripcion}");
            System.Console.WriteLine($"Duracion: {x.Duracion}");
            System.Console.WriteLine("-------------------------------");
        }
    }

}