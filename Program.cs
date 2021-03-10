using System;

namespace LabWork_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = EnterVector3DInfo();
            Vector3D b = EnterVector3DInfo();
            
            DisplayVector3D(a, nameof(a));
            DisplayVector3D(b, nameof(b));

            //Sum vectors
            Vector3D sum1 = a + b;
            Vector3D sum2 = Vector3D.Sum(a, b);
            Vector3D sum3 = Vector3D.Sum(a, (20d, 20d, -31.123d));
            DisplayVector3D(sum1, nameof(sum1));
            DisplayVector3D(sum2, nameof(sum2));
            DisplayVector3D(sum3, nameof(sum3));

            //Subtract vectors
            Vector3D sub1 = a - b;
            Vector3D sub2 = Vector3D.Subtract(a, b);
            Vector3D sub3 = Vector3D.Subtract(a, (20d, 20d, -31.123d));
            DisplayVector3D(sub1, nameof(sub1));
            DisplayVector3D(sub2, nameof(sub2));
            DisplayVector3D(sub3, nameof(sub3));


            //Multiply vectors
            Vector3D mult1 = a * b;
            Vector3D mult2 = Vector3D.MultiplyVectors(a, b);
            Vector3D mult3 = Vector3D.MultiplyVectors(a, -10.5d);
            double scalarResult = Vector3D.ScalarMultiplication(a, b);
            DisplayVector3D(mult1, nameof(mult1));
            DisplayVector3D(mult2, nameof(mult2));
            DisplayVector3D(mult3, nameof(mult3));
            Console.WriteLine($"Scalar multiplication result: {scalarResult}");

            Console.ReadLine();
        }
        public static Vector3D EnterVector3DInfo()
        {
            Console.WriteLine("\n_________________________ENTERING VECTOR INFO_________________________");
            Console.Write("Enter X value:\n=> ");
            (double x, double y, double z) endPoint;
            while (!double.TryParse(Console.ReadLine(), out endPoint.x))
            {
                Console.Write("Invalid input. Try again.\n=> ");
            }

            Console.Write("Enter Y value:\n=> ");
            while (!double.TryParse(Console.ReadLine(), out endPoint.y))
            {
                Console.Write("Invalid input. Try again.\n=> ");
            }

            Console.Write("Enter Z value:\n=> ");
            while (!double.TryParse(Console.ReadLine(), out endPoint.z))
            {
                Console.Write("Invalid input. Try again.\n=> ");
            }
            Console.WriteLine("_____________________________END OF INPUT_____________________________\n");
            return new Vector3D(endPoint);
        }

        public static void DisplayVector3D(Vector3D vector, string name)
        {
            Console.WriteLine($"[{name}] {vector}");
        }
    }
}
