using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._18practice
{
    public partial class Form1 : Form
    {
        ///Car mCar1 = new Car(); //1つ目のCarクラスのメソッドのインスタンスを生成
        ///Car mCar2 = new Car(); //2つ目のCarクラスのメソッドのインスタンスを生成
        Car mCar0;//constructerを書いたので、あとでnew インスタンスを下の文に設定。29行目
        Car mCar1;//Form1 でcar classを利用する新しい変数を宣言
        Car mCar2;
        Car mCar3;
        public Form1()
        {   
            InitializeComponent();
            ///this.mCar1.Maker = "トヨタ";//フィールドMakerに値を代入
            ///this.mCar1.Type = "プリウス";//フィールドTypeに値を代入
            ///this.mCar1.Color = "白";//フィールドColorに値を代入

            ///this.mCar2.Maker = "ホンダ";//フィールドMakerに値を代入
            ///this.mCar2.Type = "シビック";//フィールドTypeに値を代入
            ///this.mCar2.Color = "赤";//フィールドColorに値を代入
            this.mCar0= new("Toyota ", "Prius ", "White ");//constructer methodで、Maker,Type,Colorを設定
            this.mCar1 = new("Honda ", "Civic ", "Blue ");
            this.mCar2 = new("Mazda ", "CX-5 ", "Black ");
            this.mCar3 = new("Nissan ", "Skyline ", "Silver ");
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.cmbItems.SelectedIndex == 0)
            {
                this.txtboxDisp.Text = this.mCar0.Result();
            }
            if (this.cmbItems.SelectedIndex == 1)
            {
                this.txtboxDisp.Text = this.mCar1.Result();
            }
            if (this.cmbItems.SelectedIndex == 2)
            {
                this.txtboxDisp.Text = this.mCar2.Result();
            }
            if (this.cmbItems.SelectedIndex == 3)
            {
                this.txtboxDisp.Text = this.mCar3.Result();
            }
        }
    }
}
