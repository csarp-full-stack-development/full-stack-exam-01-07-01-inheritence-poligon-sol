namespace SokszogProjekt.Megosztas.Models
{
    // Általában fogalmak az absztrakt osztályok amelyek nem lehet példányosítani
    public abstract class Sokszog
    {
        protected double OldalA { get; set; }
        // Absztrakt metódus, nem kell legyen kódrésze, előírás, hogy minden sokszögnek kell legyen ilyen metódusa
        public abstract double Kerulet();
        public abstract double Terulet();

        protected Sokszog(double a)
        {
            OldalA = a;
        }
    }
}
