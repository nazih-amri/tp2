using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Cercle:Ellipse
    {
        /// <summary>
        /// constructeur de la classe Cercle avec un point centre connu
        /// </summary>
        /// <param name="c">point centre</param>
        /// <param name="r">rayon de la cercle</param>
        public Cercle(Point c, double r) : base(c, r, r) { }

        /// <summary>
        /// constructeur de la classe Cercle avec un point centre unconnu
        /// </summary>
        /// <param name="x">la valeur de x du point centre</param>
        /// <param name="y">la valeur de y du point centre</param>
        /// <param name="z">la valeur de z du point centre</param>
        /// <param name="r">rayon de la cercle</param>
        public Cercle(double x,double y,double z,double r) : base(x, y, z, r, r) { }


        /// <summary>
        /// methode qui calcule cerconference de la cercle
        /// </summary>
        /// <returns></returns>
        public double Cerconference()
        {
            double r = 2 * 3.14 * Rx;
            return r;
        }

        /// <summary>
        /// methode qui calcule Surface de la cercle
        /// </summary>
        /// <returns></returns>
        public  double Surface()
        {
            double r = Rx * Rx * 3.14;
            return r;
        }

        
    }
}
