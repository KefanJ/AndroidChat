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
    class message
    {
        [JsonProperty("idMess")]
        public int idMessage { get; set; }

        [JsonProperty("texte")]
        public string textMessage { get; set; }

        public int idSujet { get; set; }

        [JsonProperty("idAuteur")]
        public int idAuteur { get; set; }
    }
}