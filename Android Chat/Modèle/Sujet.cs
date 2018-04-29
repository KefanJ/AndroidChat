using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace Android_Chat.Modèle
{
    class Sujet
    {
        [JsonProperty("id")]
        public int idSujet { get; set; }
        [JsonProperty("nomSujet")]
        public string nomSujet { get; set; }
        [JsonProperty("idAuteur")]
        public int idAuteur { get; set; }
    }
}