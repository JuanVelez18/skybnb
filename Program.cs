Console.WriteLine("Hello, World!");

public class Personas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string? Email { get; set; }
    public string? Telefono { get; set; }
}

public class Direcciones
{
    public int Id { get; set; }
    public string? Via { get; set; }
    public string? Numero { get; set; }
    public string? NumeroInterseccion { get; set; }
    public string? NumeroPuerta { get; set; }
    public string? Complemento { get; set; }
}

public class Ciudades
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
}

public class Tipos_Alejamientos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
}

public class Alojamientos
{
    public int Id { get; set; }
    public int Anfitrion { get; set; }
    public string? Descripcion { get; set; }
    public int Direccion { get; set; }
    public int Ciudad { get; set; }
    public int Tipo { get; set; }
    public double CostoNoche { get; set; }
    public int CantidadHabitaciones { get; set; }
    public int CantidadBaños { get; set; }

    public Personas? _Anfitrion { get; set; }
    public Direcciones? _Direccion { get; set; }
    public Ciudades? _Ciudad { get; set; }
    public Tipos_Alejamientos? _Tipo { get; set; }

}