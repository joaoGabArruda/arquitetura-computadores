// usado como base para desserializar o JSON importado

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models
{
    public class AlertaModel
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "occurrences")]
        public int? Occurrences { get; set; }

        [JsonProperty(PropertyName = "machineLinearTime")]
        public int? MachineLinearTime { get; set; }

        [JsonProperty(PropertyName = "bus")]
        public int? Bus { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }

        [JsonProperty(PropertyName = "location")]
        public Location? Location { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string? Color { get; set; }

        [JsonProperty(PropertyName = "severity")]
        public string? Severity { get; set; }

        [JsonProperty(PropertyName = "acknowledgementStatus")]
        public string? AcknowledgementStatus { get; set; }

        [JsonProperty(PropertyName = "ignored")]
        public bool? Ignored { get; set; }

        [JsonProperty(PropertyName = "invisible")]
        public bool? Invisible { get; set; }
    }
    public class Duration
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "valueAsInteger")]
        public int? ValueAsInteger { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string? Unit { get; set; }
    }

    public class EngineHours
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "reading")]
        public Reading? Reading { get; set; }
    }

    public class Reading
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "valueAsDouble")]
        public double? ValueAsDouble { get; set; }

        [JsonProperty(PropertyName = "unit")]
        public string? Unit { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Link? Link { get; set; }
    }


    public class Definition
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "suspectParameterName")]
        public int? SuspectParameterName { get; set; }

        [JsonProperty(PropertyName = "failureModeIndicator")]
        public int? FailureModeIndicator { get; set; }

        [JsonProperty(PropertyName = "bus")]
        public int? Bus { get; set; }

        [JsonProperty(PropertyName = "sourceAddress")]
        public int? SourceAddress { get; set; }

        [JsonProperty(PropertyName = "threeLetterAcronym")]
        public string? ThreeLetterAcronym { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Link? Link { get; set; }
    }

    public class Link
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "rel")]
        public string? Rel { get; set; }

        [JsonProperty(PropertyName = "uri")]
        public Uri? Uri { get; set; }
    }

    public class Location
    {
        [JsonProperty(PropertyName = "@type")]
        public string? Type { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public double? Lat { get; set; }

        [JsonProperty(PropertyName = "lon")]
        public double? Lon { get; set; }
    }
}