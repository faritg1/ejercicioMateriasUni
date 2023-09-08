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
                        Console.WriteLine("Gracias por usar este programa");
                        Thread.Sleep(1000);
                        Console.Clear();
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
                        mostrarEstudiante(arrayEstud,arrayNot);
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

                arrayEstud.Add(estudiante);
                arrayNot.Add(nota);
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
                                if(item.Quiz.Count < 4){
                                    Console.WriteLine("Ingrese la nota del quiz {0}",item.Quiz.Count+1);
                                    item.Quiz.Add(int.Parse(Console.ReadLine()));
                                    arrayNot.Add(item);
                                    break;
                                }else{
                                    Console.WriteLine("Los campos de los quices ya estan llenos");
                                    break;
                                }
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
                                    if(item.Trabajo.Count < 4){
                                        Console.WriteLine("Ingrese la nota del Trabajo {0}",item.Trabajo.Count+1);
                                        item.Trabajo.Add(int.Parse(Console.ReadLine()));
                                        arrayNot.Add(item);
                                        break;
                                    }else{
                                        Console.WriteLine("Los campos de los Trabajo ya estan llenos");
                                        break;
                                    }
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
                                    if(item.Parcial.Count < 4){
                                        Console.WriteLine("Ingrese la nota del parcial {0}",item.Parcial.Count+1);
                                        item.Parcial.Add(int.Parse(Console.ReadLine()));
                                        arrayNot.Add(item);
                                        break;
                                    }else{
                                        Console.WriteLine("Los campos de los Parciales ya estan llenos");
                                        break;
                                    }
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

    public static void mostrarEstudiante(List<Estudiante> arrayEstud,List<NotasEstudiante> arrayNot){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", "CODIGO", "NOMBRE", "Email", "Edad", "Direccion");
        foreach (Estudiante item in arrayEstud){
            Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", item.Codigo, item.Nombre, item.Email, item.Edad, item.Direccion);
        }
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} |", "CODIGO", "QUIZ", "TRABAJO", "PARCIAL");
        foreach (NotasEstudiante item in arrayNot){
            Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} |", item.CodEstudiante, item.Quiz, item.Trabajo, item.Parcial);
        }
    }
}