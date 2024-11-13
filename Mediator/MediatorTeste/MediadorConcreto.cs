using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTeste
{
    public class MediadorConcreto : IMediador
    {
        private ColaboradorA colaboradorA;
        private ColaboradorB colaboradorB;

        // Registrando os colaboradores no mediador
        public void SetColaboradorA(ColaboradorA colaboradorA)
        {
            this.colaboradorA = colaboradorA;
        }

        public void SetColaboradorB(ColaboradorB colaboradorB)
        {
            this.colaboradorB = colaboradorB;
        }

        public void Comunicar(string mensagem, Colaborador colaborador)
        {
            if (colaborador == colaboradorA)
            {
                colaboradorB.ReceberMensagem(mensagem);
            }
            else
            {
                colaboradorA.ReceberMensagem(mensagem);
            }
        }
    }
}
