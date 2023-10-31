using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rotaOesteAPI.DTO
{
    public class ResponseModelTraduzido
    {
        public string? Tipo { get; set; }

        public int? Ocorrencias { get; set; }

        public int? TempoLinearMaquina { get; set; }

        public int? Bus { get; set; }

        public int? Id { get; set; }

        public DateTime? Tempo { get; set; }

        public Location? Localizacao { get; set; }

        public string? Cor { get; set; }

        public string? Gravidade { get; set; }

        public string? StatusDeConhecimento { get; set; }

        public bool? Ignorado { get; set; }

        public bool? Invisivel { get; set; }
    }

    public class Duration
    {
        public string? Tipo { get; set; }

        public int? ValorInteiro { get; set; }

        public string? Unidade { get; set; }
    }

    public class EngineHours
    {
        public string? Tipo { get; set; }

        public Reading? Leitura { get; set; }
    }

    public class Reading
    {
        public string? Tipo { get; set; }

        public double? ValorDouble { get; set; }

        public string? Unidade { get; set; }

        public Link? Link { get; set; }
    }

    public class Definition
    {
        public string? Tipo { get; set; }

        public int? NameParametrosSuspeitos { get; set; }

        public int? IndicadorFalha { get; set; }

        public int? Bus { get; set; }

        public int? OrigemEndereco { get; set; }

        public string? AcronimoTresLetras { get; set; }

        public int? Id { get; set; }

        public string? Descricao { get; set; }

        public Link? Link { get; set; }
    }
    
    public class Link
    {
        public string? Tipo { get; set; }

        public string? Rel { get; set; }

        public Uri? Uri { get; set; }
    }

    public class Location
    {
        public string? Tipo { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}