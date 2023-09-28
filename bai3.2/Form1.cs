namespace bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void radaddition_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text1.Text, out decimal number1) &&
       decimal.TryParse(text2.Text, out decimal number2))
            {
                decimal result = number1 + number2;
                textresult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radsubtraction_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text1.Text, out decimal number1) &&
       decimal.TryParse(text2.Text, out decimal number2))
            {
                decimal result = number1 - number2;
                textresult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radmultiplication_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text1.Text, out decimal number1) &&
       decimal.TryParse(text2.Text, out decimal number2))
            {
                decimal result = number1 * number2;
                textresult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void raddivision_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text1.Text, out decimal number1) &&
       decimal.TryParse(text2.Text, out decimal number2))
            {
                decimal result = number1 / number2;
                textresult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text1.Text, out decimal number1) &&
                decimal.TryParse(text2.Text, out decimal number2))
            {
                decimal result = 0;

                if (radaddition.Checked)
                {
                    result = number1 + number2;
                }
                else if (radsubtraction.Checked)
                {
                    result = number1 - number2;
                }
                else if (radmultiplication.Checked)
                {
                    result = number1 * number2;
                }
                else if (raddivision.Checked)
                {
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                textresult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}