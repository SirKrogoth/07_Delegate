using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_Delegate.lib
{
    public class Foto
    {
        public string nome { get; private set; }
        public int tamanhoX { get; private set; }
        public int tamanhoY { get; private set; }

        public Foto(string nome, int tamanhoX, int tamanhoY)
        {
            this.nome = nome;
            this.tamanhoX = tamanhoX;
            this.tamanhoY = tamanhoY;
        }

        public void Colorir(Foto foto)
        {
            //Algoritmo para colorir
            Console.WriteLine($"FotoFiltro > Colorir: {foto.nome} | Dimenções > {tamanhoX} > {tamanhoY}");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > GerarThumb: {foto.nome} | Dimenções > {tamanhoX} > {tamanhoY}");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > PretoBranco: {foto.nome} | Dimenções > {tamanhoX} > {tamanhoY}");
        }

        public void RedimensionarTamMedio(Foto foto)
        {
            Console.WriteLine($"FotoFiltro > RedimensionarTamMedio: {foto.nome} | Dimenções > {tamanhoX} > {tamanhoY}");
        }
    }
}
