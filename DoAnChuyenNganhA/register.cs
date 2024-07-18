using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnChuyenNganhA
{
    public class register
    {
        public register()
        {

        }

        public register(string username, string pass, string confirmPass)
        {
            user = username;
            password = pass;
            confirmPassword = confirmPass;
        }

        public string user { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        private static string error="...";
        public static void showError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(register res1, register res2)
        {
            if(res1 == null || res2 == null) { return false; }
            if(res1.user != res2.user)
            {
                error = "Username does not exist!";
                return false;
            }
            else if(res1.password != res2.password && res1.user == res2.user)
            {
                error = "Username or password does not match!";
                return false;
            }

            return true;
        }
    }
}
