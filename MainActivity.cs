using System;
using Android;
using Android.App;
using Android.OS;
using Android.Widget;

namespace MyApp
{
    public class Item
    {
        public string Item_name, Location1, Location2;

        public Item(string N, string L2, string L1 = "")
        {
            Item_name = N;
            Location1 = L1;
            Location2 = L2;
        }
        int Check(string Key)
        {
            if (Location1.Contains(Key))
            {
                return 1;
            }
            return 0;
        }
        void Update(string N, string L2, string L1 = "")
        {
            Item_name = N;
            Location1 = L1;
            Location2 = L2;
        }

        string GetLocation()
        {
            string a;
            a = Location1 + " " + Location2;
            return a;
        }

    }

    [Activity(Label = "MyApp", MainLauncher = true)]

    public class MainActivity : Activity
    {
        protected void Save_Item()
        {
            Item NewItem = new Item("Name","Location", "Location");


        }


        private EditText FindViewById(object input1)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource

        }



    }
}


