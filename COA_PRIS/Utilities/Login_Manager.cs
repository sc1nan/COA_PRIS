﻿using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COA_PRIS.Utilities
{
    internal class Login_Manager
    {
        private Database_Manager db_Manager;
        private Encryption_Manager encryption_Manger;
        public bool Authenricate(string username, string password)
        {
            encryption_Manger = new Encryption_Manager();
            db_Manager = new Database_Manager();

            string hash_pass;
            int user_exist;

            using (db_Manager)
            {
                 user_exist = Convert.ToInt32(db_Manager.ExecuteScalar(string.Format(Database_Query.get_acc, username)));
            }

            if (user_exist == 1) 
            { 
                using (db_Manager)
                {
                    hash_pass = db_Manager.ExecuteScalar(string.Format(Database_Query.get_pass, username)).ToString();
                }
                if (encryption_Manger.VerifyPassword(hash_pass, password)) 
                    return true;
                else 
                    return false;
            }
            else
            {
                return false;
            }

        }

    }
}
