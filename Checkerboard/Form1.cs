using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkerboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[7,7]; //7ye 7 lik toplam 49 tane buton
            int top = 0; //en üst nokta
            int left = 0; // en sol nokta

            for (int i = 0; i <= buttons.GetUpperBound(0); i++) //7 satır için değer
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++) // 7 sütun için
                {
                    buttons[i, j] = new Button(); //her buton bizim için yeni butondur bu yüzden her seferinde newleriz
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    // Üstteki kodla 49 buton üst üste bindi onları düzelticez
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;

                    if ((i + j) % 2 == 0) //tahtanın modunu alıyoruz eğer çift sayi ise siyah
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White; //tek sayı ise butonun rengini beyaz yapıyoruz
                    }
                    left += 50; //50 birim kaydır her yeni butonu

                    this.Controls.Add(buttons[i,j]); //Butonu ekrana koy
                }
                top += 50; //Yeni satır 50 birim kaymış şekilde başlasın
                left = 0; //Her yeni satıra geçtiğimizde lefti sıfırlıyoruz
            }
           
            
        }
    }
}
