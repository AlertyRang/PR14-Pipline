using System;
using System.Collections.Generic;

public partial class User
{
    public User(string nameUser, string loginUser, string passwordUser, string mailUser)
    {
        NameUser = nameUser;
        LoginUser = loginUser;
        PasswordUser = passwordUser;
        MailUser = mailUser;
    }

    public User(int idUser, string nameUser, string loginUser, string passwordUser, string mailUser)
    {
        IdUser = idUser;
        NameUser = nameUser;
        LoginUser = loginUser;
        PasswordUser = passwordUser;
        MailUser = mailUser;
    }

    public int IdUser { get; set; }

    public string NameUser { get; set; }

    public string LoginUser { get; set; }

    public string PasswordUser { get; set; }

    public string MailUser { get; set; }
}
