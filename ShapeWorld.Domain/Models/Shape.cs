namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
        //fields
        //backing field is when a field is made private.
        //private int numberOfEdges;

        //properties
        public int NumberOfEdges { get; }

        //methods 
        public virtual double Perimeter()
        {
            return 0;
        }

        public abstract double Surface();

        public double Volume()
        {
            return 0;
        }

        //controllers
        public Shape(int edges)
        {
            NumberOfEdges = edges;
        }
    }
}