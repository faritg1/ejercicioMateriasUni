namespace ejercicioMateriasUni.Entities;

public class Estudiante
{
    private string codigo;
    private string nombre;
    private string email;
    private int edad;
    private string direccion;
    private int quiz;

    private int trabajo;
    private int parcial;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }
    public int Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }
    public int Trabajo
    {
        get { return trabajo; }
        set { trabajo = value; }
    }
    public int Parcial
    {
        get { return parcial; }
        set { parcial = value; }
    }
    public Estudiante(){
    }

    public Estudiante(string codigo, string nombre, string email, int edad, string direccion, int quiz, int parcial){
        this.codigo = codigo;
        this.nombre = nombre;
        this.email = email;
        this.edad = edad;
        this.direccion = direccion;
        this.quiz = quiz;
        this.parcial = parcial;
    }
}
