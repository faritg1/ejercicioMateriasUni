using ejercicioMateriasUni.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> arrayEstud = new List<Estudiante>();
        int op = 0;
        try{
            do{
                Console.WriteLine("-----------------------------PROGRAMA UNIVERSIDAD-----------------------------");
                Console.WriteLine("1. Registrar Estudiante/s");
                Console.WriteLine("2. Registrar Notas");
                Console.WriteLine("3. Mostrar Todos los Estudiantes");
                Console.WriteLine("0. Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Gracias por usar este programa");
                        break;
                    case 1:
                        registrarEstudiante(arrayEstud);
                        break;
                    case 2:
                        break;
                    case 3:
                        mostrarEstudiante(arrayEstud);
                        break;
                    default:
                        Console.WriteLine("EY!!! TE SALISTE DEL RANGO");
                        break;
                }
            } while (op != 0);
        }
        catch(Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        }
    } 
    public static void registrarEstudiante(List<Estudiante> arrayEstud){
        try{
            int n = 0;
            Console.WriteLine("Cuantos estudiantes desea Registrar: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Estudiante estudiante = new Estudiante();
                Console.WriteLine("Codigo del estudiante {0}",i+1);
                estudiante.Codigo = Console.ReadLine();

                Console.WriteLine("Nombre del estudiante {0}",i+1);
                estudiante.Nombre = Console.ReadLine();

                Console.WriteLine("Email del estudiante {0}",i+1);
                estudiante.Email = Console.ReadLine();

                Console.WriteLine("Edad del estudiante {0}",i+1);
                estudiante.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Direccion del estudiante {0}",i+1);
                estudiante.Direccion = Console.ReadLine();

                arrayEstud.Add(estudiante);
            }
        }
        catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        }
    }

    public static void mostrarEstudiante(List<Estudiante> arrayEstud){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", "CODIGO", "NOMBRE", "Email", "Edad", "Direccion");
        foreach (Estudiante item in arrayEstud){
            Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", item.Codigo, item.Nombre, item.Email, item.Edad, item.Direccion);
        }
    }
}