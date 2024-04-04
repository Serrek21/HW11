using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW11.Task1;
using static HW11.Task2;
using static HW11.Task3;

namespace HW11
{
    internal class Vivod
    {
        static void Main(string[] args)
        {
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            Vector3D multipliedVector = vector1.MultiplyByScalar(2);
            Vector3D addedVector = vector1.Add(vector2);
            Vector3D subtractedVector = vector1.Subtract(vector2);

            Console.WriteLine("Multiplied vector: ({0}, {1}, {2})", multipliedVector.X, multipliedVector.Y, multipliedVector.Z);
            Console.WriteLine("Added vector: ({0}, {1}, {2})", addedVector.X, addedVector.Y, addedVector.Z);
            Console.WriteLine("Subtracted vector: ({0}, {1}, {2})", subtractedVector.X, subtractedVector.Y, subtractedVector.Z);

            DecimalNumber decimalNumber = new DecimalNumber(42);

            Console.WriteLine("Binary representation: {0}", decimalNumber.ToBinary());
            Console.WriteLine("Octal representation: {0}", decimalNumber.ToOctal());
            Console.WriteLine("Hexadecimal representation: {0}", decimalNumber.ToHexadecimal());

            RGBColor color = new RGBColor(255, 0, 0);

            Console.WriteLine("Hex representation of RGB color: {0}", color.ToHex());

            Console.ReadLine();
        }
    }
}
