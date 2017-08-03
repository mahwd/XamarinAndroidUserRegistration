using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using App2.Model;
using App2.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App2.Data
{
    public class GetData : AsyncTask<string, Java.Lang.Void, string>
    {
        private ProgressDialog pd = new ProgressDialog(Application.Context);
        public static List<User> UserList { get; set; }
        public static User _user { get; private set; }
        private string _userName { get; set; }
        private string _userPassword { get; set; }


        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            pd.Window.SetType(WindowManagerTypes.SystemOverlay);
            pd.SetTitle("Data gelirrr...");
            pd.Show();
        }
        protected override string RunInBackground(params string[] @params)
        {
            string stream = null;
            string urlString = @params[0];
            HTTPDataHandler http = new HTTPDataHandler();
            stream = http.GetHTTPData(urlString);
            return stream;
        }

        protected override void OnPostExecute(string result)
        {
            base.OnPostExecute(result);

            try
            {
                UserList = JsonConvert.DeserializeObject<List<User>>(result);
            }
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, $"{ex.StackTrace}", ToastLength.Long).Show();
            }

            pd.Dismiss();
        }
    }
}