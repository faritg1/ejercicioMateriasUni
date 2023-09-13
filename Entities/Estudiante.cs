namespace ejercicioMateriasUni.Entities;

public class Estudiante : NotasEstudiante
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
    
    public Estudiante() : base() {
    }

    public Estudiante(List<float> quiz, List<float> trabajo, List<float> parcial, string codigo, string nombre, string email, int edad, string direccion){
        this.Quiz = quiz;
        this.Trabajo = trabajo;
        this.Parcial = parcial;
        this.codigo = codigo;
        this.nombre = nombre;
        this.email = email;
        this.edad = edad;
        this.direccion = direccion;
    }

    public void registrarEstudiante(List<Estudiante> arrayEstud){
        /* try{ */
            Estudiante estudiante = new Estudiante();
            
            Console.WriteLine("Codigo del estudiante");
            estudiante.Codigo = Console.ReadLine().ToLower();
            //nota.CodEstudiante = estudiante.Codigo;

            Console.WriteLine("Nombre del estudiante");
            estudiante.Nombre = Console.ReadLine();

            Console.WriteLine("Email del estudiante");
            estudiante.Email = Console.ReadLine();

            Console.WriteLine("Edad del estudiante");
            estudiante.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Direccion del estudiante");
            estudiante.Direccion = Console.ReadLine();

            estudiante.Quiz = new List<float>();
            estudiante.Trabajo = new List<float>();
            estudiante.Parcial = new List<float>();

            if((estudiante.Codigo.Length >= 0 && estudiante.Codigo.Length <=15) && (estudiante.Nombre.Length >=0 && estudiante.Nombre.Length <= 40) && (estudiante.Email.Length >=0 && estudiante.Email.Length <=40) && (estudiante.Direccion.Length>=0 && estudiante.Direccion.Length <= 40)){
                arrayEstud.Add(estudiante);
            }else{
                Console.WriteLine("hay un error al registrar los datos del estudiante");
            }
        /* }catch (Exception ex){
            Console.WriteLine("ALGO HIZO MAL!!! {0}",ex.Message.ToString());
        } */
    }
}
