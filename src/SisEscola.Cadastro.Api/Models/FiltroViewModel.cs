namespace SisEscola.Cadastro.Api.Models
{
    public enum TipoFiltroViewModel
    {
        Nome = 1,
        Segmento = 2
    }

    public class FiltroViewModel
    {
        public TipoFiltroViewModel TipoFiltro { get; set; }
        public string Consulta { get; set; }
    }
}
