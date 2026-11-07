using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace GoodFood;

public class UserLogged
{
    public string Email;

    public static readonly UserLogged Current = new();
    //private static readonly UserLogged current = new();

    //public static UserLogged Current
    //{
    //    get { return current; }
    //}

    private UserLogged()
    {

    }
}
