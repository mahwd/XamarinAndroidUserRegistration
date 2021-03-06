﻿using Android.App;
using Android.Widget;
using Android.OS;
using Hardasaniye.Resources;
using Hardasaniye.Data;
using Hardasaniye.Model;
using static Android.Widget.AdapterView;
using Android.Views;
using System;

namespace Hardasaniye
{
    [Activity(Label = "Hardasaniye", MainLauncher = false, Icon = "@drawable/icon",NoHistory = false)]
    public class MainActivity : Activity, IOnItemClickListener,IOnItemLongClickListener
    {
        private ListViewAdapter _listAdapter { get; set; }
        private ListView _listView { get; set; }
        private Button _btnSend { get; set; }
        private Button _btnUpdate { get; set; }
        EditText edtName { get; set;}
        EditText edtAge { get; set;}
        EditText edtMapRouteName { get; set; }
        EditText edtCount { get; set; }
        private User _user { get; set; }
        private MapRoute _mapRoute { get; set; }
        private User _selectedUser { get; set; }


        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            _selectedUser = GetData.UserList[position];
        }

        public bool OnItemLongClick(AdapterView parent, View view, int position, long id)
        {
            Toast.MakeText(this, "this is long press", ToastLength.Long).Show() ;
            return true;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);
            //edtName = FindViewById<EditText>(Resource.Id.edtName);
            //edtAge = FindViewById<EditText>(Resource.Id.edtAge);
            //edtMapRouteName = FindViewById<EditText>(Resource.Id.edtMapRouteName);
            //edtCount = FindViewById<EditText>(Resource.Id.edtCount);
            //_btnSend = FindViewById<Button>(Resource.Id.btnSend);
            //_btnUpdate = FindViewById<Button>(Resource.Id.btnUpdate);

            //new GetData().Execute(MongoLab.GetAddressAPI());
            //_listAdapter = new ListViewAdapter(this, GetData.UserList);
            //_listView = FindViewById<ListView>(Resource.Id.listUsers);
            //_listView.Adapter = _listAdapter;

            //_listView.OnItemClickListener = this;
            //_listView.OnItemLongClickListener = this;
            //_btnSend.Click += _btnSend_Click;
            //_btnUpdate.Click += _btnUpdate_Click;
        }

        //private void _btnUpdate_Click(object sender, EventArgs e)
        //{
        //    _selectedUser.name = edtName.Text;
        //    _selectedUser.age = int.Parse(edtAge.Text);
        //    //_selectedUser.maproutes.Routename = edtMapRouteName.Text;
        //    //_selectedUser.maproutes.RouteWayPoints = int.Parse(edtCount.Text);

        //    new PutData(_selectedUser).Execute(MongoLab.GetAddressSingle(_selectedUser));
        //}

        //private void _btnSend_Click(object sender, System.EventArgs e)
        //{
        //    //_mapRoute = new MapRoute() { Routename = edtMapRouteName.Text, RouteWayPoints = int.Parse(edtCount.Text) };
        //    //_user = new User() { name = edtName.Text, age = int.Parse(edtAge.Text) , maproutes = _mapRoute};

        //    new PostData(_user).Execute(MongoLab.GetAddressSingle(_user));
        //}
    }
}

