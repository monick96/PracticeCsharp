namespace EquipoSoftware 
{
  public class Integrante
  {
    protected string nombre;
    protected string apellido;
    protected DateTime fechaIngreso;
    protected DateTime fechaNacimiento;
    protected int edad;

    public Integrante(string nombre, string apellido, DateTime fechaIngreso, DateTime fechaNacimiento)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaIngreso = fechaIngreso;
        this.fechaNacimiento = fechaNacimiento;
        this.edad = CalcularEdad(this.fechaNacimiento);
    }

    protected int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaActual = DateTime.Now;
        return fechaActual.Year - fechaNacimiento.Year;
    }

    public virtual void MostrarInfo()
    {
        System.Console.WriteLine($"Nombre: {this.nombre}");
        System.Console.WriteLine($"Apellido: {this.apellido}");
        System.Console.WriteLine($"Edad: {this.edad}");
    }
  }

    
}