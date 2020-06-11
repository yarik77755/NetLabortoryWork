using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_Csharp
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }


    }


    class MainClass
    {

        public void ShowInfo1(TextBox field1, TextBox field2, TextBox field3, TextBox field4, TextBox field5, TextBox field6, TextBox field7, TextBox field8, TextBox field9)
        {
            int tg, k1, k2;
            const double PI = 3.141592;

            try
            {
                Line line1 = new Line(Convert.ToInt16(field1.Text), Convert.ToInt16(field2.Text), Convert.ToInt16(field3.Text), Convert.ToInt16(field4.Text));
                Line line2 = new Line(Convert.ToInt16(field5.Text), Convert.ToInt16(field6.Text), Convert.ToInt16(field7.Text), Convert.ToInt16(field8.Text));





                field9.Text = line1.ShowLine() + "\r\nA(" + line1.x1 + "," + line1.y1 + ")\r\nB(" + line1.x2 + "," + line1.y2 + ")\r\n" +
                    line2.ShowLine() + "\r\nC(" + line2.x1 + "," + line2.y1 + ")\r\nD(" + line2.x2 + "," + line2.y2 + ")\r\n";


                k1 = line1.CheckParalel(field9);
                k2 = line2.CheckParalel(field9);



                if (line1.CheckParalel(field9) == line2.CheckParalel(field9))
                {
                    field9.Text += " Прямые паралельны";
                }
                else
                {
                   
                        k1 = line1.CheckParalel(field9);
                        k2 = line2.CheckParalel(field9);
                        tg = (k2 - k1) / (1 + k1 * k2);
                        field9.Text += " Прямые  не паралельны" + "\r\n Угол между прямыми = " + Convert.ToInt16(Math.Abs(Math.Atan(tg) * 180 / PI));  
                }
            }
            catch(FormatException)
            {
                field9.Text = "Введите коректные значения";
            }
        }

       
        class Line
        {
            public int x1, y1, x2, y2;

            public Line(int X1, int Y1, int X2, int Y2)
            {
                this.x1 = X1;
                this.y1 = Y1;
                this.x2 = X2;
                this.y2 = Y2;

            }

            public string ShowLine()
            {
                int A,B,C;
                string symbol;
                A = y1 - y2;
                B = x2 - x1;
                C = (x1 * y2 - x2 * y1);

                if (C > 0)
                    symbol = "+";
                else
                    symbol = "-";


                return A + "x +" + B + "y " + symbol + C + " = 0 ";

            }

            public int CheckParalel(TextBox field)
            {
                int k=0;

                try
                {
                    k = (y2 - y1) / (x2 - x1);
                    
                }
                catch (DivideByZeroException ex)
                {
                    field.Text = ex.Message;
                }
                return k;


            }

            


        }

       

    }
}
