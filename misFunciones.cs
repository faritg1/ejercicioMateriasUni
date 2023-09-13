using ejercicioMateriasUni.Entities;

namespace ejercicioMateriasUni
{
    public class misFunciones
    {
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
            foreach (int notQ in item.Quiz)
            {
                Console.WriteLine("| {0,-20} | {1,-20}", item.CodEstudiante, item.Quiz);
            }
            
        }
    }
    }
}