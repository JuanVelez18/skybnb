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