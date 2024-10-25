namespace EquipoSoftware
{
    public class Tester:Integrante
    {
        private TipoTesting tipoTesting;//Manual, Automatico
       
        public Tester(string nombre,string apellido,
        DateTime fechaIngreso,DateTime fechaNacimiento,
        TipoTesting tipoTesting):base(nombre,apellido,fechaIngreso,fechaNacimiento)
        {
            this.tipoTesting = tipoTesting;
            
        }

        
        public override void MostrarInfo()
        {
            System.Console.WriteLine("Puesto : Tester");
            base.MostrarInfo();
            System.Console.WriteLine($"Tipo de Testing: {this.tipoTesting}");
            System.Console.WriteLine("------------------------");
        }
        
    }

    /// <summary>
    /// enum con los tipos de testing
    /// </summary>
    public enum TipoTesting
    {
        Manual,
        Automatico
    }

}