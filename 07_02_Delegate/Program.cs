using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_02_Delegate.lib;

namespace _07_02_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tela de cadastro de usuário: Thumb
            Foto foto1 = new Foto() { nome = "Cadastro.jpg", tamanhoX = 1920, tamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto1);

            //Cadastro de Produtos: Colorir + TamanhoMed
            Foto foto2 = new Foto() { nome = "Produto.jpg", tamanhoX = 1920, tamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros = new FotoFiltro().RedimensionarTamMedio;
            FotoProcessador.Processar(foto2);

            //Cadastro de album do usuário: Preto e branco
            Foto foto3 = new Foto() { nome = "Album.jpg", tamanhoX = 1920, tamanhoY = 1080 };
            FotoProcessador.filtros = new FotoFiltro().PretoBranco;            
            FotoProcessador.Processar(foto3);

            Console.ReadKey();
        }
    }
}
