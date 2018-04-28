using Android.App;
using Android.Widget;
using Android.OS;
using System.Net;
using System;
using System.Collections.Generic;
using Android_Chat.Modèle;
using Newtonsoft.Json;
using Android.Content;
using Android_Chat.Mes_activites;

namespace Android_Chat
{
    [Activity(Label = "Android_Chat", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnConnexion;
        List<Connexion> lesConnexions;
        EditText Login;
        EditText Mdp;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            WebClient wc = new WebClient();
            Uri url = new Uri("http://" + GetString(Resource.String.app_ip) + "GetAllControleur.php");
            wc.DownloadStringAsync(url);
            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
           

            btnConnexion = FindViewById<Button>(Resource.Id.btnConnexion);
            Login = FindViewById<EditText>(Resource.Id.Login);
            Mdp = FindViewById<EditText>(Resource.Id.Mdp);

            btnConnexion.Click += btnConnexion_Click;
            

        }




        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            lesConnexions = JsonConvert.DeserializeObject<List<Connexion>>(e.Result);
           
        }




        private void btnConnexion_Click(object sender, System.EventArgs e)
        {

            var chekLog = lesConnexions.Find(x => x.Login == Login.Text);
            var chekMdp = lesConnexions.Find(x => x.Mdp == Mdp.Text);

            
            {
                if(chekLog != null &&  chekMdp != null)
                {
                    Toast.MakeText(this, "ok", ToastLength.Short).Show();
                    Intent pageForum = new Intent(this, typeof(PageForum));
                    pageForum.PutExtra("unIdConnexion",chekLog.id);
                    StartActivity(pageForum);
                    
                }
                else
                {
                    Toast.MakeText(this, "Identifiant ou mot de passe incorrect", ToastLength.Short).Show();
                }
            }
        }


        
    }
}

