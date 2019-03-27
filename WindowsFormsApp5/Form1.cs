using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Github Issue
        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            var basicAuth = new Credentials("username", "password"); // NOTE: not real credentials
            client.Credentials = basicAuth;
            var createIssue = new NewIssue("this thing doesn't work");
            createIssue.Body = "سلام";
            createIssue.Labels.Add("bug");
            createIssue.Labels.Add("wontfix");
            createIssue.Labels.Add("Mahdi");
            var issue = await client.Issue.Create("ghost1372", "WindowsFormsApp5", createIssue);

        }
    }
}
