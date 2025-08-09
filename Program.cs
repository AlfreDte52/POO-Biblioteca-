using System;
//clase que representa un vehiculo
public class Libro
{
    public string nombre { get; set; }
    public string autor { get; set; }
    public int anioEdicion { get; set; }

    public Libro(string nombre, string autor, int anioEdicion)
    {
        this.nombre = nombre;
        this.autor = autor;
        this.anioEdicion = anioEdicion;
    }

    //método para acceder a los atributos de la clase
    public string Titulo
    {
        get => nombre;
        set => nombre = value;
    }
    public string Autor
    {
        get => autor;
        set => autor = value;
    }
    public int AnioEdicion
    {
        get => anioEdicion;
        set
        {
            if (value > 0)
            {
                anioEdicion = value;
            }
            else
            {
                throw new ArgumentException("El año de publicación debe ser un número positivo.");
            }
    }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {nombre}, Autor: {autor}, Año de Publicación: {anioEdicion}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Vehiculo
        var miVehiculo = new Libro("Don Quijote", "Miguel de Cervantes", 1605);
        miVehiculo.MostrarInformacion();

        
    }
}