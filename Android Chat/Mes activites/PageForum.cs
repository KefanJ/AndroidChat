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
using Android_Chat.Modèle;

namespace Android_Chat.Mes_activites
{
    [Activity(Label = "pageForum")]
    public class PageForum : Activity
    {
        Database db;
        Button btnSaboner;
        Button btnNvSujet;
        ListView lstSujet;
        List<Sujet> lesSujets;
        int idUser;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            btnNvSujet = FindViewById<Button>(Resource.Id.btnNvSujet);
            btnSaboner = FindViewById<Button>(Resource.Id.btnAbonner);
            lstSujet = FindViewById<ListView>(Resource.Id.lstSujet);


        }
    }
}