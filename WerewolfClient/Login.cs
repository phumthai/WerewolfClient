﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class Login : Form, View
    {
        private WerewolfController controller;
        private Form _mainForm;
        public Login(Form MainForm)
        {
            InitializeComponent();
            _mainForm = MainForm;
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel)
            {
                WerewolfModel wm = (WerewolfModel)m;
                switch (wm.Event)
                {
                    case WerewolfModel.EventEnum.SignIn:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            _mainForm.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case WerewolfModel.EventEnum.SignUp:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            MessageBox.Show("Sign up successfuly, please login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            WerewolfCommand wcmd = new WerewolfCommand();
            wcmd.Action = WerewolfCommand.CommandEnum.SignIn;
            wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", TBServer.Text } };
            controller.ActionPerformed(wcmd);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            WerewolfCommand wcmd = new WerewolfCommand();
            wcmd.Action = WerewolfCommand.CommandEnum.SignUp;
            wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text}, { "Password",TbPassword.Text}, { "Server", TBServer.Text } };
            if (TbLogin.Text == "" || TbPassword.Text == "")
            {
                MessageBox.Show("จงเติมคำในช่องว่าง","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                controller.ActionPerformed(wcmd);
            }
        }

        private void server_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(server.Text == "User server")
            {
                TBServer.Text = "http://localhost:2343/werewolf/";
            }
            else if(server.Text == "2 Player")
            {
                TBServer.Text = "http://project-ile.net:2342/werewolf/";
            }
            else if (server.Text == "4 Player")
            {
                TBServer.Text = "http://project-ile.net:2344/werewolf/";
            }
            else if (server.Text == "16 Player")
            {
                TBServer.Text = "http://project-ile.net:23416/werewolf/";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tutorial Form1 = new Tutorial();
            Form1.Visible = true;
            Form1.Activate();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
