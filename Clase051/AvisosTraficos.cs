using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase051
{
    class AvisosTraficos : IAvisos
    {
        public AvisosTraficos()
        {
            remitente = "DGT";

            mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará de un reducción en la sanción ";

            fecha = "";
        }

        public AvisosTraficos(string remitente, string mensaje , string fecha)
        {
            this.remitente = remitente; // el this siempre se refiere a la clase

            this.mensaje = mensaje;

            this.fecha = fecha;
        }
        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2} ", mensaje, remitente, fecha);
        }

        private string remitente;

        private string mensaje;

        private string fecha;
    }
}
