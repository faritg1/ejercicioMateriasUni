using ejercicioMateriasUni.Entities;

namespace ejercicioMateriasUni
{
    public class misFunciones{
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
                            Estudiante alumnoQ = arrayEstud.FirstOrDefault(x => x.Codigo.Equals(cod));

                            if(alumnoQ != null){
                                if(alumnoQ.Quiz.Count < 4){
                                    Console.WriteLine("Por favor ingrese la nota del");
                                    Console.WriteLine("Quiz Nro : {0}",alumnoQ.Quiz.Count+1);
                                    alumnoQ.Quiz.Add(float.Parse(Console.ReadLine()));
                                    int idx = arrayEstud.FindIndex(y => y.Codigo.Equals(cod));
                                    arrayEstud[idx] = alumnoQ;
                                }else{
                                    Console.WriteLine("Los campos de los quices ya estan llenos para el estudiante {0}",alumnoQ.Nombre);
                                    Console.ReadKey();
                                }
                            }else{
                                Console.WriteLine("El codigo no fue encontrado");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese el codigo del estudiante");
                            cod = Console.ReadLine();
                            Estudiante alumnoT = arrayEstud.FirstOrDefault(x => x.Codigo.Equals(cod));

                            if(alumnoT != null){
                                if(alumnoT.Trabajo.Count < 2){
                                    Console.WriteLine("Por favor ingrese la nota del");
                                    Console.WriteLine("Trabajo Nro : {0}",alumnoT.Trabajo.Count+1);
                                    alumnoT.Trabajo.Add(float.Parse(Console.ReadLine()));
                                    int idx = arrayEstud.FindIndex(y => y.Codigo.Equals(cod));
                                    arrayEstud[idx] = alumnoT;
                                }else{
                                    Console.WriteLine("Los campos de los trabajos ya estan llenos para el estudiante {0}",alumnoT.Nombre);
                                    Console.ReadKey();
                                }
                            }else{
                                Console.WriteLine("El codigo no fue encontrado");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese el codigo del estudiante");
                            cod = Console.ReadLine();
                            Estudiante alumnoP = arrayEstud.FirstOrDefault(x => x.Codigo.Equals(cod));

                            if(alumnoP != null){
                                if(alumnoP.Parcial.Count < 2){
                                    Console.WriteLine("Por favor ingrese la nota del");
                                    Console.WriteLine("Parcial Nro : {0}",alumnoP.Parcial.Count+1);
                                    alumnoP.Parcial.Add(float.Parse(Console.ReadLine()));
                                    int idx = arrayEstud.FindIndex(y => y.Codigo.Equals(cod));
                                    arrayEstud[idx] = alumnoP;
                                }else{
                                    Console.WriteLine("Los campos de los Parciales ya estan llenos para el estudiante {0}",alumnoP.Nombre);
                                    Console.ReadKey();
                                }
                            }else{
                                Console.WriteLine("El codigo no fue encontrado");
                                Console.ReadKey();
                            }
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