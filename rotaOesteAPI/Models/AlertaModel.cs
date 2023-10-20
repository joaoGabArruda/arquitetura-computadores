using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rotaOesteAPI.Models
{
    public class AlertaModel
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("occurrences")]
        public int? Occurrences { get; set; }

        [JsonPropertyName("machineLinearTime")]
        public int? MachineLinearTime { get; set; }

        [JsonPropertyName("bus")]
        public int? Bus { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("time")]
        public DateTime? Time { get; set; }

        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("severity")]
        public string? Severity { get; set; }

        [JsonPropertyName("acknowledgementStatus")]
        public string? AcknowledgementStatus { get; set; }

        [JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        [JsonPropertyName("invisible")]
        public bool? Invisible { get; set; }
    }

    public class Duration
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("valueAsInteger")]
        public int? ValueAsInteger { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }
    }

    public class EngineHours
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("reading")]
        public Reading? Reading { get; set; }
    }

    public class Reading
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("valueAsDouble")]
        public double? ValueAsDouble { get; set; }

        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        [JsonPropertyName("links")]
        public Link? Link { get; set; }
    }

    public class Definition
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("suspectParameterName")]
        public int? SuspectParameterName { get; set; }

        [JsonPropertyName("failureModeIndicator")]
        public int? FailureModeIndicator { get; set; }

        [JsonPropertyName("bus")]
        public int? Bus { get; set; }

        [JsonPropertyName("sourceAddress")]
        public int? SourceAddress { get; set; }

        [JsonPropertyName("threeLetterAcronym")]
        public string? ThreeLetterAcronym { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("links")]
        public Link? Link { get; set; }
    }
    
    public class Link
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("rel")]
        public string? Rel { get; set; }

        [JsonPropertyName("uri")]
        public Uri? Uri { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("@type")]
        public string? Type { get; set; }

        [JsonPropertyName("lat")]
        public double? Lat { get; set; }

        [JsonPropertyName("lon")]
        public double? Lon { get; set; }
    }
}