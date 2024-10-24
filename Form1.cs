
namespace Bilibili_BvToAv_WinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            string result = Converter.ConvertToOlder(textBox1.Text);
            textBox2.Text = result;
        }
    }
}