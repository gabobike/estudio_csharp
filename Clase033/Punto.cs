﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase033
{
    class Punto
    {
        public Punto(int x, int y )
        {
            this.x = x;

            this.y = y;
        }

        public Punto()
        {
            this.x = 0;

            this.y = 0;
        }

        public double DistanciaHasta(Punto otroPunto)
        {

            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }

        private int x, y;
    }
}
