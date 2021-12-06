using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Ellipse
    {
        Point c;
        public double Rx { get; set; }
        public double Ry { get; set; }

        /// <summary>
        /// Constructeur de la class Ellipse avec un point et largeur et longeur comme parametre
        /// </summary>
        /// <param name="c">point centre de l'ellipse</param>
        /// <param name="x">largeur</param>
        /// <param name="y">longeur</param>
        public Ellipse(Point c,double x,double y)
        {
            this.c = c;
            Rx = x;
            Ry = y;
        }

        /// <summary>
        /// un autre constructeur si le point est unconnu
        /// </summary>
        /// <param name="x">valeur de x du point centre</param>
        /// <param name="y">valeur de y du point centre</param>
        /// <param name="z">valeur de z du point centre</param>
        /// <param name="la">largeur</param>
        /// <param name="lo">longeur</param>
        public Ellipse(double x,double y,double z, double la,double lo)
        {
            c = new Point(x, y, z);
            Rx = la;
            Ry = lo;
        }


        /// <summary>
        /// methode qui calcule la circonference d'un ellipse
        /// </summary>
        /// <returns>return la valeur de la circonference</returns>
        public double Circonference()
        {
            double r = 2 * 3.14 * (Math.Sqrt(Math.Pow(2 * Rx, 2) + Math.Pow(2 * Ry, 2)) / 2);
            return r;
        }

        /// <summary>
        /// methode qui calcule la surface d'un ellipse
        /// </summary>
        /// <returns>return la valeur du surface</returns>
        public double Surface()
        {
            double r = 3.14 * Rx * Ry;
            return r;
        }

    }
}
