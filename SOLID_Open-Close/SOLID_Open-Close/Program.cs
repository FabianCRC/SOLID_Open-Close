using SOLID_Open_Close.Clases;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehiculo[] listaVehiculos = {  new Honda(),
                                       new Nissan(), 
                                       new Toyota(),
                                       new Ferrari()};//En caso de querer agregar otro vehiculo unicamente se crea la clase,
                                                      //se implementa la clase abstracta Vehiculo y se agrega el nuevo vehiculo en el arreglo
        ImprimirPrecios(listaVehiculos);
    }

    private static void ImprimirPrecios(IEnumerable vehiculos)
    {
        foreach (Vehiculo vehiculo in vehiculos)
        {
            Console.WriteLine(vehiculo.obtenerNombre() + " tiene un valor de :" + vehiculo.obtenerValor());
        }
    }
}