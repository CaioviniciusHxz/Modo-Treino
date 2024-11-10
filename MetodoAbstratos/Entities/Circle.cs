using MetodoAbstratos.Entities.Enums;
namespace MetodoAbstratos.Entities
{

    class Circles : Shape
    {
        public double Radius { get; set; }

        public Circles(double radius, Color color) : base(color)
        {
            Radius = radius;

        }

        public override double Area()
        {
            return 3.14 * (Radius * Radius);
        }
    }
}



