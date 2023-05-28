using System.Media;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer(soundLocation: @"C:\Users\HamzaCicek\Downloads\kim.wav");
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dopru = 0, yanl�� = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text == label1.Text)
            {
                dopru++;
                label5.Text = "Do�ru Sayisi :"+dopru.ToString();
                button1.BackColor= Color.Green;

            }
            else
            {
                yanl��++;
                label10.Text = "Yanl�� Sayisi :" + yanl��.ToString();
                button1.BackColor = Color.Red;

            }
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text == label2.Text)
            {
                dopru++;
                label5.Text = "Do�ru Sayisi :" + dopru.ToString();
                button2.BackColor = Color.Green;

            }
            else
            {
                yanl��++;
                label10.Text = "Yanl�� Sayisi :" + yanl��.ToString();
                button2.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label6.Text == label3.Text)
            {
                dopru++;
                label5.Text = "Do�ru Sayisi :" + dopru.ToString();
                button3.BackColor = Color.Green;

            }
            else
            {
                yanl��++;
                label10.Text = "Yanl�� Sayisi :" + yanl��.ToString();
                button3.BackColor = Color.Red;
            }
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label6.Text == label4.Text)
            {
                dopru++;
                label5.Text = "Do�ru Sayisi :" + dopru.ToString();
                button4.BackColor = Color.Green;

            }
            else
            {
                yanl��++;
                label10.Text = "Yanl�� Sayisi :" + yanl��.ToString();
                button4.BackColor = Color.Red;
            }
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            soruno++;
            label9.Text=soruno.ToString();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            listBox1.Items.Clear();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            if (soruno == 1)
            {
                listBox1.Items.Add("Fight Kul�p Kurallar�dan De�ildir?");
                label1.Text = "f�ght club hakk�nda konusmamak";
                label2.Text = "Biri dur derse veya topallamaya ba�larsa, d�v�� sona ermi�tir";
                label3.Text = "Ayn� anda iki ki�i kavga eder";
                label4.Text = "Bu fight clubda ilk gecense, d�v��mek zorunda de�ilsin";

                label6.Text = "Bu fight clubda ilk gecense, d�v��mek zorunda de�ilsin";
                button5.Text = "Di�er Soru";
            }
            if (soruno == 2)
            {
                listBox1.Items.Add("Fight Kul�p Kurucusu Kimdir?");
                label1.Text = "Salih Durden";
                label2.Text = "Hamza Durden";
                label3.Text = "Tyler Durden";
                label4.Text = "Zalim Durden";

                label6.Text = "Salih Durden";
                button5.Visible = false;
            }
        }
    }
}