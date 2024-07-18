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
using FireSharp.Response;
using FireSharp.Interfaces;

namespace DoAnChuyenNganhA
{
    public partial class login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "FszuRvZPyejVLF3WuuRG7a0rzwRGpXPWrCP3M28y",
            BasePath = "https://doanchuyennganha-test-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Fields must be filled!");
            }
            else
            {
                FirebaseResponse response = client.Get("users/");
                Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();
                foreach(var get in result)
                {
                    string usernameres = get.Value.user;
                    string passwordres = get.Value.password;
                    if(txt_user.Text == usernameres && txt_password.Text==passwordres)
                    {
                        //usernameres = txt_user.Text;
                        //passwordres = txt_password.Text;
                        this.Hide();
                        Test2 dt = new Test2();
                        dt.ShowDialog();
                        
                    }
                    /*if(txt_user.Text != usernameres || txt_password.Text != passwordres)
                    {
                        MessageBox.Show("The user name or password is not incorrected");
                        txt_user.Clear();
                        txt_password.Clear();
                        txt_user.Focus();
                    }*/
                }
                //if(!result.ContainsKey("user") && !result.ContainsKey("password"))
                //{
                //    FirebaseResponse response2 = client.Get("users_admin/");
                //    Dictionary<string, register> result2 = response2.ResultAs<Dictionary<string, register>>();
                //    foreach (var get in result2)
                //    {
                //        string usernameres = get.Value.user;
                //        string passwordres = get.Value.password;
                //        if (txt_user.Text == usernameres && txt_password.Text == passwordres)
                //        {
                //            usernameres = txt_user.Text;
                //            passwordres = txt_password.Text;
                //            this.Hide();
                //            database_admin dt = new database_admin();
                //            dt.ShowDialog();

                //        }
                //    }                  
                //}

                register res = response.ResultAs<register>();
                register user = new register()
                {
                    user = txt_user.Text,
                    password = txt_password.Text
                };
                if(register.IsEqual(res, user))
                {
                    database_admin dt = new database_admin();
                    this.Hide();
                    dt.ShowDialog();
                }
                else
                {
                    register.showError();
                }
            }

            /* if (txt_user.Text == " " && txt_password.Text == "")
             {
                 new database().Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("The user name or password is incorrect");
                 txt_user.Clear();
                 txt_password.Clear();
                 txt_user.Focus();
             }*/
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void lbl_clearfields_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();
            txt_user.Focus();
        }

        private void checkbx_hidepass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbx_hidepass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else { txt_password.UseSystemPasswordChar = true; }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                //lbl_clearfields.Text = "connected";
            }
        }
    }
}
