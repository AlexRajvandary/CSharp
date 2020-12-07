using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractalsLib;

namespace Fractal
{
    public partial class Form1 : Form
    {


        static Graphics gr;
        static int Width;
        static double Angle = Math.PI / 4;
        static double Angle_1 = Math.PI / 3;
        static double Angle_2 = Math.PI / 5;
        static double Length = 20.0;

        static int iter = 3;
        static int max = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Фрактальное дерево

                    LengthTextBox.Show();
                    AngleTextBox.Show();
                    Angle_1textBox.Show();
                    Angle_2textBox.Show();

                    Length_label.Show();
                    Angle_label.Show();
                    label3.Show();
                    label4.Show();
                    label2.Show();




                    break;
                case 1:
                    LengthTextBox.Hide();
                    AngleTextBox.Hide();
                    Angle_1textBox.Hide();
                    Angle_2textBox.Hide();

                    Length_label.Hide();
                    Angle_label.Hide();
                    label3.Hide();
                    label4.Hide();
                    WidthLabel.Hide();

                    label2.Show();

                    //Кривая Коха



                    break;
                case 2:
                    //Ковер Серпинского
                    WidthLabel.Hide();
                    label2.Show();

                    break;
                case 3:

                    //Треугольник Серпинского
                    WidthLabel.Hide();
                    label2.Show();

                    break;
                case 4:
                    // Множество Кантора
                    LengthTextBox.Hide();
                    AngleTextBox.Hide();
                    Angle_1textBox.Hide();
                    Angle_2textBox.Hide();

                    Length_label.Hide();
                    Angle_label.Hide();
                    label3.Hide();
                    label4.Hide();
                    textBox1.Hide();
                    label2.Hide();
                   

                    WidthLabel.Show();
                    WidthTextBox.Show();

                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int depth;
            if (int.TryParse(textBox1.Text, out depth))
            {
                if (depth <= 0)
                {
                    MessageBox.Show("Глубина не может быть отрицательной или нулевой!");
                }
                else
                {
                    max = iter = depth;
                    Draw_Click(sender, e);
                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }




        private void Draw_Click(object sender, EventArgs e)
        {

            gr.Clear(Color.Black);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Фрактальное дерево

                    FractalTree fractalTree = new FractalTree(gr);
                    fractalTree.ang1 = Angle_1;
                    fractalTree.ang2 = Angle_2;
                    fractalTree.DrawTree(new Point((int)(w / 2), (int)h), Length, Angle, iter);



                    break;
                case 1:

                    //Кривая Коха

                    CochSnowflake snowflake = new CochSnowflake(gr, new PointF(w / 2, h / 5), new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), max);

                    snowflake.CochSnowflakeDraw(snowflake.p1, snowflake.p2, snowflake.p3, iter);

                    break;
                case 2:
                    //Ковер Серпинского
                    SerpinskiSquare serpinskiSquare = new SerpinskiSquare(gr);
                    serpinskiSquare.Draw(iter, new PointF(w / 5, (float)(h * 0.1)), (int)(h / 2), (int)(h / 2));

                    break;
                case 3:

                    //Треугольник Серпинского

                    SerpinskiTriangle serpinskiTriangle = new SerpinskiTriangle(gr);
                    serpinskiTriangle.Draw(iter,new PointF(w / 2, h / 5), new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5));

                    break;
                case 4:
                    // Множество Кантора

                    CantorFractal cantorFractal = new CantorFractal(gr);
                    cantorFractal.Draw((int)(w / 2), 0, Width);
                    break;

            }

        }

        private void AngleTextBox_TextChanged(object sender, EventArgs e)
        {
            double angle;

            if (double.TryParse(AngleTextBox.Text, out angle))
            {
                if (angle <= 0)
                {
                    MessageBox.Show("Угол не может быть отрицательным или нулевым!");
                }
                else
                {
                    Angle = angle * (Math.PI / 180);

                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            double length;
            if (double.TryParse(LengthTextBox.Text, out length))
            {
                if (length <= 0)
                {
                    MessageBox.Show("длина не может быть отрицательной или нулевой!");
                }
                else
                {
                    Length = length;

                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }

        private void Angle_1textBox_TextChanged(object sender, EventArgs e)
        {
            double angle;

            if (double.TryParse(AngleTextBox.Text, out angle))
            {
                if (angle <= 0)
                {
                    MessageBox.Show("Угол не может быть отрицательным или нулевым!");
                }
                else
                {
                    Angle_1 = angle * (Math.PI / 180);

                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }

        private void Angel_2textBox_TextChanged(object sender, EventArgs e)
        {
            double angle;

            if (double.TryParse(AngleTextBox.Text, out angle))
            {
                if (angle <= 0)
                {
                    MessageBox.Show("Угол не может быть отрицательным или нулевым!");
                }
                else
                {
                    Angle_2 = angle * (Math.PI / 180);

                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }

        private void WidthTextBox_TextChanged_1(object sender, EventArgs e)
        {
            int width;

            if (int.TryParse(WidthTextBox.Text, out width))
            {
                if (width <= 0)
                {
                    MessageBox.Show("Расстояние не может быть отрицательным или нулевым!");
                }
                else
                {
                    Width = width;

                }
            }
            else
            {

                MessageBox.Show("Необходимо ввести целое положительное число!");
            }
        }
    }
}
