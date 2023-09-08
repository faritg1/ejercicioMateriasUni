
namespace ejercicioMateriasUni.Entities;

public class NotasEstudiante
{
    private string codEstudiante;
    private List<int> quiz = new List<int>(4);
    private List<int> trabajo = new List<int>(2);
    private List<int> parcial = new List<int>(3);

    public string CodEstudiante
    {
        get { return codEstudiante; }
        set { codEstudiante = value; }
    }
    public List<int> Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }
    public List<int> Trabajo
    {
        get { return trabajo; }
        set { trabajo = value; }
    }
    public List<int> Parcial
    {
        get { return parcial; }
        set { parcial = value; }
    }
    

    public NotasEstudiante(){
    }

    public NotasEstudiante(string codEstudiante, List<int> quiz, List<int> trabajo, List<int> parcial){
        this.codEstudiante = codEstudiante;
        this.quiz = quiz;
        this.trabajo = trabajo;
        this.parcial = parcial;
    }
}
