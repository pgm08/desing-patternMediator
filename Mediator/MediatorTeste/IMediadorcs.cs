using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTeste
{
    public interface IMediador
    {
        void Comunicar(string mensagem, Colaborador colaborador);
    }
}
