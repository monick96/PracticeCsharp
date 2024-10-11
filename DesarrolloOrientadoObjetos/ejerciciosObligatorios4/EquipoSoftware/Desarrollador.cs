namespace EquipoSoftware
{
    public class Desarrollador:Integrante
    {
        private string lenguajePrincipal;
        private int aniosAntiguedad;

        public Desarrollador(string nombre,string apellido,
        DateTime fechaIngreso,DateTime fechaNacimiento,
        string lenguajePrincipal):base(nombre,apellido,fechaIngreso,fechaNacimiento)
        {
            this.lenguajePrincipal = lenguajePrincipal;
            this.aniosAntiguedad = CalcularAntiguedad(this.fechaIngreso);
        }

        private int CalcularAntiguedad(DateTime fechaIngreso )
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Year - fechaIngreso.Year;
        }
        public override void MostrarInfo()
        {
            System.Console.WriteLine("Puesto : Desarrollador");
            base.MostrarInfo();
            System.Console.WriteLine($"Lenguaje Principal: {this.lenguajePrincipal}");
            System.Console.WriteLine($"Antiguedad: {this.aniosAntiguedad} anios");
            System.Console.WriteLine("------------------------");
        }
        
    }

}