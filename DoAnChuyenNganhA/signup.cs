using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace DoAnChuyenNganhA
{
    public partial class signup : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FszuRvZPyejVLF3WuuRG7a0rzwRGpXPWrCP3M28y",
            BasePath = "https://doanchuyennganha-test-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public signup()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void lbl_clearfields_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();
            txt_confirmpass.Clear();
        }

        public static string pass;
        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_confirmpass.Text))
            {
                MessageBox.Show("All fields must be filled!");
            }
            else
            {
                 
                if (txt_password.Text == txt_confirmpass.Text)
                {
                    var register = new register
                    {
                        user = txt_user.Text,
                        password = txt_password.Text,
                        confirmPassword = txt_confirmpass.Text
                    };
                    FirebaseResponse response = client.Set("users/" + txt_user.Text, register);
                    register res = response.ResultAs<register>();
                    response = client.Get("users/");
                    Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();
                    foreach (var get in result)
                    {
                        string usernameres = get.Value.user;
                        string passwordres = get.Value.password;
                        if (txt_user.Text == usernameres && txt_password.Text == passwordres)
                       {
                           MessageBox.Show("Username is already exists");
                           new login().Show();
                           this.Hide();
                        }
                    }

                    MessageBox.Show("Sign Up successed");
                    new login().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The password and confirm password is not the same");
                    txt_user.Clear();
                    txt_password.Clear();
                    txt_confirmpass.Clear();
                }
            }

            /*if(txt_password.Text == txt_confirmpass.Text)
            {
                new login().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The password and confirm password is not the same");
                txt_user.Clear();
                txt_password.Clear();
                txt_confirmpass.Clear();
            }*/
        }

        private void signup_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //lbl_clearfields.Text = "connected";
            }
        }
    }
}
