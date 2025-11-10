using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            InitializeMyComponents();
        }



        private void InitializeMyComponents()
        {
            this.Text = "Проверка счастливого билета";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            labelTicket = new Label()
            {
                Text = "Нажмите кнопку для генерации",
                Location = new Point(60, 40),
                AutoSize = true,
                Font = new Font("Segoe UI", 12)
            };

            buttonGenerate = new Button()
            {
                Text = "Сгенерировать билет",
                Location = new Point(110, 90),
                Size = new Size(160, 35)
            };
            buttonGenerate.Click += ButtonGenerate_Click;

            labelResult = new Label()
            {
                Text = "",
                Location = new Point(60, 150),
                AutoSize = true,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };

            this.Controls.Add(labelTicket);
            this.Controls.Add(buttonGenerate);
            this.Controls.Add(labelResult);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 999999);
            string ticket = number.ToString("D6"); // форматируем до 6 цифр
            labelTicket.Text = $"Ваш билет: {ticket}";

            int sum1 = (ticket[0] - '0') + (ticket[1] - '0') + (ticket[2] - '0');
            int sum2 = (ticket[3] - '0') + (ticket[4] - '0') + (ticket[5] - '0');

            if (sum1 == sum2)
            {
                labelResult.Text = "Поздравляем! Счастливый билет ";
                labelResult.ForeColor = Color.Green;
            }
            else
            {
                labelResult.Text = "Обычный билет ";
                labelResult.ForeColor = Color.Red;
            }
        }
    }
}










        
            
        
    







    