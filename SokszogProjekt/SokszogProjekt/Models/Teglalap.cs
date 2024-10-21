namespace SokszogProjekt.Megosztas.Models
{
    public class Teglalap : Sokszog
    {
        protected double OldalB { get; set; }
        public Teglalap(double a, double oldalB) : base(a)
        {
            OldalB = oldalB;
        }

        public override double Kerulet()
        {
            if (OldalA <= 0 || OldalB <= 0)
            {
                return double.NaN;
            }
            return (2 * OldalA) + (2 * OldalB); ;
        }

        public override double Terulet()
        {
            if (OldalA <= 0 || OldalB <= 0)
            {
                return double.NaN;
            }
            return OldalA * OldalB;
        }
    }
}
