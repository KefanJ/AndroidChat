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
    class Users
    {

        public int idUser { get; set; }
        public string prenomUser { get; set; }
        public string nomUser { get; set; }
        public int image { get; set; }
        public string login { get; set; }
       
        public string mdp { get; set; }


    }
}