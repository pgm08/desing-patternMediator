using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorTeste
{
    public abstract class Colaborador
    {
        protected IMediador mediador;

        public Colaborador(IMediador mediador)
        {
            this.mediador = mediador;
        }

        public abstract void EnviarMensagem(string mensagem);
        public abstract void ReceberMensagem(string mensagem);
    }

    public class ColaboradorA : Colaborador
    {
        public ColaboradorA(IMediador mediador) : base(mediador) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine("Colaborador A enviando mensagem: " + mensagem);
            mediador.Comunicar(mensagem, this);
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine("Colaborador A recebeu mensagem: " + mensagem);
        }
    }

    public class ColaboradorB : Colaborador
    {
        public ColaboradorB(IMediador mediador) : base(mediador) { }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine("Colaborador B enviando mensagem: " + mensagem);
            mediador.Comunicar(mensagem, this);
        }

        public override void ReceberMensagem(string mensagem)
        {
            Console.WriteLine("Colaborador B recebeu mensagem: " + mensagem);
        }
    }
}
