using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace AnalogSaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        ShapeContainer tuval = new ShapeContainer();
        OvalShape merkez = new OvalShape();

        LineShape[] saatcizgisi = new LineShape[12];
        LineShape[] sdcizgisi = new LineShape[60];

        Label[] etiket = new Label[12];

        LineShape saniyeCizgisi = new LineShape();
        LineShape dakikaCizgisi = new LineShape();
        LineShape sCizgisi = new LineShape();
        private void Form1_Load(object sender, EventArgs e)
        {
            tuval.Parent = this;

            saniyeCizgisi.Name = "sanc";
            saniyeCizgisi.BorderWidth = 3;
            saniyeCizgisi.BorderColor = Color.Red;
            saniyeCizgisi.Parent = tuval;
            saniyeCizgisi.X1 = 220;
            saniyeCizgisi.Y1 = 220;
            saniyeCizgisi.X2 = 220;
            saniyeCizgisi.Y2 = 220;

            dakikaCizgisi.Name = "dc";
            dakikaCizgisi.BorderWidth = 5;
            dakikaCizgisi.BorderColor = Color.Blue;
            dakikaCizgisi.Parent = tuval;
            dakikaCizgisi.X1 = 220;
            dakikaCizgisi.Y1 = 220;
            dakikaCizgisi.X2 = 220;
            dakikaCizgisi.Y2 = 220;

            sCizgisi.Name = "saatc";
            sCizgisi.BorderWidth = 10;
            sCizgisi.BorderColor = Color.Black;
            sCizgisi.Parent = tuval;
            sCizgisi.X1 = 220;
            sCizgisi.Y1 = 220;
            sCizgisi.X2 = 220;
            sCizgisi.Y2 = 220;


            /*merkez.Parent = tuval;// akrep ve yelkovan hareket ettikçe ortadaki çember siliniyosa bunu kullan


             merkez.Name = "merkez1";
             merkez.Width = 20;
             merkez.Height = 20;
             merkez.Left = 210;
             merkez.Top = 210;
             merkez.BackColor = Color.Black;
             merkez.BackStyle = BackStyle.Opaque;*/

            //bu for döngüsünü cepte tut size 400,400 olup location 20,20 olan bi saate çizgi atamak için kullanabilirsin 
            //eğer bu x1 y1 falan ile aşağıda yaptığın hesaplamadaki 220 200 gibi olan hesaplamaları değişirsen farklı bi location ve size daki saatlerdede işe yarar //bu hesaplamaları nasıl yapıcağını bi alt satıra yazdım
            //GÜNCELLEME bu alttaki hesabı yapmana gerek kalmadı artık oto yapıyo
            //220=  + cemberin yarı çapı(400/2=200) ile bulabilirsin || 200 ise direk yarıçapın kendisi || 180(math.pi/180 deki 180 farklı bi değer bununla alakası yok) = yarıçap(400/2=200) -  location(20)

            int x = ovalShape1.Width/2;
            int y = ovalShape1.Height/2;
            int left = ovalShape1.Location.X;
            int top = ovalShape1.Location.Y;    
            int xl = x + left;
            int yt = y + top;
            int xle = x - 30;
            int yle = y - 30; 
            
            for (int i = 0; i < 12; i++)//saat çizgileri
            {                        
                saatcizgisi[i] = new LineShape();
                saatcizgisi[i].BorderWidth = 3;
                saatcizgisi[i].Name = "cizgi" + i;//dizideki elemanlara çizgi0 çizgi1 diye isim veriyor
                double aci = i * 30 * Math.PI / 180;
                saatcizgisi[i].X1 = Convert.ToInt32(xl - x * Math.Cos(aci)); //burdaki X1 bi özellik cizginin başının koordinatlarını alıp verebilir(get set)
                saatcizgisi[i].X2 = Convert.ToInt32(xl - xle * Math.Cos(aci));
                saatcizgisi[i].Y1 = Convert.ToInt32(yt - y * Math.Sin(aci));
                saatcizgisi[i].Y2 = Convert.ToInt32(yt - yle * Math.Sin(aci));

            }
            
           
            for (int i = 0; i < 60; i++)//saniye çizgileri
            {
                sdcizgisi[i] = new LineShape();
                sdcizgisi[i].BorderWidth = 1;
                sdcizgisi[i].Name = "sdc" + i;//dizideki elemanlara çizgi0 çizgi1 diye isim veriyor
                double aci = i * 6 * Math.PI / 180;
                sdcizgisi[i].X1 = Convert.ToInt32(xl - x * Math.Cos(aci)); //burdaki X1 bi özellik cizginin başının koordinatlarını alıp verebilir(get set)
                sdcizgisi[i].X2 = Convert.ToInt32(xl - (xle+20) * Math.Cos(aci));
                sdcizgisi[i].Y1 = Convert.ToInt32(yt - y * Math.Sin(aci));
                sdcizgisi[i].Y2 = Convert.ToInt32(yt - (yle+20) * Math.Sin(aci));

            }
            for (int i = 0; i < 12; i++)//label lar 1 2 3 diye çizgilere saatin kaç olduğunu belirten sayıları eklemek için
            {
                etiket[i] = new Label();             
                etiket[i].Name = "etiket" + i;//dizideki elemanlara çizgi0 çizgi1 diye isim veriyor
                etiket[i].Font = new Font("", 20);
                etiket[i].TextAlign = ContentAlignment.MiddleCenter;
                etiket[i].Width = 45;
                etiket[i].Height = 27;
                etiket[i].Text = (i + 1).ToString();
                
                double aci = (i * 30 + 120)* Math.PI / 180;
                etiket[i].Left = Convert.ToInt32(xl - (x-55) * Math.Cos(aci)) - etiket[i].Width/2; //burdaki X1 bi özellik cizginin başının koordinatlarını alıp verebilir(get set)
                etiket[i].Top = Convert.ToInt32(yt - (y-55) * Math.Sin(aci)) - etiket[i].Height/2;

            }

            timer1.Start();

            this.shapeContainer1.Shapes.AddRange(saatcizgisi);//saat çizgilerini dahil eder
            this.shapeContainer1.Shapes.AddRange(sdcizgisi);//sd çizgilerini dahil eder
            this.Controls.AddRange(etiket);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int saat = DateTime.Now.Hour;
            int dakika = DateTime.Now.Minute;
            int saniye = DateTime.Now.Second;

            double aci = (270 + saniye * 6) * Math.PI / 180;
            saniyeCizgisi.X1 = Convert.ToInt32 (220 + 100 * Math.Cos(aci));
            saniyeCizgisi.Y1 = Convert.ToInt32(220 + 100 * Math.Sin(aci));

            aci = (270 + dakika * 6 + 0.1*saniye) * Math.PI / 180;
            dakikaCizgisi.X1 = Convert.ToInt32(220 + 100 * Math.Cos(aci));
            dakikaCizgisi.Y1 = Convert.ToInt32(220 + 100 * Math.Sin(aci));

            aci = (270 + saat * 30 + 0.5 * dakika + (0.5/60)*saniye) * Math.PI / 180;
            sCizgisi.X1 = Convert.ToInt32(220 + 100 * Math.Cos(aci));
            sCizgisi.Y1 = Convert.ToInt32(220 + 100 * Math.Sin(aci));

        }
    }
}
