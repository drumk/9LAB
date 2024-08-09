using System.Windows.Forms;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace _9LAB
{
    public partial class Form1 : Form
    {
        int n;
        int[] a = new int[1000];
        int[] b = new int[1000];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("¬ведите размерность массива A(n)", "n = ", "3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i; string spisok;
            n = Convert.ToInt32(textBox1.Text);
            spisok = "";
            listBox1.Text = "";
            label3.Text = "";
            Random rnd = new Random();
            for (i = 1; i <= n; i++)
            {
                a[i] = rnd.Next(-100, 101);
                spisok = spisok + Convert.ToString(i) + ") " +
                Convert.ToString(a[i]) + "	" + Environment.NewLine;
            }
            label3.Text = spisok;
            b[1] = a[1]; 
            listBox1.Items.Add("l)	" + b[1]);
            for (i = 2; i <= n; i++)
            {
                b[i] = a[i - 1] + a[i];
                listBox1.Items.Add(Convert.ToString(i) + ")	" +
                Convert.ToString(b[i]));
            }
        }
    }
}