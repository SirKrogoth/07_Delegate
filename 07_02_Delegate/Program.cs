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
            FotoProcessador fotoProcessador = new FotoProcessador();

            //Tela de cadastro de usuário: Thumb
            Foto foto1 = new Foto("CadastroUsuario.jpg", 1920, 1080);

            fotoProcessador.filtros = foto1.GerarThumb;
            fotoProcessador.Processar(foto1);

            //Cadastro de Produtos: Colorir + TamanhoMed
            Foto foto2 = new Foto("Produto.jpg", 1024, 768);

            fotoProcessador.filtros = foto2.Colorir;
            fotoProcessador.Processar(foto2);

            //Cadastro de album do usuário: Preto e branco
            Foto foto3 = new Foto("Album.jpg", 1920, 10820);

            fotoProcessador.filtros = foto3.PretoBranco;
            fotoProcessador.Processar(foto3);

            Console.ReadKey();
        }
    }
}
