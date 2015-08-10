using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStrategyPattern;

namespace TestStrategyPattern
{
    public  abstract class Shape
    {
        public virtual string Draw ()
        {
            return "Shape";
        }
    }


    public class Circle: Shape
    {
        public override string Draw()
        {
 	         return "Circle";
        }
    }
    
    public class Square: Shape
    {        
        public override string Draw()
        {
 	         return "Square";
        }
    }





    class Program
    {
        
        public static Shape[] Controller()
        {
            Shape [] shapes= new Shape[5];
            shapes[0]=new Circle();
            shapes[1]=new Square();
            shapes[2]=new Circle();
            shapes[3]=new Square();
            shapes[4]=new Circle();

            return shapes;
        }
        
        static void Main(string[] args)
        {
            Shape[] shapes = Controller();

            for(int i=0;i<shapes.Length;i++)
            {
                Console.WriteLine("Shape[{0}]= " + shapes[i].Draw(), i);
            }

            Console.ReadLine();
        }
    }
}
