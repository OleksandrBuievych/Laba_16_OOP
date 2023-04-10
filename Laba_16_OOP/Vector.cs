using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_16_OOP
{
    class Vector
    {
        // Координати кінців вектору
        private double x;
        private double y;
        private double z;

        // Конструктор для ініціалізації координат
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }

        public Vector(double x)
        {
            this.x = x;
            this.y = 0;
            this.z = 0;
        }

        // Операції додавання та віднімання векторів
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        // Обчислення скалярного добутку двох векторів
        public static double operator *(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        // Обчислення довжини вектора
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        // Обчислення косинуса кута між векторами
        public double CosAngle(Vector v1, Vector v2)
        {
            double dotProduct = v1 * v2;
            double lengthProduct = v1.Length() * v2.Length();
            return dotProduct / lengthProduct;
        }

        public string Show()
        {
            return $"Ви успішно створили вектор ({this.x},{this.y},{this.z})";
        }
        
        public string ShowCoordination()
        {
            return $"({this.x},{this.y},{this.z})";
        }
    }
}
