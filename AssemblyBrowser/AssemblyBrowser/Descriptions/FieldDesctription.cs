using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AssemblyBrowser
{
    public class FieldDesctription
    {
        [JsonInclude]
        [JsonPropertyName("")]
        public string Name { get; internal set; }

    }
}
