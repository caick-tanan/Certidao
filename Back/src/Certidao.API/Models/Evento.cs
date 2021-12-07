namespace Certidao.API.Models
{
    public class Evento
    {
        public int EventoId {get; set;}

        public string Nome {get; set;}

        public string Cpf {get; set;}

        public string EstadoCivil {get; set;}

        public string Sexo {get; set;}

        public string DataDoObito {get; set;}

        public string ImageURL {get; set;}
    }
}