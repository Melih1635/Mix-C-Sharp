/***********************************************************************************
**                                    SAKARYA ÜNİVERSİTESİ
**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                             BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                          NESNEYE DAYALI PROGRAMLAMA DERSİ
**                            2019-2020 BAHAR DÖNEMİ
**                          
**                         
**                            ÖDEV NUMARASI.............: 2.ÖDEV
**                          ÖĞRENCİ ADI SOYADI........:   MELİH ÖZMEN
**                          ÖĞRENCİ NUMARASI..........:   B191210079
**                           DERSİN ALINDIĞI GRUP......:   B GRUBU
**************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Dönem_2.Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArkadas_Click(object sender, EventArgs e)
        {   
            //Burada butona basıldıktan sonra oluşturalacak textbox ve listbox kodları yer alıyor.
            var textBox1 = new TextBox
            {
                Left = 300,
                Top = 250,
            };
            var textBox2 = new TextBox
            {
                Left = 500,
                Top = 250,
            };
            var listBox1 = new ListBox
            {
                Left = 300,
                Top = 100,
            };
            var listBox2 = new ListBox
            {
                Left = 500,
                Top = 100,
            };
            //textbox ve listbox eklemek için yazılır
            Controls.Add(textBox1); Controls.Add(textBox2); Controls.Add(listBox1); Controls.Add(listBox2);
            
            lblListX.Text = "X"; lblListY.Text = "Y"; lblToplam.Text = "TOPLAMLAR";
            int sayiX, sayiY;
            //Textboxdaki metni sayıya çevirmek için 
            sayiX = Convert.ToInt32(txtX.Text);
            sayiY = Convert.ToInt32(txtY.Text);
            int XbolenToplamı = 0; int YbolenToplamı = 0;
            //X sayısının bölenlerinin hesaplanması ve toplam bölen değerinin bulunması için yapılan döngü
            for (int m = 1; m <= sayiX; m++)
              {
                  if (sayiX % m == 0)
                     {
                        listBox1.Items.Add(m.ToString());
                         XbolenToplamı += m;
                     }                  
              }
             
            //Y sayısının bölenlerinin hesaplanması ve toplam bölen değerinin bulunması için yapılan döngü
            for (int k = 1; k <= sayiY; k++)
              {
                  if (sayiY % k == 0)
                  {

                      listBox2.Items.Add(k.ToString());
                      YbolenToplamı += k;
                  }
              }
             
             textBox1.Text = XbolenToplamı.ToString();//X bölenlerinin toplamını yazdırır
              textBox2.Text = YbolenToplamı.ToString();//Y bölenlerinin toplamını yazdırır

        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

      
        
    

   

