using ejercicioMateriasUni;
using ejercicioMateriasUni.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> arrayEstud = new List<Estudiante>();
        Estudiante student = new Estudiante();
        int op = 0;
        bool entrando = true;
        while (entrando){
            /* try{ */
                do{
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("|-----------------------------Programa Universitario-----------------------------|");
                    Console.WriteLine("|  1. Registrar Estudiante/s                                                     |");
                    Console.WriteLine("|  2. Registrar Notas                                                            |");
                    Console.WriteLine("|  3. Mostrar Todos los Estudiantes                                              |");
                    Console.WriteLine("|  0. Salir                                                                      |");
                    Console.WriteLine("|--------------------------------------------------------------------------------|");
                    Console.Write("--> ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 0:
                            entrando = false;
                            Console.Clear();
                            Console.WriteLine("Gracias por usar este programa");
                            break;
                        case 1:
                            Console.Clear();
                            student.registrarEstudiante(arrayEstud);
                            break;
                        case 2:
                            Console.Clear();
                            misFunciones.menoNota(arrayEstud);
                            break;
                        case 3:
                            misFunciones.mostrarEstudiante(arrayEstud);
                            break;
                        default:
                            Console.WriteLine("EY!!! TE SALISTE DEL RANGO");
                            Thread.Sleep(1000);
                            break;
                    }
                } while (op != 0);
            /* }catch(Exception ex){
                Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
                Thread.Sleep(1000);
                entrando = true;
            } */
        }
    }
}