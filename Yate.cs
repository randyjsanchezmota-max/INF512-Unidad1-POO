                    //*********************El Perla Negra****************************//

using System;

public class Yate {
    // Atributos
    public string Nombre;
    public double Longitud; // en metros
    public int Capacidad;   // número de personas

    // Constructor
    public Yate(string nombre, double longitud, int capacidad) {
        Nombre = nombre;
        Longitud = longitud;
        Capacidad = capacidad;
    }

    // Métodos
    public void Navegar() {
        Console.WriteLine($"{Nombre} está navegando en el mar.");
    }

    public void Anclar() {
        Console.WriteLine($"{Nombre} ha lanzado el ancla.");
    }

    public void MostrarInfo() {
        Console.WriteLine($"Yate: {Nombre}, Longitud: {Longitud}m, Capacidad: {Capacidad} personas.");
    }
}

class Program {
    static void Main() {
        // Pedir datos al usuario
        Console.Write("Introduce el nombre del yate: ");
        string nombre = Console.ReadLine();

        Console.Write("Introduce la longitud del yate (en metros): ");
        double longitud = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la capacidad del yate (número de personas): ");
        int capacidad = Convert.ToInt32(Console.ReadLine());

        // Crear objeto Yate con los datos introducidos
        Yate miYate = new Yate(nombre, longitud, capacidad);

        // Usar métodos
        miYate.MostrarInfo();
        miYate.Navegar();
        miYate.Anclar();
    }
}

