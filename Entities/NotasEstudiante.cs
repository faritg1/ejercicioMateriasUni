
namespace ejercicioMateriasUni.Entities;

public class NotasEstudiante
{
    private string codEstudiante;
    private List<float> quiz = new List<float>(4);
    private List<float> trabajo = new List<float>(2);
    private List<float> parcial = new List<float>(3);

    public string CodEstudiante
    {
        get { return codEstudiante; }
        set { codEstudiante = value; }
    }
    public List<float> Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }
    public List<float> Trabajo
    {
        get { return trabajo; }
        set { trabajo = value; }
    }
    public List<float> Parcial
    {
        get { return parcial; }
        set { parcial = value; }
    }
    

    public NotasEstudiante(){
    }

    public NotasEstudiante(string codEstudiante, List<float> quiz, List<float> trabajo, List<float> parcial){
        this.codEstudiante = codEstudiante;
        this.quiz = quiz;
        this.trabajo = trabajo;
        this.parcial = parcial;
    }
}
