using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMyCosmetics
{
    [Activity(Label = "AddProduct", Theme = "@style/AppTheme")]
    public class AddProduct : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here

            SetContentView(Resource.Layout.activity_addproducts);


            Button buttonTopLeft = FindViewById<Button>(Resource.Id.buttonTopLeft);
            buttonTopLeft.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(AddProduct));
                StartActivity(intent);
            };

        }
    }
    }