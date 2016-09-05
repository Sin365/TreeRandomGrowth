using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //int index = 0;
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Peru, 4);//定义了一个蓝色,宽度为的画笔
            Pen p2 = new Pen(Color.SaddleBrown, 4);//定义了一个色,宽度为的画笔
            Pen p3 = new Pen(Color.GreenYellow, 2);//定义了一个色,宽度为的画笔
            Pen p4 = new Pen(Color.Peru, 2);//定义了一个色,宽度为的画笔
            Pen Pd = new Pen(Color.Green, 4);//地面画笔
            Pen Pddown = new Pen(Color.Brown, 5);


            List<positionM> PM = new List<positionM>();
            int AllIndex = 0;
            //生成地面
            while (AllIndex < 400)
            {
                Thread.Sleep(5);
                Random ra = new Random();
                int xp = ra.Next(-4, 0);
                int yp = ra.Next(-4, 5);
                g.DrawLine(Pd, MyPenD.x, MyPenD.y, MyPenD.x - xp, MyPenD.y - yp);
                MyPenD.x -= xp;
                MyPenD.y -= yp;
                g.DrawLine(Pddown, MyPenD.x ,MyPenD.y, MyPenD.x, MyPenD.y + 10000);
                if (AllIndex % 13 == 0)
                {
                    positionM m = new positionM();
                    m.x = MyPenD.x;
                    m.y = MyPenD.y;
                    PM.Add(m);
                }
                
                AllIndex++;
            }

            //AllIndex = 0;
            ////生成地面
            //while (AllIndex < 400)
            //{
            //    Pen Pddown2 = new Pen(Color.Green, 5);

            //    Thread.Sleep(5);
            //    Random ra = new Random();
            //    int xp = ra.Next(-4, 0);
            //    int yp = ra.Next(-4, 5);
            //    MyPenD2.x -= xp;
            //    MyPenD2.y -= yp;
            //    g.DrawLine(Pddown2, MyPenD2.x, MyPenD2.y, MyPenD2.x, MyPenD2.y + 10000);

            //    AllIndex++;
            //}

            foreach (var pm in PM)
            {
                MyPen.x = pm.x;
                MyPen.y = pm.y;

                MyPen2.x = pm.x + 1;
                MyPen2.y = pm.y;

                int index = 0;
                Random raa = new Random();
                int TreeTop = raa.Next(0, 450);
                while (index < TreeTop)
                {
                    Thread.Sleep(5);
                    Random ra = new Random();
                    int xp = ra.Next(-2, 3);
                    int yp = ra.Next(2, 4);
                    //xp = xp - 3;
                    //yp = yp - 2;
                    g.DrawLine(p2, MyPen2.x, MyPen2.y, MyPen2.x - xp, MyPen2.y - yp);
                    //g.DrawLine(p3, MyPen3.x, MyPen3.y, MyPen3.x - xp, MyPen3.y - yp);
                    g.DrawLine(p, MyPen.x, MyPen.y, MyPen.x - xp, MyPen.y - yp);
                    MyPen.x -= xp;
                    MyPen.y -= yp;
                    MyPen2.x -= xp;
                    MyPen2.y -= yp;
                    //MyPen3.x -= xp;
                    //MyPen3.y -= yp;
                    if (index > 40)
                    {
                        if (index % 13 == 0)
                        {
                            Pen pyezi = new Pen(Color.Green, 6);
                            Random ra_yezi = new Random();
                            int xpy = ra.Next(-20, 20);
                            int ypy = ra.Next(-5, 5);
                            g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy, MyPen.y - ypy);
                            g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy + 2, MyPen.y - ypy);


                            ///分支生长长度
                            Random ral = new Random();

                            int indexotop = ral.Next(5, 23);
                            int Oldx = MyPen.x;
                            int Oldy = MyPen.y;
                            int Oldx2 = MyPen2.x;
                            int Oldy2 = MyPen2.y;
                            int indexo = 0;
                             while (indexo <= indexotop)
                            {
                                Thread.Sleep(5);
                                Random rao = new Random();
                                int xpo = rao.Next(-6, 6);
                                int ypo = rao.Next(-4, 4);
                                g.DrawLine(p3, MyPen2.x, MyPen2.y, MyPen2.x - xpo, MyPen2.y - ypo);
                                //g.DrawLine(p3, MyPen3.x, MyPen3.y, MyPen3.x - xp, MyPen3.y - yp);
                                g.DrawLine(p4, MyPen.x, MyPen.y, MyPen.x - xpo, MyPen.y - ypo);
                                MyPen.x -= xpo;
                                MyPen.y -= ypo;
                                MyPen2.x -= xpo;
                                MyPen2.y -= ypo;
                                indexo++;
                            }

                            MyPen.x = Oldx;
                            MyPen.y = Oldy;
                            MyPen2.x = Oldx2;
                            MyPen2.y = Oldy2;
                            //Random yezi = new Random();
                            //if (yezi.Next(0, 1) == 1)
                            //{
                            //    Pen pyezi = new Pen(Color.Green, 6);
                            //    Random ra_yezi = new Random();
                            //    int xpy = ra.Next(-4, 4);
                            //    int ypy = ra.Next(-1, 1);
                            //    g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy, MyPen.y - ypy);
                            //}
                        }
                    }


                    index++;
                    //}
                }


                //while (true)
                //{
                //    Thread.Sleep(100);
                //    Random ra = new Random();
                //    int xp = ra.Next(-2, 2);
                //    int yp = ra.Next(2, 4);
                //    //xp = xp - 3;
                //    //yp = yp - 2;
                //    g.DrawLine(p2, MyPen2.x, MyPen2.y, MyPen2.x - xp, MyPen2.y - yp);
                //    //g.DrawLine(p3, MyPen3.x, MyPen3.y, MyPen3.x - xp, MyPen3.y - yp);
                //    g.DrawLine(p, MyPen.x, MyPen.y, MyPen.x - xp, MyPen.y - yp);
                //    MyPen.x -= xp;
                //    MyPen.y -= yp;
                //    MyPen2.x -= xp;
                //    MyPen2.y -= yp;
                //    //MyPen3.x -= xp;
                //    //MyPen3.y -= yp;
                //    if (index > 40)
                //    {
                //        if (index % 13 == 0)
                //        {
                //            Pen pyezi = new Pen(Color.Green, 6);
                //            Random ra_yezi = new Random();
                //            int xpy = ra.Next(-20, 20);
                //            int ypy = ra.Next(-5, 5);
                //            g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy, MyPen.y - ypy);
                //            g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy + 2, MyPen.y - ypy);


                //            ///分支生长长度
                //            Random ral = new Random();

                //            int indexotop = ral.Next(5, 23);
                //            int Oldx = MyPen.x;
                //            int Oldy = MyPen.y;
                //            int Oldx2 = MyPen2.x;
                //            int Oldy2 = MyPen2.y;
                //            int indexo = 0;
                //            while (indexo <= indexotop)
                //            {
                //                Thread.Sleep(100);
                //                Random rao = new Random();
                //                int xpo = rao.Next(-6, 6);
                //                int ypo = rao.Next(-4, 4);
                //                g.DrawLine(p3, MyPen2.x, MyPen2.y, MyPen2.x - xpo, MyPen2.y - ypo);
                //                //g.DrawLine(p3, MyPen3.x, MyPen3.y, MyPen3.x - xp, MyPen3.y - yp);
                //                g.DrawLine(p4, MyPen.x, MyPen.y, MyPen.x - xpo, MyPen.y - ypo);
                //                MyPen.x -= xpo;
                //                MyPen.y -= ypo;
                //                MyPen2.x -= xpo;
                //                MyPen2.y -= ypo;
                //                indexo++;
                //            }

                //            MyPen.x = Oldx;
                //            MyPen.y = Oldy;
                //            MyPen2.x = Oldx2;
                //            MyPen2.y = Oldy2;
                //            //Random yezi = new Random();
                //            //if (yezi.Next(0, 1) == 1)
                //            //{
                //            //    Pen pyezi = new Pen(Color.Green, 6);
                //            //    Random ra_yezi = new Random();
                //            //    int xpy = ra.Next(-4, 4);
                //            //    int ypy = ra.Next(-1, 1);
                //            //    g.DrawLine(pyezi, MyPen.x, MyPen.y, MyPen.x - xpy, MyPen.y - ypy);
                //            //}
                //        }
                //    }


                //    index++;
                //}

                ////g.DrawLine(p, 10, 10, 100, 100);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
                ////g.DrawRectangle(p, 10, 10, 100, 100);//在画板上画矩形,起始坐标为(10,10),宽为,高为
                ////g.DrawEllipse(p, 10, 10, 100, 100);//在画板上画椭圆,起始坐标为(10,10),外接矩形的宽为,高为
            }
        }

        public class positionM
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public static class MyPen
        {
            public static int x = 500;
            public static int y = 600;
        }

        public static class MyPen2
        {
            public static int x = 501;
            public static int y = 600;
        }
        public static class MyPen3
        {
            public static int x = 409;
            public static int y = 409;
        }

        public static class MyPenD
        {
            public static int x = 0;
            public static int y = 400;
        }

        public static class MyPenD2
        {
            public static int x = 0;
            public static int y = 650;
        }
    }
}
