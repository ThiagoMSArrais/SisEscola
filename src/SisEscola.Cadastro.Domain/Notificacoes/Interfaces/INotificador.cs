using System.Collections.Generic;

namespace SisEscola.Cadastro.Domain.Notificacoes.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
