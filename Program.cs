using System;

namespace LabWork_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = EnterVector3DInfo();
            Vector3D b = EnterVector3DInfo();

            DisplayVector3D(a);
            DisplayVector3D(b);
            Console.ReadLine();
        }
        public static Vector3D EnterVector3DInfo()
        {
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
            return new Vector3D(endPoint);
        }

        public static void DisplayVector3D(Vector3D vector)
        {
            Console.WriteLine(vector.ToString());
        }
    }
}
