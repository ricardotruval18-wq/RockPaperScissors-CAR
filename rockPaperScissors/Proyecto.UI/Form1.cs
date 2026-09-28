namespace Proyecto.UI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form2 = new Form2();
        form2.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        var form3 = new Form3();
        form3.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Form1.ActiveForm.Close();
    }
}
