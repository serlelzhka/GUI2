using Microsoft.VisualBasic.Logging;

namespace GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            num.Text = Properties.Settings.Default.number.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = int.Parse(this.num.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("�����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.number = number;
            Properties.Settings.Default.Save();
            MessageBox.Show(Logic.Compare(number), "�����:");
        }
    }
}