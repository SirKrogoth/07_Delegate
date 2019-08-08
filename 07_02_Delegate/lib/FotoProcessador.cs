using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_Delegate.lib
{
    public class FotoProcessador
    {
        public delegate void FotoFiltroHandler(Foto foto);

        public FotoFiltroHandler filtros;
        
        public void Processar(Foto foto)
        {
            //irá executar o método conforme a chamado que está dentro da classe Foto. 
            filtros(foto);
        }
    }
}
