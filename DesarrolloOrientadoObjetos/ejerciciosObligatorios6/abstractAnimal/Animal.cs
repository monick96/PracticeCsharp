namespace Ejercicio1
{
    abstract class Animal
    {
        protected float peso;
        protected int edad;
        public Animal (float peso, int edad)
        {
            this.peso = peso;
            this.edad = edad;
        }
        public abstract void MostrarInfo();
        
        
    }
}