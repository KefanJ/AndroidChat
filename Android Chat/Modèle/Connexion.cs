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
    class Connexion
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("mdp")]
        public string Mdp { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("nom")]
        public string nom { get; set; }


        [JsonProperty("prenom")]
        public string prenom { get; set; }



    }
}