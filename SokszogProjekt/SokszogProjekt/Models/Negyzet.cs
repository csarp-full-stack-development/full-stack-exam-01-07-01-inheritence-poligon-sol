namespace SokszogProjekt.Megosztas.Models
{
    public class Negyzet : Sokszog
    {
        // Öröklődés esetén meg kell hívni az ősosztály konstruktorát (base)
        public Negyzet(double a) : base(a)
        {
        }
        // AZ absztrakt osztály absztrakt metódusát override kulcsszóval írjuk felül
        public override double Kerulet()
        {
            if (OldalA <= 0)
            {
                return double.NaN;
            }
            return 4 * OldalA;
        }

        public override double Terulet()
        {
            if (OldalA <= 0)
            {
                return double.NaN;
            }
            return Math.Pow(OldalA, 2);
        }
    }
}
