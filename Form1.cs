using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf.qrcode;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using Path = System.IO.Path;

namespace Manigu
{
    public partial class Form1 : Form
    {

        private List<Image>[] exercitii = new List<Image>[505];
        private string url_algebra = @"http://pro-didactica.ro/bac2008_probleme/browserez.php?t1=Algebra&t2=&t3=&order=dificultate&ordine=ASC&start=";
        private string url_analiza = @"http://pro-didactica.ro/bac2008_probleme/browserez.php?t1=Analiza%20matematica&t2=&t3=&order=dificultate&ordine=ASC&start=";
        private string url_geometrie = @"http://pro-didactica.ro/bac2008_probleme/browserez.php?t1=Geometrie&t2=&t3=&order=dificultate&ordine=ASC&start=";
        private string ulr_trigonometrie = @"http://pro-didactica.ro/bac2008_probleme/browserez.php?t1=Trigonometrie&t2=&t3=&order=dificultate&ordine=ASC&start=";
        private string url_probabilitati = @"http://pro-didactica.ro/bac2008_probleme/browserez.php?t1=Probabilitati&t2=&t3=&order=dificultate&ordine=ASC&start=";
        List<string> rezolvate = new List<string>();
        string path;
        int Algebra = 0;
        int Analiza = 1;
        int Geometrie = 2;
        int Trigonometie = 3;
        int Probabilitati = 4;
        public static int kind = 0;
        public static int culoare = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bthome.BackColor = Color.FromArgb(24, 30, 55);
            for (int i = 0; i < 500; i++)
            {
                exercitii[i] = new List<Image>();
                Debug.WriteLine(i);
                //.Append(v);
            }
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             if (button1.Focused == true)
             {
                 button1.BackColor = Color.DarkSlateGray;
                 button2.BackColor = Color.FromArgb(24, 30, 55);
             }

             for (int i = 0; i < 500; i++)
             {
                 var url = url_probabilitati + (5 * i).ToString();
                 add_images_from_url(url, Probabilitati);

             }
         }*/

        private void add_images_from_url(string url, int vi)
        {
            string html = string.Empty;
            string based = @"http://pro-didactica.ro";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            //Debug.WriteLine(html)
            var matches = System.Text.RegularExpressions.Regex.Matches(html, "\".*?\\/pd_get\\.php\\?.*?.*\"");
            foreach (var link in matches)
            {
                var nigger = link.ToString().Split("\"")[1];
                nigger = nigger.Replace("amp;", "");
                Debug.WriteLine("====================================");
                Debug.WriteLine(nigger);
                Debug.WriteLine("====================================");
                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create(based + nigger);
                HttpWebResponse resp = (HttpWebResponse)rq.GetResponse();

                using (WebClient client = new WebClient())
                {

                    Random rand = new Random();


                    var bytes = client.DownloadData(new Uri(based + nigger));
                    using (var ms = new MemoryStream(bytes))
                    {
                        var img = Image.FromStream(ms);
                        exercitii[vi].Add(img);
                        img.Save(nigger.Split('/').Last());

                    }
                    // OR 
                    //client.DownloadFileAsync(new Uri(url), @"c:\temp\image35.png");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            string[] files = new string[1];

            if (Form1.kind == Algebra)
                files = Directory.GetFiles(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\algebra");

            if (Form1.kind == Analiza)
                files = Directory.GetFiles(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\analiza");

            if (Form1.kind == Geometrie)
                files = Directory.GetFiles(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\geometrie");

            if (Form1.kind == Trigonometie)
                files = Directory.GetFiles(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\trigonometrie");

            if (Form1.kind == Probabilitati)
                files = Directory.GetFiles(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\probabilitati");


            Debug.WriteLine(files.Length);
            if (files.Length > 0)
            {
                path = files[rand.Next(files.Length)];
                if (rezolvate.Contains(path) == false)
                    this.pictureBox1.Image = Image.FromFile(path);
            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //var type_idx = 0;// rand.Next(exercitii.Length);
            //var ex_idx = rand.Next(exercitii[type_idx].Count());

            //pictureBox1.Image = exercitii[type_idx][ex_idx];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            schimbare1.Visible = false;
            setari1.Visible = false;
            if (bthome.Focused == true && culoare != 2)
            {
                bthome.BackColor = Color.DarkSlateGray;
                button4.BackColor = Color.FromArgb(24, 30, 55);
                btsetari.BackColor = Color.FromArgb(24, 30, 55);
            }

            if (bthome.Focused == true && culoare == 2)
            {
                bthome.BackColor = Color.DarkSlateGray;
                button4.BackColor = Color.White;
                btsetari.BackColor = Color.White;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            schimbare1.Visible = true;
            if (button4.Focused == true && culoare !=2)
            {
                button4.BackColor = Color.DarkSlateGray;
                bthome.BackColor = Color.FromArgb(24, 30, 55);
                btsetari.BackColor = Color.FromArgb(24, 30, 55);
            }

            if (button4.Focused == true && culoare == 2)
            {
                button4.BackColor = Color.DarkSlateGray;
                bthome.BackColor = Color.White;
                btsetari.BackColor = Color.White;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void schimbare1_Load(object sender, EventArgs e)
        {

        }

        private void schimbare1_Load_1(object sender, EventArgs e)
        {

        }

        private void schimbare1_Load_2(object sender, EventArgs e)
        {
            Form1.kind = 3;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            rezolvate.Add(path);
            button2_Click(sender, e);
        }

        private void btsetari_Click(object sender, EventArgs e)
        {
            schimbare1.Visible = false;
            setari1.Visible = true;
            if (btsetari.Focused == true && culoare != 2)
            {   

                button4.BackColor = Color.FromArgb(24, 30, 55);
                bthome.BackColor = Color.FromArgb(24, 30, 55);
                btsetari.BackColor = Color.DarkSlateGray;
            }
             if (btsetari.Focused == true && culoare == 2)
            {
                button4.BackColor = Color.White;
                bthome.BackColor = Color.White;
                btsetari.BackColor = Color.DarkSlateGray;
            }
        }

        private void setari1_Load(object sender, EventArgs e)
        {

        }

        private void schimbare1_Load_3(object sender, EventArgs e)
        {

        }
    }
}