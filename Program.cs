using System.Numerics;

class Paciente
{
    private string nombre;
    private int dpi;
    private int telefono;
    private int edad;

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value < 0)
                Console.WriteLine("la edad no puede ser negativa ");
            else
                edad = value;
        }
    }

    public int Telefono
    {
        get { return telefono; }
        set
        {
            if (value == 8)
                telefono = value;
            else
                Console.WriteLine("deben de ser 8 digitos");
        }
    }

    public int DPi
    {
        get { return dpi; }
        set
        {
            if (value >= 13)
                dpi = value;
            else
                Console.WriteLine("el dpi debe tener 13 caracteres ");
        }
    }

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (value.Length < 3)
                Console.WriteLine("nombre con mas de 3 caracteres ");
            else
                nombre = value;
        }
    }

    public Paciente(string nombre, int dpi, int telefono, int edad)
    {
        this.nombre = nombre;
        this.dpi = dpi;
        this.telefono = telefono;
        this.edad = edad;

    }

    public Paciente(string nombre, long dpi, int numero)
    {
        this.nombre = nombre;
    }

    public void MostrarPaciente()
    {
        Console.WriteLine("Datos del paciente");
        Console.WriteLine("Nombre " + nombre);
        Console.WriteLine("dpi " + dpi);
        Console.WriteLine("telefono " + telefono);
        Console.WriteLine("edad " + edad);
    }
}

class Program
{
    static void Main()
    {
        string Nombre; int dpi; bool esDpi;
        Console.WriteLine("REGISTRO DEL ESTUDIANTE");
       

        do
        {
            Console.WriteLine("Nombre ");
          Nombre = (Console.ReadLine());
            if(Nombre.Length < 3 )
            {
                Console.WriteLine("ingrese un nombre con mas de 3 cracteres");
            }
        } while (Nombre.Length < 3);
        

        do
        {
            Console.WriteLine("dpi");
               /// dpi = Convert.ToInt32(Console.ReadLine());
            esDpi = int.TryParse(Console.ReadLine(), out dpi);
            if( dpi <13)

            {
                Console.WriteLine("no puede ingresar menos de 13 digitos ");
            }
        } while ( dpi < 13);

        int numero;
        bool esnumero;
        do
        {
            Console.WriteLine("telefono");
            esnumero = int.TryParse(Console.ReadLine(),out numero);
            if(!esnumero)
            {
                Console.WriteLine("ingrese 8 digitos ");
            }
        }while (!esnumero);
        
        Paciente e1 = new Paciente (Nombre,dpi,numero) ;
        e1.MostrarPaciente();
    }
}