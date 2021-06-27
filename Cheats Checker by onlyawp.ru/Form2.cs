using HtmlAgilityPack;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Cheats_Checker_by_onlyawp.ru
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimazelabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void loginbutton_Click(object sender, EventArgs e)
        {
            string login = login_textbox.Text;
            string password = password_textbox.Text;
            if(login == "" || password == "")
            {
                MessageBox.Show("Вы не указали логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string result = AuthUser(login, password);
            System.Text.RegularExpressions.Regex rx = new System.Text.RegularExpressions.Regex("<[^>]*>");
            result = rx.Replace(result, "");
            Console.WriteLine(result);
            if (result == "reset_page();")
            {
                this.Hide();
                //Form mainform = new mainform(login); - если первая форма нужна
                Form mainform = new mainform();
                mainform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    result, 
                    "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        static string AuthUser(string loginget, string passwordget)
        {
            var url = "https://onlyawp.ru/ajax/actions.php";
            var login = Uri.EscapeUriString(loginget);
            var password = Uri.EscapeUriString(passwordget);
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.UserAgent = "Mozilla 4.0";
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.Referer = "cheatschecker";
            var data = $"phpaction=1&user_login=1&login={login}&password={password}&token=6a0152eaf4830494389a9b88f24fdf51";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                return result;
            }


        }
    }
}
