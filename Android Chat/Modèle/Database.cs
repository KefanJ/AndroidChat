using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace Android_Chat.Modèle
{
    class Database
    {
        private string dossier = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        private SQLiteConnection db;

       
        public Database()

        {
            db = new SQLiteConnection(Path.Combine(dossier, "AndroidChat.db"));
            if (File.Exists(Path.Combine(dossier, "AndroidChat.db")) == false)
            {
                db.CreateTable<Users>();
                db.CreateTable<Sujet>();
                db.CreateTable<message>();
                db.CreateTable<Abonnement>();

            }

            db.CreateTable<Users>();
            db.CreateTable<Sujet>();
            db.CreateTable<message>();
            db.CreateTable<Abonnement>();
        }



        public Sujet getSujetByName(string name)
        {
            return db.Find<Sujet>(s => s.nomSujet == name);
        }
     

        public void addUser(Users u)
        {
            db.Insert(u);
        }

        

        public List<Users> getAllUsers()
        {
            return db.Table<Users>().ToList<Users>();
        }

     


    }


}