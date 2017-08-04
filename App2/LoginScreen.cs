using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Hardasaniye.Resources;
using Android.Content.PM;
using Hardasaniye.Model;

namespace Hardasaniye
{
    [Activity(Label = "Hardasan iye", Icon = "@drawable/MapIcon", ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true,NoHistory = true)]
    public class LoginScreen : Activity
    {
        public static LoginScreen loginScreen { get; set; }
        private Button mBtnLogIn { get; set; }
        private Button mBtnSignUp { get; set; }
        private ProgressBar mProgressBar { get; set; }
        public LinearLayout _layout { get; set; }
        public static User _user { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            loginScreen = this;

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);
            mBtnLogIn = FindViewById<Button>(Resource.Id.btnSignIn);
            mProgressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);


            mBtnSignUp.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");
            };

            mBtnLogIn.Click += (object sender, EventArgs args) =>
            {
                //Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_Login logInDialog = new dialog_Login();
                 logInDialog.Show(transaction, "dialog fragment");
            };
        }
    }
}