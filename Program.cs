Console.WriteLine("Hello, World!");
var lista_personas = new List<Personas>
{
    new()
    {
        Id = 1,
        Cedula = "100784987",
        Nombre = "Samuel",
        Apellido = "Ramirez",
        FechaNacimiento = new DateOnly(2003, 1, 6),
        Email = "samuel.rami@gmail.com",
        Telefono = "3333259878"
    },
    new()
    {
        Id = 2,
        Cedula = "1006543210",
        Nombre = "Laura",
        Apellido = "Gomez",
        FechaNacimiento = new DateOnly(1995, 3, 15),
        Email = "laugomez@gmail.com",
        Telefono = "3123456789"
    },
    new()
    {
        Id = 3,
        Cedula = "1009876543",
        Nombre = "Miguel",
        Apellido = "Torres",
        FechaNacimiento = new DateOnly(1988, 7, 20),
        Email = "migueltorres27@gmail.com",
        Telefono = "3109876543"
    },
    new()
    {
        Id = 4,
        Cedula = "1001122334",
        Nombre = "Sofia",
        Apellido = "Herrera",
        FechaNacimiento = new DateOnly(1992, 11, 8),
        Email = "sofirrera@gmail.com",
        Telefono = "3201234567"
    },
    new()
    {
        Id = 5,
        Cedula = "100334556",
        Nombre = "Andres",
        Apellido = "Perez",
        FechaNacimiento = new DateOnly(1985, 12, 30),
        Email = "andresperez45@gmail.com",
        Telefono = "3159876543"
    },
    new()
    {
        Id = 6,
        Cedula = "1000987457",
        Nombre = "Michelle",
        Apellido = "Henao",
        FechaNacimiento = new DateOnly(1999, 4, 7),
        Email = "michelle.corrales@gmail.com",
        Telefono = "3058079951"
    },
    new()
    {
        Id = 7,
        Cedula = "1007654321",
        Nombre = "Oscar",
        Apellido = "Corrales",
        FechaNacimiento = new DateOnly(1960, 12, 16),
        Email = "osquitar16@gmail.com",
        Telefono = "3105048579"
    },
    new()
    {
        Id = 8,
        Cedula = "1005678901",
        Nombre = "Alex",
        Apellido = "Velez",
        FechaNacimiento = new DateOnly(1985, 5, 14),
        Email = "velezalex1985@outlook.com",
        Telefono = "3217846598"
    }
};

var lista_direcciones = new List<Direcciones>{
    new()
    {
        Id=1,
        Via="calle",
        Numero="40",
        Num_Direccion="45",
        Num_Puerta= "78",
        Complemento="Apto 5"
    }
    new()
    {
        Id=2,
        Via="calle",
        Numero="12",
        Num_Direccion="34",
        Num_Puerta= "56",
        Complemento=null,
    }
    new()
    {
        Id=3,
        Via="Via la Ceja",
        Numero=null,
        Num_Direccion=null,
        Num_Puerta= null,
        Complemento="Km 5"
    }
    new()
    {
        Id=4,
        Via="carrera",
        Numero="50",
        Num_Direccion="23",
        Num_Puerta= "89",
        Complemento="Apto 15"
    }
    new()
    {
        Id=5,
        Via="calle",
        Numero="5",
        Num_Direccion="45",
        Num_Puerta= "45",
        Complemento= null
    }
}

var lista_ciudades = new List<Ciudades>{
    new()
    {
        Id=1,
        Nombre= "Cartagena"
    }
    new()
    {
        Id=2,
        Nombre= "Cartagena"
    }
    new()
    {
        Id= 3,
        Nombre= "Medellin"
    }
    new()
    {
        Id=4,
        Nombre= "Santa Marta"
    }
    new()
    {
        Id=1,
        Nombre= "Bogota"
    }

}

var lista_tipos_alojamientos = new List<Tipos_Alejamientos>{
    new()
    {
        Id=1,
        Nombre= "Apartamento"
    }
    new()
    {
        Id=2,
        Nombre= "Casa"
    }
    new()
    {
        Id= 3,
        Nombre= "Cabaña"
    }
    new()
    {
        Id=4,
        Nombre= "Apartamento"
    }
    new()
    {
        Id=1,
        Nombre= "Loft"
    }

}


public class Personas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string? Email { get; set; }
    public string? Telefono { get; set; }

    public List<Alojamientos>? Alojamientos { get; set; }
    public List<Reservas>? Reservas { get; set; }
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

    public List<Alojamientos>? Alojamientos { get; set; }
}

public class Tipos_Alejamientos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }

    public List<Alojamientos>? Alojamientos { get; set; }
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

    public List<Reseñas>? Reseñas { get; set; }
    public List<Reservas>? Reservas { get; set; }
}

public class Estados_Reservas
{
    public int Id { get; set; }
    public string? Nombre { get; set; }

    public List<Reservas>? Reservas { get; set; }
}

public class Reservas
{
    public int Id { get; set; }
    public int Huesped { get; set; }
    public int Alojamiento { get; set; }
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }
    public int CantidadPersonas { get; set; }
    public double CostoTotal { get; set; }
    public int Estado { get; set; }

    public Personas? _Huesped { get; set; }
    public Alojamientos? _Alojamiento { get; set; }
    public Estados_Reservas? _Estado { get; set; }
}

public class Reseñas
{
    public int Id { get; set; }
    public int Huesped { get; set; }
    public int Alojamiento { get; set; }
    public string? Comentario { get; set; }
    public int Puntuacion { get; set; }

    public Personas? _Huesped { get; set; }
    public Alojamientos? _Alojamiento { get; set; }
}