using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace MyFiveStone
{
    public class Stones
    {
        private Graphics mg;
        private Bitmap bs;
        private Bitmap ws;
        private Bitmap ts;

        //加载棋子图片
        public Stones(Graphics g)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            //要将图片属性设为 “嵌入的资源”，否则bStream，wStream均为null
            Stream bStream = myAssembly.GetManifestResourceStream("MyFiveStone.black.png");
            Stream wStream = myAssembly.GetManifestResourceStream("MyFiveStone.white.png");
            Stream tStream = myAssembly.GetManifestResourceStream("MyFiveStone.target.png");
            bs = new Bitmap(bStream);
            ws = new Bitmap(wStream);
            ts = new Bitmap(tStream);
            bStream.Close();
            wStream.Close();
            tStream.Close();
            mg = g;
        }

        //在目标坐标绘制图像
        public void DrawStone(int x, int y, bool flag)
        {
            if( flag )
            {
                mg.DrawImage(bs, x * 40 + 20, y * 40 + 23, bs.Width, bs.Height);
            }
            else
            {
                mg.DrawImage(ws, x * 40 + 20, y * 40 + 23, bs.Width, bs.Height);
            }
        }
        public void DrawTarget(int x, int y)
        {
            mg.DrawImage(ts, x * 40 + 20, y * 40 + 23, ts.Width, ts.Height);
        }
    }
}
