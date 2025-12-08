using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bronbooks
{
    public partial class bron : Form
    {
        public bron()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, что что-то введено
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show($"Книга '{textBox1.Text}' забронирована!",
                    "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Введите название книги!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Переход в личный кабинет
            lk lkForm = new lk();
            lkForm.Show();
            this.Hide();
        }
    }
}
