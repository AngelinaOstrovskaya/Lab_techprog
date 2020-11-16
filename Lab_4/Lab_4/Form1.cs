using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        List<Cosmos> CosmosList = new List<Cosmos>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void Button_Refill_Click(object sender, EventArgs e)
        {
            this.CosmosList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
               
                this.CosmosList.Add(new Planet());
                switch (rnd.Next() % 3) // генерируем случайное число от 0 до 2 
                {
                    case 0: // если 0, то планета
                        this.CosmosList.Add(Planet.Generate());
                        break;
                    case 1: // если 1 то звезда
                        this.CosmosList.Add(Star.Generate());
                        break;
                    case 2: // если 2 то комета
                        this.CosmosList.Add(Comet.Generate()); 
                        break;
                        
                }

            }
            ShowInfo();
        }
        // функция выводит информацию о количестве пленет,звезд и комет на форму
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int planetsCount = 0;
            int starsCount = 0;
            int cometsCount = 0;

            // пройдемся по всему списку
            foreach (var fruit in this.CosmosList)
            {           
                if (fruit is Planet) 
                {
                    planetsCount += 1;
                }
                else if (fruit is Star)
                {
                    starsCount += 1;
                }
                else if (fruit is Comet)
                {
                   cometsCount += 1;
                }
            }

            // выведим информацию на форму
            richTextBox_info.Text = "Планеты\tЗвезды\tКометы"; 
            richTextBox_info.Text += "\n";
            richTextBox_info.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }

        private void Button_Get_Click(object sender, EventArgs e)
        {
            //если список пуст, то вывод "пусто" и выход из функции
            if (this.CosmosList.Count == 0)
            {
                richTextBox_Out.Text = "Пусто";
                return;
            }

            // взяли первый объект космоса (создание указателя на область в памяти
            // где хранится экземпляр класса)
            var cosmos = this.CosmosList[0];  
            //удаление этого объекта космоса из списка
            this.CosmosList.RemoveAt(0);
            richTextBox_Out.Text =cosmos.GetInfo();     
            // обновим информацию о количестве товара на форме
            ShowInfo();
        }

        private void RichTextBox_Out_TextChanged(object sender, EventArgs e)
        {

        }
        //вызов формы с заданием
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
