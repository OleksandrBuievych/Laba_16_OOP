using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laba_16_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vector A; // Створюємо два вектори, з якими ми будемо проводити операції.
        Vector B;
        private void button1_Click(object sender, EventArgs e) // Створення вектора за 3 параметрами
        {
            try {   // Оброблюємо виключення(пусті текстБокси)
                if (A == null)
                {
                    A = new Vector(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)); // Зчитуємо дані про вектор, з текстБоксу
                    MessageBox.Show(A.Show());
                }
                else if (B == null)
                {
                    B = new Vector(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    MessageBox.Show(B.Show());
                }
                else MessageBox.Show("Ви уже створили 2 вектора. Виконайте дії з ними!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Будь-ласка введіть коректні дані!");
            }
        }
         

        private void button2_Click(object sender, EventArgs e)  // Створення вектора за двома параметрами
        {
            try
            {
                if (A == null)
                {
                    A = new Vector(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    MessageBox.Show(A.Show());
                }
                else if (B == null)
                {
                    B = new Vector(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    MessageBox.Show(B.Show());
                }
                else MessageBox.Show("Ви уже створили 2 вектора. Виконайте дії з ними!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь-ласка введіть коректні дані!");
            }
        }

        private void button3_Click(object sender, EventArgs e) // Створення вектора за одним параметром
        {
            try    
            {
                if (A == null)
                {
                    A = new Vector(int.Parse(textBox1.Text));
                    MessageBox.Show(A.Show());
                }
                else if (B == null)
                {
                    B = new Vector(int.Parse(textBox1.Text));
                    MessageBox.Show(B.Show());
                }
                else MessageBox.Show("Ви уже створили 2 вектора. Виконайте дії з ними!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь-ласка введіть коректні дані!");
            }
        }

        private void button4_Click(object sender, EventArgs e) // Кнопка "Виконати обчислення"
        {
            if (A != null && B != null) // Перевіряємо чи створено у нас 2 вектори
            {
                Vector PlusAndMinus = A + B;    // Додатково створюємо вектор, для передачі в нього координат, які ми отримали після суми\різниці
                label10.Text = PlusAndMinus.ShowCoordination();
                PlusAndMinus = A - B;
                label11.Text = PlusAndMinus.ShowCoordination();
                label12.Text = Convert.ToString(A * B);
                label13.Text = Convert.ToString(A.Length());
                label14.Text = Convert.ToString(B.Length());
                label15.Text = Convert.ToString(PlusAndMinus.CosAngle(A,B));
                
            }
            else MessageBox.Show("Будь-ласка спочатку створіть два вектори!");
        }
    }
}
