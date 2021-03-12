/***********************************************************************************
**                                    SAKARYA ÜNİVERSİTESİ
**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                             BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                          NESNEYE DAYALI PROGRAMLAMA DERSİ
**                            2019-2020 BAHAR DÖNEMİ
**                          
**                         
**                            ÖDEV NUMARASI.............: SORU 1
**                          ÖĞRENCİ ADI SOYADI........:   MELİH ÖZMEN
**                          ÖĞRENCİ NUMARASI..........:   B191210079
**                           DERSİN ALINDIĞI GRUP......:   B GRUBU
**************************************************************************************/
using System;
using System.IO;

namespace _2.Donem_1.Odev
{

    
    class Program
    {
       
        static void Main(string[] args)
        {
            StreamReader ogrenciBilgi = new StreamReader("ogrenci.txt");
        
            string ogrenci = ogrenciBilgi.ReadToEnd();
           string[] Ogrenci = ogrenci.Split('.'); // Bir Satır Örneği: Özde Acarkan  .B191212156 .78.30.48.58.     notların herbiri eşit oranda ortalamayı etkiler.
            int [] ogrSayisi=new int[(Ogrenci.Length) / 6]; //Öğrenci sayısını(satır sayısını) belirlemek için
            double sayacAA=0; double sayacBA=0; double sayacBB=0; double sayacCB=0; double sayacCC=0; double sayacDC=0;double sayacDD=0; double sayacFD=0; double sayacFF=0;
            for (int i = 0;i<ogrSayisi.Length; i++) //ÖĞRENCİ SAYISI KADAR DÖNDÜRÜR
            {
                int not1=0; int not2=0; int not3=0; int not4=0;
              not1 = Convert.ToInt32(Ogrenci[i * 6 + 2]);
              not2 = Convert.ToInt32(Ogrenci[i * 6 +3]);
              not3= Convert.ToInt32(Ogrenci[i * 6 + 4]);
              not4= Convert.ToInt32(Ogrenci[i * 6 + 5]);
               double ogrOrt = Convert.ToDouble(not1 + not2 + not3 + not4) / 4;
                if (90<=ogrOrt &&  ogrOrt<= 100)
                    sayacAA++;
                else if (85<=ogrOrt && ogrOrt<90)
                    sayacBA++;
                else if (80 <= ogrOrt && ogrOrt<85)
                    sayacBB++;
                else if (75 <= ogrOrt && ogrOrt < 80)
                    sayacCB++;
                else if (65 <= ogrOrt && ogrOrt < 75)
                    sayacCC++;
                else if (58 <= ogrOrt && ogrOrt < 65)
                    sayacDC++;
                else if (50 <= ogrOrt && ogrOrt < 58)
                    sayacDD++;
                else if (40 <= ogrOrt && ogrOrt<50)
                    sayacFD++;
                else if (0<=ogrOrt && ogrOrt<40)
                    sayacFF++;
            }
        string fileName = "sonuc.txt";
            using (StreamWriter Sonuc = File.CreateText(fileName))
            {
              
                Sonuc.WriteLine("AA  :" + sayacAA+" Kişi" + "   " + "AA alan öğrenci yüzdesi=%" + 100 * sayacAA / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("BA  :" + sayacBA + " Kişi" + "   " + "BA alan öğrenci yüzdesi=%" + 100 * sayacBA / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("BB  :" + sayacBB + " Kişi" + "   " + "BB alan öğrenci yüzdesi=%" + 100 * sayacBB / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("CB  :" + sayacCB + " Kişi" + "   " + "CB alan öğrenci yüzdesi=%" + 100 * sayacCB / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("CC  :"  + sayacCC + " Kişi" + "   " + "CC alan öğrenci yüzdesi=%" + 100 * sayacCC / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("DC  :" + sayacDC + " Kişi" + "   " + "DC alan öğrenci yüzdesi=%" + 100 * sayacDC / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("DD  :" + sayacDD + " Kişi" + "   " + "DD alan öğrenci yüzdesi=%" + 100 * sayacDD / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("FD  :" + sayacFD + " Kişi" + "   " + "FD alan öğrenci yüzdesi=%" + 100 * sayacFD / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
                Sonuc.WriteLine("FF  :" + sayacFF + " Kişi" + "   " + "FF alan öğrenci yüzdesi=%" + 100 * sayacFF / (sayacAA + sayacBA + sayacBB + sayacCB + sayacCC + sayacDC + sayacDD + sayacFD + sayacFF));
            }
           




         


        }
    }
}
