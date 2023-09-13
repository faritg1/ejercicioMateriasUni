using ejercicioMateriasUni.Entities;

namespace ejercicioMateriasUni
{
    public class misFunciones{

        public static void agregandoQuiz(NotasEstudiante notasQ){
            if(notasQ.Quiz.Count < 4){
                Console.WriteLine("Ingrese la nota del quiz {0}",notasQ.Quiz.Count+1);
                notasQ.Quiz.Add(Convert.ToInt32(Console.ReadLine()));
            }else{
                Console.WriteLine("Los campos de los quices ya estan llenos");
            }
        }

        public static void agregandoTrabajo(NotasEstudiante notasT){
            if(notasT.Trabajo.Count < 2){
                Console.WriteLine("Ingrese la nota del trabajo {0}",notasT.Trabajo.Count+1);
                notasT.Trabajo.Add(Convert.ToInt32(Console.ReadLine()));
            }else{
                Console.WriteLine("Los campos de los trabajos ya estan llenos");
            }
        }

        public static void agregandoParcial(NotasEstudiante notasP){
            if(notasP.Parcial.Count < 3){
                Console.WriteLine("Ingrese la nota del parcial {0}",notasP.Parcial.Count+1);
                notasP.Parcial.Add(Convert.ToInt32(Console.ReadLine()));
            }else{
                Console.WriteLine("Los campos de los parciales ya estan llenos");
            }
        }

        public static void mostrarEstudiante(List<Estudiante> arrayEstud){
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", "CODIGO", "NOMBRE", "Email", "Edad", "Direccion");
                foreach (Estudiante item in arrayEstud){
                    Console.WriteLine("| {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |", item.Codigo, item.Nombre, item.Email, item.Edad, item.Direccion);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
        }

        public static void menoNota(List<Estudiante> arrayEstud){
            int op = 0;
            /* try{ */
                do{
                    Console.Clear();
                    Console.WriteLine("|-----------------------------Registrar Notas-----------------------------|");
                    Console.WriteLine("|  1. Registrar Quices                                                    |");
                    Console.WriteLine("|  2. Registrar Trabajos                                                  |");
                    Console.WriteLine("|  3. Registrar Parciales                                                 |");
                    Console.WriteLine("|  0. Volver al menu                                                      |");
                    Console.WriteLine("|-------------------------------------------------------------------------|");
                    op = int.Parse(Console.ReadLine());
                    string cod;
                    switch (op){
                        case 0:
                            Console.WriteLine("Volviendo al menu...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el codigo del estudiante");
                            cod = Console.ReadLine();
                            Estudiante alumno = arrayEstud.FirstOrDefault(x => x.Codigo.Equals(cod));

                            if(alumno != null){
                                Console.WriteLine("Por favor ingrese la nota del : ");
                                Console.WriteLine("Quiz Nro : {0}",alumno.Quiz.Count+1);
                                alumno.Quiz.Add(float.Parse(Console.ReadLine()));

                                int idx = arrayEstud.FindIndex(y => y.Codigo.Equals(cod));
                                arrayEstud[idx] = alumno;
                            }else{
                                Console.WriteLine("El codigo no fue encontrado");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                                Console.WriteLine("Ingrese el codigo del estudiante");
                                cod = Console.ReadLine();
                                /* foreach (NotasEstudiante item in arrayNot){
                                    if (item.CodEstudiante == cod){
                                        do
                                        {
                                            misFunciones.agregandoTrabajo(item);                                    
                                            Console.WriteLine("¿Desea Agregar nota de otro Trabajo? si(Y) no(N)");
                                        } while (Console.ReadLine().ToUpper() == "Y");
                                    }else{
                                        Console.WriteLine("Estudiante no encontrado");
                                    }
                                } */
                            break;
                        case 3:
                                Console.WriteLine("Ingrese el codigo del estudiante");
                                cod = Console.ReadLine();
                                /* foreach (NotasEstudiante item in arrayNot){
                                    if (item.CodEstudiante == cod){
                                        do
                                        {
                                            misFunciones.agregandoParcial(item);                                    
                                            Console.WriteLine("¿Desea Agregar nota de otro Trabajo? si(Y) no(N)");
                                        } while (Console.ReadLine().ToUpper() == "Y");
                                    }else{
                                        Console.WriteLine("Estudiante no encontrado");
                                    }
                                } */
                            break;
                        default:
                            Console.WriteLine("EY!!! TE SALISTE DEL RANsadsadGO");
                            break;
                    }
                }while(op != 0);

            /* }catch (Exception ex){
                Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
            }  */
        }
    }
}