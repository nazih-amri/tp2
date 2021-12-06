using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Droit
    {
        Point p1; // debut
        Point p2; // arrive
        public double vx { get; set; } 
        public double vy { get; set; }
        public double vz { get; set; }

        /// <summary>
        /// Constructeur de la class Droite qui contint deux points
        /// </summary>
        /// <param name="p1">point de debut du droite</param>
        /// <param name="p2">point d'arrive du droite</param>
        public Droit(Point p1,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            vx = this.p2.x - this.p1.x;
            vy = this.p2.y - this.p1.y;
            vz = this.p2.z - this.p1.z;
        }

        /// <summary>
        /// methode qui fait une translation de la droite
        /// </summary>
        /// <param name="x">valeur ajouter pour x</param>
        /// <param name="y">valeur ajouter pour y</param>
        /// <param name="z">valeur ajouter pour z</param>
        public void Translate(double x,double y,double z)
        {
            p1.Translate(x, y, z);
            p2.Translate(x, y, z);
        }

        /// <summary>
        /// methode qui test si 2 droites parralels ou non
        /// </summary>
        /// <param name="d">droite qu'on va tester avec droite courant</param>
        /// <returns></returns>
        public bool Parallelisme(Droit d)
        {
            double r = (((d.vy * this.vz) - (d.vz * this.vy)) - ((d.vx * this.vz) - (d.vz * this.vx)) + ((d.vx * this.vy) - (d.vy * this.vx)));
            if (r == 0)
                return true;
            return false;
        }

        /// <summary>
        /// methode qui fait un test si un point est appartenir a un droite ou non
        /// </summary>
        /// <param name="p">point qu'on va tester</param>
        /// <returns>return true si le point est appartenir, return false sinon</returns>
        public bool Appartenance(Point p)
        {
            double r = (p.x - p1.x) / vx;
            if (r == (p.y - p1.y) / vy && r == (p.z - p1.z) / vz)
                return true;
            return false;
        }


    }
}
