using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Box
    {
        public int Length;
        public int Breadth;

        public Box(int Length, int Breadth)
        {
            this.Length = Length;
            this.Breadth = Breadth;
        }

        public Box Add(Box Box2)
        {
            int newLength = Length + Box2.Length;
            int newBreadth = Breadth + Box2.Breadth;
            return new Box(newLength, newBreadth);
        }


        class Test
        {

            static void Main()
            {
                int l1, l2, b1, b2;
                Console.Write("Box 1 length: ");
                l1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Box 1 bredth: ");
                b1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Box 2 length: ");
                l2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Box 2 bredth: ");
                b2 = Convert.ToInt32(Console.ReadLine());


                Box box1 = new Box(l1, b1);
                Box box2 = new Box(l2, b2);
                Box box3 = box1.Add(box2);

                Console.WriteLine($"Box 1 Length: {l1} and Bredth: {b1}");

                Console.WriteLine($"Box 2 Length: {l2} and Bredth: {b2}\n");

                Console.WriteLine("After adding Box1 And Box2:- ");

                Console.WriteLine($"Box 3 Lenght: {box3.Length} And Bredth: {box3.Breadth}");
                Console.ReadLine();



            }
        }
        // Test test = new Test();
    }
}