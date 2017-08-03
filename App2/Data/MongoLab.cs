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
using App2.Model;

namespace App2.Data
{
    public class MongoLab
    {
        private static string dbName = "mapdb";
        private static string collectionName = "user";
        private static string apiKey = "t4-O8eFHO055sa-IDjU1VVDR60OFTmt9";

        public static string GetAddressSingle(User _user)
        {
            String baseUrl = $"https://api.mlab.com/api/1/databases/{ dbName}/collections/{collectionName}";
            StringBuilder stringBuilder = new StringBuilder(baseUrl);
            stringBuilder.Append($"/{_user._id.id}?apiKey={apiKey}");
            return stringBuilder.ToString();
        }

        public static string GetAddressAPI()
        {
            String baseUrl = $"https://api.mlab.com/api/1/databases/{dbName}/collections/{collectionName}";
            StringBuilder stringBuilder = new StringBuilder(baseUrl);
            stringBuilder.Append($"?apiKey={apiKey}");
            return stringBuilder.ToString();
        }
        public static string SelectWithQuery(string query)
        {
            String baseUrl = $"https://api.mlab.com/api/1/databases/{dbName}/collections/{collectionName}";
            StringBuilder stringBuilder = new StringBuilder(baseUrl);
            stringBuilder.Append($"/?apiKey={apiKey}");
            stringBuilder.Append(query);
            return stringBuilder.ToString();
        }
    }
}