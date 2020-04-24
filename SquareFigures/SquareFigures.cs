using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigures
{
    /// <summary>
    /// Класс расчета площадей фигур
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Число Пи
        /// </summary>
        private const double pi = Math.PI;
        /// <summary>
        /// Полупериметр
        /// </summary>
        private double pp;
        /// <summary>
        /// Полупериметр. Только для чтения
        /// </summary>
        public double Pp
        {
            get { return pp; }
        }
        /// <summary>
        /// Площадь
        /// </summary>
        private double S;
        /// <summary>
        /// Площадь. Только для чтения
        /// </summary>
        public double s
        {
            get { return S; }
        }

        /// <summary>
        /// Площадь круга через ее радиус
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns></returns>
        public double Circle(double r)
        {
            if (r < 0) r *= -1;
            return S=pi * Math.Pow(r, 2);
        }
        /// <summary>
        /// Площадь треугольника по формуле Герона
        /// </summary>
        /// <param name="a">длина треугольника</param>
        /// <param name="b">длина треугольника</param>
        /// <param name="c">длина треугольника</param>
        /// <returns></returns>
        public double Treangle(double a, double b, double c)
        {
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;
            if (c < 0) b *= -1;
            pp = (a + b + c) / 2;
            return S= Math.Round(Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c)), 3);
        }
        /// <summary>
        /// Проверяет, является ли треугольник равнобедренным.
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns></returns>
        public bool Equal(double a, double b, double c)
        {
            //Если число отрицательное, чего быть не должно, оно станет положительным.
            //Стоит ли выбрасывать ошибку, при введении отрицательных чисел?
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;
            if (c < 0) b *= -1;
            if (a == b || b == c || a == c)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Площадь квадрата
        /// </summary>
        /// <param name="a">сторона</param>
        /// <returns></returns>
        public double Squdre (double a)
        {
            return S=a * a;
        }
        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="a">Сторона прямоугольника</param>
        /// <param name="b">Сторона прямоугольника</param>
        /// <returns></returns>
        public double Rectangle(double a, double b)
        {
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;
            return S = a * b;
        }
        /// <summary>
        /// Сумма площадей фигур.
        /// </summary>
        /// <param name="s1">Первая фигура</param>
        /// <param name="s2">Вторая фигура</param>
        /// <returns></returns>
        public double Figures(Square s1, Square s2)
        {
            //Для расчета сложных фигур, необходимо разбивать их на стандартные.
            //После разбития мы можем посчитать площадь каждой из них и сложить.
            return S=s1.s+s2.s;
        }
    }
}
