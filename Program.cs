using ejercicioMateriasUni;
using ejercicioMateriasUni.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Estudiante> arrayEstud = new List<Estudiante>();
        List<NotasEstudiante> arrayNot = new List<NotasEstudiante>();
        int op = 0;
        /* try{ */
            do{
                Console.ResetColor();
                Console.WriteLine("-----------------------------PROGRAMA UNIVERSIDAD-----------------------------");
                Console.WriteLine("1. Registrar Estudiante/s");
                Console.WriteLine("2. Registrar Notas");
                Console.WriteLine("3. Mostrar Todos los Estudiantes");
                Console.WriteLine("0. Salir");
                Console.WriteLine("-------------------------------------------------------------------------------");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Gracias por usar este programa");
                        break;
                    case 1:
                        Console.Clear();
                        registrarEstudiante(arrayEstud,arrayNot);
                        break;
                    case 2:
                        Console.Clear();
                        registarNota(arrayNot);
                        break;
                    case 3:
                        misFunciones.mostrarEstudiante(arrayEstud,arrayNot);
                        break;
                    default:
                        Console.WriteLine("EY!!! TE SALISTE DEL RANGO");
                        break;
                }
            } while (op != 0);
        /* }catch(Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        } */
    } 
    public static void registrarEstudiante(List<Estudiante> arrayEstud, List<NotasEstudiante> arrayNot){
        /* try{ */
            int n = 0;
            Console.WriteLine("Cuantos estudiantes desea Registrar: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Estudiante estudiante = new Estudiante();
                NotasEstudiante nota = new NotasEstudiante();
                
                Console.WriteLine("Codigo del estudiante {0}",i+1);
                estudiante.Codigo = Console.ReadLine().ToLower();
                nota.CodEstudiante = estudiante.Codigo;

                Console.WriteLine("Nombre del estudiante {0}",i+1);
                estudiante.Nombre = Console.ReadLine();

                Console.WriteLine("Email del estudiante {0}",i+1);
                estudiante.Email = Console.ReadLine();

                Console.WriteLine("Edad del estudiante {0}",i+1);
                estudiante.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Direccion del estudiante {0}",i+1);
                estudiante.Direccion = Console.ReadLine();

                if((estudiante.Codigo.Length >= 0 && estudiante.Codigo.Length <=15) && (estudiante.Nombre.Length >=0 && estudiante.Nombre.Length <= 40) && (estudiante.Email.Length >=0 && estudiante.Email.Length <=40) && (estudiante.Direccion.Length>=0 && estudiante.Direccion.Length <= 40)){
                    arrayEstud.Add(estudiante);
                    arrayNot.Add(nota);
                }else{
                    Console.WriteLine("hay un error al registrar los datos del estudiante");
                }
            }
        /* }catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        } */
    }

    public static void registarNota(List<NotasEstudiante> arrayNot){
        int op = 0;
        /* try{ */
            do{
                Console.WriteLine("----------------------REGISTRAR NOTAS------------------------");
                Console.WriteLine("1. Registrar Quices");
                Console.WriteLine("2. Registrar Trabajos");
                Console.WriteLine("3. Registrar Parciales");
                Console.WriteLine("0. Volver al menu");
                Console.WriteLine("-------------------------------------------------------------");
                op = int.Parse(Console.ReadLine());
                string id;
                switch (op){
                    case 0:
                        Console.WriteLine("Volviendo al menu...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Ingrese el codigo del estudiante");
                        id = Console.ReadLine();
                        foreach (NotasEstudiante item in arrayNot){
                            if (item.CodEstudiante == id){
                                do
                                {
                                    misFunciones.agregandoQuiz(item);                                    
                                    Console.WriteLine("¿Desea Agregar nota de otro Quiz? si(Y) no(N)");
                                } while (Console.ReadLine().ToUpper() == "Y");
                            }else{
                                Console.WriteLine("Estudiante no encontrado");
                            }
                        }
                        break;
                    case 2:
                            Console.WriteLine("Ingrese el codigo del estudiante");
                            id = Console.ReadLine();
                            foreach (NotasEstudiante item in arrayNot){
                                if (item.CodEstudiante == id){
                                    do
                                    {
                                        misFunciones.agregandoTrabajo(item);                                    
                                        Console.WriteLine("¿Desea Agregar nota de otro Trabajo? si(Y) no(N)");
                                    } while (Console.ReadLine().ToUpper() == "Y");
                                }else{
                                    Console.WriteLine("Estudiante no encontrado");
                                }
                            }
                        break;
                    case 3:
                            Console.WriteLine("Ingrese el codigo del estudiante");
                            id = Console.ReadLine();
                            foreach (NotasEstudiante item in arrayNot){
                                if (item.CodEstudiante == id){
                                    do
                                    {
                                        misFunciones.agregandoParcial(item);                                    
                                        Console.WriteLine("¿Desea Agregar nota de otro Trabajo? si(Y) no(N)");
                                    } while (Console.ReadLine().ToUpper() == "Y");
                                }else{
                                    Console.WriteLine("Estudiante no encontrado");
                                }
                            }
                        break;
                    default:
                        Console.WriteLine("EY!!! TE SALISTE DEL RANGO");
                        break;
                }
            }while(op != 0);

        /* }catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        }  */
    }
}