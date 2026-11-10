using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace GoodFood;

public class UserLogged
{
    public string Email;
    public int Kcal;
    public static bool isLogged { get { return current != null; } }

    private static UserLogged? current;

    public static UserLogged Current
    {
        get
        {
            current ??= new();
            return current;
        }
    }

    private UserLogged()
    {

    }
}
