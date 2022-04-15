namespace лр5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, x = 40, y = 20;

        private void button2_Click(object sender, EventArgs e)
        {
            a++;
            button2.Text = "панели" + a.ToString();

            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    TextBox z = new TextBox();
                    z.Parent = c;
                }

            }
        }

        private string t;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel b = new Panel();
            b.Parent = this;
            b.Location = new Point(x, y);
            b.Size = new Size(40, 20);
            b.BackColor = Color.Black;
            if (x > 800)
            {
                x = 0;
                y += 20;
            }
            else
                x += 40;
            if (y > 450)
            {
                button1.Enabled = false;
            }

            
        }
    }
}