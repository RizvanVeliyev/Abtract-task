using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public abstract void ShowInfo();
    }
}
