﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using HMunozS7.Models; 

namespace HMunozS7.Droid
{
    public class ClienteAndroid : DataBase
    {/// <summary>
    /// clase de conexion
    /// </summary>
    /// <returns></returns>
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var BaseDatos = Path.Combine(ruta, "uisrael.db3");
            return new SQLiteAsyncConnection(BaseDatos);
        }
    }
}