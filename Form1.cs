namespace WinFormsAppTesteTryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int opcao = comboBox1.SelectedIndex;

                MessageBox.Show($"Olá Mundo, escolhido recurso : {opcao.ToString()} Será que vai passar no Break... ?? ");

                switch (opcao)
                {
                    case 0:
                        {
                            MessageBox.Show("Break aqui existe ");
                            break;
                            //MessageBox.Show("Break aqui é inutil.. ");                        
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gerou Exeption ...: {ex.Message}");
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("0-Delphi");
            comboBox1.Items.Add("1-C#");
            comboBox1.Items.Add("2-Python");
            comboBox1.Items.Add("3-Java");
            comboBox1.Items.Add("4-HTML");
            comboBox1.Items.Add("5-JavaScript");
            comboBox1.SelectedIndex = 3;
        }
    }
}