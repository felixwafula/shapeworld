using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;

namespace ShapeWorld.Domain.Collections
{
    public class ShapeArray
    {
        public void DimensionalArray()
        {
            //1-D Array.
            Shape[] shaped = new Shape[10];
            Shape[] shaped2 = new Shape[] { new Square() };

            //2-D Array.
            Shape[,] shaped3 = new Shape[2, 2];
            Shape[,] shaped4 = new Shape[,] { { new Square(), new Square() }, { new Cube(), new Triangle() } };

            //3-D Array.
            Shape[,,] shaped5 = new Shape[3, 3, 3];
            Shape[,,] shaped6 = new Shape[,,]
            {
                {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}},
                {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}},
                {{new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}, {new Square(), new Square(), new Square()}}
            };

            //READ
            System.Console.WriteLine(shaped2[0]);
            System.Console.WriteLine(shaped4[1, 0]);
            System.Console.WriteLine(shaped6[1, 0, 2]);

            //JAGGED ARRAY
            Shape[][] shaped7 = new Shape[10][]; //an array of 10 arrays that have one dimenion.
            Shape[][] shaped8 = new Shape[][]
            {
                new Rectangle[10],
                new Circle[]{new Circle(), new Circle()}
            };

            System.Console.WriteLine(shaped8[1][1]);

        }
        public void MyList()
        {
            List<Shape> shaped = new List<Shape>();
            List<Shape> shaped2 = new List<Shape> { new Cube(), new Cube() };
            List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
            List<Shape[][,,]> shapd4 = new List<Shape[][,,]> { new Shape[5][,,] };

            //READ 
            System.Console.WriteLine(shaped2[1]);
            System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 4)); //predicate function
            System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 4));

            //WRITE
            try
            {
                shaped2[100] = new Rectangle();
                shaped2.IndexOf(shaped2.Last());
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (OverflowException)
            {
                shaped2.Add(new Rectangle());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Console.WriteLine("its final");
            }

            shaped2.Add(new Triangle());
            shaped2.AddRange(shaped2);

            //REMOVE
            shaped2.Remove(new Cube());
        }
        //Reading from the list
        // public void Search(object o, List<object> 1)
        // {
        //     1.foreach (o1 in 1)
        //     {
        //         if (o.Equals(o1))
        //         {
        //             yield return o1;
        //         }
        //     }
        //}

        public void MyDictionary()
        {
            Dictionary<string, Shape> shaped = new Dictionary<string, Shape>();
            Dictionary<string, List<Shape>> shaped2 = new Dictionary<string, List<Shape>>
            {
                {"square", new List<Shape>()}
            };

            //READ
            System.Console.WriteLine(shaped2["square"]);
            shaped2.Select(d => d.Key == "square");

            //WRITE
            shaped2["square"] = new List<Shape>();
            shaped2.Add("square", new List<Shape>());
        }

    }
}