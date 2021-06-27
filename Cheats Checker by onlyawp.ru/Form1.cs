using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;

namespace Cheats_Checker_by_onlyawp.ru
{
    public partial class mainform : Form
    {
        public mainform()
        {
            MessageBox.Show("Привет, ничего не трогай в течении 3-4 секунд.\nОткроется пару папок, не пугайся.", "Соглашение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.CreateDirectory("files");
            File.Delete($@"{Directory.GetCurrentDirectory()}\files\accounts.txt");
            takeScreenShot("onrun.png");
            Process.Start("explorer", Environment.GetEnvironmentVariable("TEMP"));
            Thread.Sleep(1000);
            takeScreenShot("disk_c.png");
            Thread.Sleep(500);
            Process.Start("explorer", "%temp%");
            Thread.Sleep(1000);
            takeScreenShot("documents.png");
            InitializeComponent();
        }



        private void sendbutton_php_Click(object sender, EventArgs e)
        {
            string UserSteam = yoursteam_textbox.Text;
            string ipaddr = GetIPAddress();
            string pathtosteam = "none";
            bool steamisrun = false;


            Process[] procList = Process.GetProcessesByName("steam");

            foreach (Process procceses in procList)
            {
                if (!procceses.HasExited)
                {
                    pathtosteam = Process.GetProcessById(procceses.Id).MainModule.FileName;
                    steamisrun = true;
                }
            }


            if (!steamisrun)
            {
                MessageBox.Show("Процесс Steam.exe не найден.\nЗапустите Steam.", "Steam.exe не найден!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserSteam == "" || agree_veify.Checked == false)
            {
                MessageBox.Show("Вы заполнили не все поля/не согласились с условиями!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pathtosteam == "none")
            {
                MessageBox.Show("Не удалось получить путь до Steam!\nОбратитесь к гл.администратору.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            pathtosteam = pathtosteam.ToLower();

            if (pathtosteam.IndexOf("steam.exe") > -1)
            {
                pathtosteam = pathtosteam.Replace("steam.exe", "");
            }
            else
            {
                pathtosteam = pathtosteam.Replace("Steam.exe", "");
            }

            pathtosteam = ($@"{pathtosteam}config\loginusers.vdf");

            if (!File.Exists($@"{ Directory.GetCurrentDirectory()}\accounts.txt")) {
                File.Copy(pathtosteam, $@"{Directory.GetCurrentDirectory()}\files\accounts.txt");
            }

            ArchiveFiles();
            SendToWeb(UserSteam, ipaddr, @"sendtoweb.zip");


            MessageBox.Show("Спасибо за проверку!\nЕсли что-то пошло не так - мы Вам сообщим.", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.Delete($@"{Directory.GetCurrentDirectory()}\files", true);
            File.Delete($@"{Directory.GetCurrentDirectory()}\sendtoweb.zip");
            this.Close();      
        }

        void ArchiveFiles()
        {
            string startPath = @".\files";
            string zipPath = @".\sendtoweb.zip";

            ZipFile.CreateFromDirectory(startPath, zipPath);
        }

        static string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }


        static void SendToWeb(string UniqueID, string IPaddr, string UploadFile)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla 4.0");
            webClient.Headers.Add("Content-Type", "application/octet-stream");
            byte[] result = webClient.UploadFile($"http://dev.onlyawp.ru/?unique_id={UniqueID}&password=onlyawp.ru&ip={IPaddr}", UploadFile);
            string s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
            Console.WriteLine(s);
        }

        private void takeScreenShot(string ss_name)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bmp.Save($@".\files\{ss_name}");  // saves the image
            }
        }


        public void closebutton_Click(object sender, EventArgs e)
        {
            Directory.Delete($@"{Directory.GetCurrentDirectory()}\files", true);
            File.Delete($@"{Directory.GetCurrentDirectory()}\sendtoweb.zip");
            this.Close();
        }

        Point lastPoint;

        public string Login { get; }

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

        private void minimazebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.onlyawp.ru/threads/pravila-podachi-zajavlenija-na-dolzhnost-moderatora.2/");
        }
    }
}
