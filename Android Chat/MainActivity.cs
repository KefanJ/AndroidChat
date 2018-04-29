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
using static Android.Media.TV.TvContract.Channels;

namespace Android_Chat
{
    [Activity(Label = "Android_Chat", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnConnexion;
        
        EditText login;
        EditText mdp;
        private List<Users> lesUsers;
        private Database db;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Users u3 = new Users() { idUser = 3, login = "Toto", nomUser = "Start", mdp = "ts", prenomUser = "Asta", image = 3 };
            Users u4 = new Users() { idUser = 4, login = "Lola", nomUser = "Lola", mdp = "ll", prenomUser = "Noelle", image = 4 };

            db = new Database();
            if (db.getAllUsers().Count == 0)
            {
               
                db.addUser(u3);
                db.addUser(u4);
            }


            btnConnexion = FindViewById<Button>(Resource.Id.btnConnexion);
            login = FindViewById<EditText>(Resource.Id.Login);
            mdp = FindViewById<EditText>(Resource.Id.Mdp);

            btnConnexion.Click += btnConnexion_Click;
            

        }



        private void btnConnexion_Click(object sender, System.EventArgs e)
        {
            lesUsers = db.getAllUsers();
            var chekLog = lesUsers.Find(x => x.login == login.Text);
            var chekMdp = lesUsers.Find(x => x.mdp == mdp.Text);


            
            {
                if(chekLog != null &&  chekMdp != null)
                {
                    Toast.MakeText(this, "ok", ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(PageForum));
                    intent.PutExtra("idUser",chekLog.idUser);
                    StartActivity(Intent);
                    
                }
                else
                {
                    Toast.MakeText(this, "Identifiant ou mot de passe incorrect", ToastLength.Short).Show();
                }
            }
        }


        
    }
}

