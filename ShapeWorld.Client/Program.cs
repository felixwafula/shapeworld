using System;
using ShapeWorld.Domain.Collections;
using ShapeWorld.Domain.Models;


namespace ShapeWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayWithShape();
            PlayWithCollection();
        }

        private static void PlayWithShape()
        {
            //someShape.NumberOfEdges = 10;
            Shape someShape = new Rectangle();

            //from square.
            Rectangle someSquare = new Square();

            //from rectangle.
            Rectangle someRectangle = new Rectangle() as Square; //casting.  

            //from cube.
            Shape someCube = new Cube();


            //Console.WriteLine(someShape.NumberOfEdges);
            System.Console.WriteLine(someShape.Volume());//0
            System.Console.WriteLine(someSquare.NumberOfEdges);
            System.Console.WriteLine(someSquare.Volume());//1234
        }

        private static void PlayWithCollection()
        {
            ShapeArray sa = new ShapeArray();

            sa.DimensionalArray();
            sa.MyList();
            sa.MyDictionary();
        }
    }
}
