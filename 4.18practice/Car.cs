using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18practice
{
    class Car//このClassではメーカー、タイプ、色というフィールドがあり、加速、減速というメソッドがある
    {
        public string Maker;//field宣言
        public string Type;
        public string Color;

        public string Result()//method
        {
            return this.Maker + this.Type +  this.Color;
        }


        public Car(string maker, string type, string color)//Form1からもらった情報を設定
        {
            this.Maker = maker;//thisは、自分自身のインスタンスを表す記号で
            this.Type = type;//これを先頭につけることにより、その変数がフィールド。であることを示している。
            this.Color = color;//引数のmaker type colorではなく、fieldの方
        }
    }
}//共通のフィールドおよびメソッドを持っているが、その値や結果は、インスタンスが異なるので違う。
