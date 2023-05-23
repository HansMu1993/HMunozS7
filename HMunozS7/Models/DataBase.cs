using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMunozS7.Models
{

    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection(); //defino el metodo de conexion
    }
}
