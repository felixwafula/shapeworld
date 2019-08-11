namespace ShapeWorld.Domain.Models
{
    public class Circle : Shape
    {
        public double Pi;
        public double radius;

        public override double Surface()
        {
            return 2 * Pi * (radius * radius);
        }

        public Circle() : base(1)
        {

        }

    }
}