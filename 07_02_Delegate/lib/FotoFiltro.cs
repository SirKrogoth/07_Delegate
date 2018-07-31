using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_Delegate.lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            //Algoritmo para colorir
            Console.WriteLine("FotoFiltro > Colorir: " + foto.nome);
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("FotoFiltro > GerarThumb: " + foto.nome);
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.nome);
        }

        public void RedimensionarTamMedio(Foto foto)
        {
            Console.WriteLine("FotoFiltro > RedimensionarTamMedio: " + foto.nome);
        }
    }
}
