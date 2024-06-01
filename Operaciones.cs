namespace Operaciones;

public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}

public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public double Resultado { get => resultadoAnterior; set => resultadoAnterior = value;}

    public double NuevoValor{ get => nuevoValor; set => nuevoValor = value;}
    public TipoOperacion TipoOperacion { get => operacion; set => operacion = value; }
}