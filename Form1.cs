namespace Файловый_менеджер
{
    public partial class Form1 : Form
    {
        Form form;
        TextBox textBox1;
        TextBox textBox2;
        Button btsearch;
        ListBox listfiles;
        SearchFiels files = new SearchFiels();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btCrserch_Click(object sender, EventArgs e)
        {
            form = new Form();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btsearch = new Button();
            listfiles = new ListBox();


            form.AutoSize = true;
            form.AutoScroll = true;
            form.Text = "Окно поиска";
            form.Controls.Add(textBox1);
            form.Controls.Add(textBox2);
            form.Controls.Add(btsearch);

            textBox1.Text = "Введите путь к папке";
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(10, 30);
            textBox1.Size = new Size(300, 10);
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;


            textBox2.Text = "'*.txt'";
            textBox2.ForeColor = Color.Gray;
            textBox2.Enter += TextBox2_Enter;
            textBox2.Leave += TextBox2_Leave;
            textBox2.Top = 50;
            textBox2.Left = 5;
            textBox2.Size = new Size(50, 10);
            textBox2.Location = new Point(320, 30);


            btsearch.Text = "Найти";
            btsearch.Size = new Size(50,30);
            btsearch.Location = new Point(380, 28);
            btsearch.Click += Btsearch_Click;

            form.Show();
        }

        private void TextBox2_Leave(object? sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "'*.txt'";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void TextBox2_Enter(object? sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void TextBox1_Leave(object? sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите путь к папке";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void TextBox1_Enter(object? sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void Btsearch_Click(object? sender, EventArgs e)
        {
            form.Controls.Add(listfiles);
            listfiles.Text = "";
            listfiles.Location = new Point(10, 80);
            listfiles.Size = new Size(360, 150);
            listfiles.HorizontalScrollbar = true;
            files.SetPath(textBox1.Text);
            files.SetName(textBox2.Text);

            listfiles.Items.Clear();
            try
            {


                foreach (var file in files.Getfiles())
                {
                    listfiles.Items.Add(file);
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}