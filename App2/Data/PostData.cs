using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Hardasaniye.Model;
using Newtonsoft.Json;
using System;

namespace Hardasaniye.Data
{
    public class PostData : AsyncTask<string, Java.Lang.Void, string>
    {
        private ProgressDialog _pd = new ProgressDialog(Application.Context);
        private User _user { get; set; }


        protected override void OnPreExecute()
        {
            base.OnPreExecute();
            _pd.Window.SetType(WindowManagerTypes.SystemAlert);
            _pd.SetTitle("Sebrli ol... ");
            _pd.Show();
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
            catch (Exception ex)
            {
                Toast.MakeText(Application.Context, $"{ex.Message}", ToastLength.Long).Show();
            }
            http.PostHTTPData(urlString, json);
            return String.Empty;
        }
        protected override void OnPostExecute(string result)
        {
            base.OnPostExecute(result);
            new GetData().Execute(MongoLab.GetAddressAPI());
            _pd.Dismiss();
        }

        public PostData(User user)
        {
            this._user = user;
        }
    }

}