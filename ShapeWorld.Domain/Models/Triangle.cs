namespace ShapeWorld.Domain.Models
{
    public class Triangle : Shape
    {
        private int baseLength;
        private int height;

        public int Height { get => height; set => height = value; }
        public int BaseLength { get => baseLength; set => baseLength = value; }

        public override double Surface()
        {
            return 0.5 * (baseLength * height);
        }


        public Triangle() : base(3)
        {

        }
    }
}