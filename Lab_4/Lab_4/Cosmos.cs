using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_4
{
    public class Cosmos
    {
        public int distance; //удаленность от Земли
        public static Random rnd = new Random();
        //метод, который выдает информацию 
        public virtual String GetInfo()
        {
            var str = String.Format("\nУдаленность от Земли: {0} млн.км.", this.distance);
            return str;
        }
    }
    public class Planet: Cosmos
    {
        public int radius=0; //радиус планеты
        public bool atmosphere=false; // наличие атмосферы
        public int gravitation=0; //сила притяжения
        //переопределение метода GetInfo для класса планеты
        public override String GetInfo()
        {
            var str = "Планета";
            str += base.GetInfo();
            str += String.Format("\nРадиус: {0} км.", this.radius);
            str += String.Format("\nНаличие атмосферы: {0}", this.atmosphere);
            str += String.Format("\nСила притяжения: {0} H/кг", this.gravitation);
            return str;
        }
        //метод для генерации случайной планеты
        public static Planet Generate()
        {        
            return new Planet
            {
                distance= rnd.Next()%10000,
                radius = 2400+rnd.Next()%5000,
                atmosphere=rnd.Next()%2==0,
                gravitation= rnd.Next()%25
            };
        }
    }
    //цвета звезд
    public enum StarColor {white,blue,yellow,red};
    public class Star: Cosmos
    {
        public int density = 0; //плотность
        public StarColor color= StarColor.blue; //цвет
        public int temp = 0; //температура
        //переопределение метода GetInfo для класса звезд
        public override String GetInfo()
        {
            var str = "Звезда";
            str += base.GetInfo();
            str += String.Format("\nПлотность: {0}  г/ см^3 ", this.density);
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nТемпература: {0} К", this.temp);
            return str;
        }
        //метод для генерации случайной звезды
        public static Star Generate()
        {
            return new Star
            {
                distance = rnd.Next() % 10000,
                density=rnd.Next(),
                color=(StarColor)rnd.Next(4),
                temp=2000+rnd.Next()%60000
            };
        }
    }
    //названия комет
    public enum CometName
    {Halley,Encke,Biela,Faye,Brorsen,PonsWinnecke,Tuttle,Tempel,Olbers };
    public class Comet: Cosmos
    {
        public int period = 0; //период прохождения через солнечную систему
        public CometName name= CometName.Halley; //название
        //переопределение метода GetInfo для класса комет
        public override String GetInfo()
        {
            var str = "Комета";
            str += base.GetInfo();
            str += String.Format("\nПериод прохождения через солнечную систему(лет): {0} ", this.period);
            str += String.Format("\nНазвание: {0}", this.name);
            return str;
        }
        //метод для генерации случайной кометы
        public static Comet Generate()
        {
            return new Comet
            {
                distance = rnd.Next() % 10000,
                period = rnd.Next()%100,
                name = (CometName)rnd.Next(8),
            };
        }
    }
}