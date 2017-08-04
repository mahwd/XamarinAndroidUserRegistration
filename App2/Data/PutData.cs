using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using Hardasaniye.Model;

namespace Hardasaniye.Data
{
    public class PutData : AsyncTask<string, Java.Lang.Void, string>
    {
        private User _user { get; set; }

        protected override void OnPreExecute()
        {
            base.OnPreExecute();
        }
        protected override void OnPostExecute(string result)
        {
            base.OnPostExecute(result);
            new GetData().Execute(MongoLab.GetAddressAPI());
        }
        protected override string RunInBackground(params string[] @params)
        {
            string urlString = @params[0];
            HTTPDataHandler http = new HTTPDataHandler();
            string json = "";

            try
            {
                json = JsonConvert.SerializeObject(_user);
            }
            catch (Java.Lang.Exception ex)
            {
                Toast.MakeText(Application.Context, $"{ex.Message}", ToastLength.Long).Show();
            }

            http.PutHTTPData(urlString, json);
            return String.Empty;
        }

        public PutData(User user)
        {
            _user = user;
        }
    }
}