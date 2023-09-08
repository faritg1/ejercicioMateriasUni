namespace ejercicioMateriasUni.Entities;

public class Estudiante
{
    private string codigo;
    private string nombre;
    private string email;
    private int edad;
    private string direccion;

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
    
    public Estudiante(){
    }

    public Estudiante(string codigo, string nombre, string email, int edad, string direccion){
        this.codigo = codigo;
        this.nombre = nombre;
        this.email = email;
        this.edad = edad;
        this.direccion = direccion;
    }
}
