using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_station
{
    public partial class Form1 : Form
    {
        bool flooded92 = false;
        bool flooded95 = false;
        bool paid92 = false;
        bool paid95 = false;
        float sum = 0;
        bool gasoline_selection = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox6.BringToFront();
            pictureBox7.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            label2.BringToFront();
            label4.BringToFront();
            sum50.BringToFront();
            sum100.BringToFront();
            sum1000.BringToFront();
            sum500.BringToFront();
            label2.Visible = true;
            sum50.Visible = true;
            sum100.Visible = true;
            sum1000.Visible = true;
            sum500.Visible = true;
            label4.Visible = true;
            pictureBox3.SendToBack();
            pictureBox3.Visible = false;


        }

        private async void sum1000_Click(object sender, EventArgs e)
        {

            label3.SendToBack();
            label3.Visible = false;
            sum += 1000;
            pictureBox8.Visible = true;
            await Task.Delay(500);
            pictureBox8.Location = new Point(149, 268);
            await Task.Delay(500);
            pictureBox8.Visible = false;
            await Task.Delay(1000);
            label1.Text = "Нажмите 'готово', \n чтобы прекратить\n внесение. \nВы внесли: " + sum + "р";
            label3.BringToFront();
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;

        }

        private async void sum500_Click(object sender, EventArgs e)
        {
            label3.SendToBack();
            label3.Visible = false;
            sum += 500;
            pictureBox8.Visible = true;
            await Task.Delay(500);
            pictureBox8.Location = new Point(149, 268);
            await Task.Delay(500);
            pictureBox8.Visible = false;
            await Task.Delay(1000);
            label1.Text = "Нажмите 'готово', \n чтобы закончить\n внесение. \nВы внесли: " + sum + "р";
            label3.BringToFront();
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;

        }

        private async void sum100_Click(object sender, EventArgs e)
        {
            label3.SendToBack();
            label3.Visible = false;
            sum += 100;
            pictureBox8.Visible = true;
            await Task.Delay(500);
            pictureBox8.Location = new Point(149, 268);
            await Task.Delay(500);
            pictureBox8.Visible = false;
            await Task.Delay(1000);
            label1.Text = "Нажмите 'готово', \n чтобы закончить\n внесение. \nВы внесли: " + sum + "р";
            label3.BringToFront();
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
        }

        private async void sum50_Click(object sender, EventArgs e)
        {
            label3.SendToBack();
            label3.Visible = false;
            sum += 50;           
            pictureBox8.Visible = true;
            await Task.Delay(500);
            pictureBox8.Location = new Point(149, 268);
            await Task.Delay(500);
            pictureBox8.Visible = false;
            label1.Text = "Нажмите 'готово', \n чтобы закончить\n внесение. \nВы внесли: " + sum + "р";
            label3.BringToFront();
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label2.SendToBack();
            sum50.SendToBack();
            sum100.SendToBack();
            sum1000.SendToBack();
            sum500.SendToBack();
            label2.Visible = false;
            sum50.Visible = false;
            sum100.Visible = false;
            sum1000.Visible = false;
            sum500.Visible = false;
            label3.SendToBack();
            label3.Visible = false;
            label4.Visible = false;
            label1.Text = "Вы уверены, что\nхотите продолжить?\nВнесенная сумма\nбудет утерена!";
            label8.Visible = true;
            label9.Visible = true;
            // label1.Text = "Внесите сумму\nТерминал принимает\nкупюры 50, 100, 500,\n1000 рублей\nСдачу не выдает!";
            //pictureBox3.BringToFront();
            //pictureBox3.Visible = true;
            //paid92 = false;
            //sum = 0;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            gasoline_selection = true;
            pictureBox4.Visible = false;
            label2.SendToBack();
            sum50.SendToBack();
            sum100.SendToBack();
            sum1000.SendToBack();
            sum500.SendToBack();
            label2.Visible = false;
            sum50.Visible = false;
            sum100.Visible = false;
            sum1000.Visible = false;
            sum500.Visible = false;
            label3.SendToBack();
            label3.Visible = false;
            label4.Visible = false;
            label1.Text = "Вы внесли: " + sum + "р\nВыберите вид\nбензина:";
            label5.BringToFront();
            label5.Visible = true;
            label6.BringToFront();
            label6.Visible = true;
            label7.BringToFront();
            label7.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            float quantity = sum / 40;
            label1.Text = "Будет выдано: " + quantity + "л\nВозьмите:\nшланг 92";
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = true;
            paid92 = true;
            label7.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            float quantity = sum / 45;
            label1.Text = "Будет выдано: " + quantity + "л\nВозьмите:\nшланг 95";
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = true;
            label7.Visible = false;
            paid95 = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            if (flooded92)
            {
                flooded92 = false;
                pictureBox6.Location = new Point(384, 450);
                await Task.Delay(500);
                pictureBox6.Location = new Point(384, 398);
                label1.Text = "Счастливого пути!";
                await Task.Delay(3000);
                label1.Text = "Внесите сумму\nТерминал принимает\nкупюры 50, 100, 500,\n1000 рублей\nСдачу не выдает!";
                pictureBox3.Visible = true;
                pictureBox3.BringToFront();
            }
            if (flooded95)
            {
                flooded95 = false;
                pictureBox7.Location = new Point(484, 450);
                await Task.Delay(500);
                pictureBox7.Location = new Point(484, 398);
                label1.Text = "Счастливого пути!";
                await Task.Delay(3000);
                label1.Text = "Внесите сумму\nТерминал принимает\nкупюры 50, 100, 500,\n1000 рублей\nСдачу не выдает!";
                pictureBox3.Visible = true;
                pictureBox3.BringToFront();
            }
        }

        private async void pictureBox6_Click_1(object sender, EventArgs e)
        {

            if (paid92)
            {
                label4.Visible = false;
                pictureBox6.Location = new Point(384, 450);
                await Task.Delay(500);
                pictureBox6.Location = new Point(384, 500);
                await Task.Delay(500);
                pictureBox6.Location = new Point(384, 600);
                await Task.Delay(500);
                pictureBox6.Location = new Point(384, 700);
                label1.Text = "Подождите, бак\n наполняется!";
                await Task.Delay(3000);
                label1.Text = "Бак наполнен!\nВерните шланг\nна место";
                sum = 0;
                flooded92 = true;
                paid92 = false;

            }


        }

        private async void pictureBox7_Click(object sender, EventArgs e)
        {
            if (paid95)
            {
                label4.Visible = false;
                pictureBox7.Location = new Point(484, 450);
                await Task.Delay(500);
                pictureBox7.Location = new Point(484, 500);
                await Task.Delay(500);
                pictureBox7.Location = new Point(484, 600);
                await Task.Delay(500);
                pictureBox7.Location = new Point(484, 700);
                label1.Text = "Подождите, бак\n наполняется!";
                await Task.Delay(3000);
                label1.Text = "Бак наполнен!\nВерните шланг\nна место";
                sum = 0;
                flooded95 = true;
                paid95 = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pictureBox3_Click(sender, e);
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label3.BringToFront();
            label3.Visible = true;
            label1.Text = "Нажмите 'готово', \n чтобы закончить\n внесение. \nВы внесли: " + sum + "р";
        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (gasoline_selection)
            {
                if (paid92)
                {
                    float quantity = sum / 40;
                    label1.Text = "Будет выдано: " + quantity + "л\nВозьмите:\nшланг 92";
                    label5.Visible = false;
                    label6.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label4.Visible = true;
                    paid92 = true;
                    label7.Visible = false;
                }
                if (paid95)
                {
                    float quantity = sum / 45;
                    label1.Text = "Будет выдано: " + quantity + "л\nВозьмите:\nшланг 95";
                    label5.Visible = false;
                    label6.Visible = false;
                    label4.Visible = true;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    paid95 = true;
                }
            }
            else
            {
                label1.Text = "Нажмите 'готово', \n чтобы закончить\n внесение. \nВы внесли: " + sum + "р";
                label8.Visible = false;
                label9.Visible = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label1.Text = "Внесите сумму\nТерминал принимает\nкупюры 50, 100, 500,\n1000 рублей\nСдачу не выдает!";
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
            paid92 = false;
            sum = 0;
            label8.Visible = false;
            label9.Visible = false;
        }
    }
}
