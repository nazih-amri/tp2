using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        /// <summary>
        /// constructeur de la classe Point qui contient les valeurs de x,y et z de la point
        /// </summary>
        public Point(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        /// <summary>
        /// methode qui test si deux point est egale ou non
        /// </summary>
        /// <param name="p">le point qu'on va tester le point courant avec</param>
        /// <returns>return true si les deux points sont egal ou false sinon</returns>
        public bool IsEgal(Point p)
        {
            return (x == p.x && y == p.y && z == p.z);
        }

        /// <summary>
        /// methode qui fait un translation d'un point
        /// </summary>
        /// <param name="a">la valeur ajouter pour x</param>
        /// <param name="b">la valeur ajouter pour y</param>
        /// <param name="c">la valeur ajouter pour z</param>
        public void Translate(double a,double b,double c)
        {
            x += a;
            y += b;
            z += c;
        }


    }
}
