namespace EspacioCalculadora;
using Operaciones;
public class Calculadora
{
    public void Sumar(double Termino, Operacion historial)
    {
        historial.Resultado = historial.NuevoValor;
        historial.NuevoValor += Termino;
        historial.TipoOperacion = TipoOperacion.Suma; 
    }
    public void Restar(double Termino, Operacion historial)
    {
        historial.Resultado = historial.NuevoValor;

        historial.NuevoValor -= Termino;
        historial.TipoOperacion = TipoOperacion.Resta; 

    }

    public void Multiplicar(double Termino, Operacion historial)
    {
        historial.Resultado = historial.NuevoValor;
        historial.NuevoValor *= Termino;
        historial.TipoOperacion = TipoOperacion.Multiplicacion; 
    }

    public void Dividir(double Termino, Operacion historial)
    {
        if(Termino != 0)
        {
            historial.Resultado = historial.NuevoValor;
            historial.NuevoValor /= Termino;
        }else
        {
            System.Console.WriteLine("No se realizo ninguna operacion, no se puede dividir en 0");
        }
        historial.TipoOperacion = TipoOperacion.Division; 
    }

    public void Limpiar(Operacion historial)
    {
        historial.Resultado = historial.NuevoValor;
        historial.NuevoValor = 0;
        historial.TipoOperacion = TipoOperacion.Limpiar;
    }
        
    public void MostrarHistorial(List<Operacion> historial)
    {
        int i = 1;
        foreach(Operacion operacion in historial)
        {
            System.Console.WriteLine($"\t\t-------------------------Operacion N°{i}-------------------------");
            switch(operacion.TipoOperacion){
                case TipoOperacion.Suma:
                    System.Console.WriteLine($"\t\t\t\t\t{operacion.Resultado} + {operacion.NuevoValor-operacion.Resultado} = {operacion.NuevoValor}");
                    System.Console.WriteLine($"\t\t\t\tNumero guardado en memoria: {operacion.NuevoValor}");
                    break;
                case TipoOperacion.Resta:
                    System.Console.WriteLine($"\t\t\t\t\t{operacion.Resultado} - {operacion.Resultado-operacion.NuevoValor} = {operacion.NuevoValor}");
                    System.Console.WriteLine($"\t\t\t\tNumero guardado en memoria: {operacion.NuevoValor}");
                    break;
                case TipoOperacion.Multiplicacion:
                    System.Console.WriteLine($"\t\t\t\t\t{operacion.Resultado} * {operacion.NuevoValor/operacion.Resultado} = {operacion.NuevoValor}");
                    System.Console.WriteLine($"\t\t\t\tNumero guardado en memoria: {operacion.NuevoValor}");
                    break;
                case TipoOperacion.Division:
                    System.Console.WriteLine($"\t\t\t\t\t{operacion.Resultado} / {operacion.Resultado/operacion.NuevoValor} = {operacion.NuevoValor}");
                    System.Console.WriteLine($"\t\t\t\tNumero guardado en memoria: {operacion.NuevoValor}");
                    break;
                case TipoOperacion.Limpiar:
                    System.Console.WriteLine("\t\t\t\tSe limpio la calculadora");
                    System.Console.WriteLine($"\t\t\t\tNumero guardado en memoria: {operacion.NuevoValor}");
                    break;
            }
            System.Console.WriteLine("\t\t---------------------------------------------------------------");
            i++;
        }
    }
}

