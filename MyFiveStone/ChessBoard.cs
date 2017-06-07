using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace MyFiveStone
{
    public class ChessBoard
    {
        public int[,] board = new int[15, 15];
        private Graphics mg;
        public Stones stone;
        public AI pc = new AI(false, false);              
        private bool flag = true;                     //落子颜色标志，true = 黑色， false = 白色
        private bool winflag = false;                 //游戏结束标志，true = 结束， false = 未结束

        public FiveStoneStack st = new FiveStoneStack();

        //初始化棋盘
        public ChessBoard(Graphics g)
        {
            mg = g;
            stone = new Stones(mg);
            st.CreateStack();
        }
        //开始游戏
        public void Start(bool mflag)
        {
            ClearBoards();

            winflag = false;
            if( !mflag )
            {
                flag = true;
                PCPut();
            }
            else
            {
                flag = true;
            }
            DrawBoard();
        }

        public bool GetWinflag()
        {
            return winflag;
        }
        public void SetWinflag( bool flag )
        {
            winflag = flag;
        }

        //还原棋盘
        public void ClearBoards()
        {
            st.st.top = -1;

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    board[i, j] = -1;
                }
            }
        }

        //加载棋盘，同时在对应位置绘制棋子
        public void DrawBoard()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("MyFiveStone.board.png");
            Bitmap bt = new Bitmap(myStream);
            myStream.Close();
            mg.DrawImage(bt, 20, 20, bt.Width, bt.Height);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (board[i, j] == 0)
                    {
                        stone.DrawStone(i, j, true);
                    }
                    if (board[i, j] == 1)
                    {
                        stone.DrawStone(i, j, false);
                    }
                }
            }
        }

        //落子后，判断是否胜利，是则输出相关信息，否则继续
        public void PutDown(int x, int y)
        {
            if( !winflag )
            {
                if( board[x, y] == -1 )
                {
                    //先重绘棋盘，从而达到消除原来target图像；再绘制新的落子
                    //不好的地方在于，重绘时会花屏
                    DrawBoard();
                    stone.DrawStone(x, y, flag);
                    stone.DrawTarget(x, y);

                    //黑子记为 0； 白子记为1
                    if( flag ) 
                        board[x, y] = 0;
                    else
                        board[x, y] = 1;

                    st.Insert( x, y );
       
                    if( Rules.Winer(x, y, board) > 0 )
                    {
                        switch( Rules.Winer(x, y, board) )
                        {
                            case 1:
                                if( flag )
                                {
                                    winflag = true;
                                    System.Windows.Forms.MessageBox.Show("黑子胜利");
                                }
                                else
                                {
                                    winflag = true;
                                    System.Windows.Forms.MessageBox.Show("白子胜利");
                                }
                                break;
                            case 2:
                                winflag = true;
                                System.Windows.Forms.MessageBox.Show("平局");
                                break;
                        }
                    }

                    //更换落子方
                    flag = !flag;
                }
            }
        }

        //玩家落子后，判断落子位置是否已有棋子，有则无操作；无则重绘棋盘，并让电脑落子
        public bool PersonPut(int x, int y)
        {
            if (x > 0 && x < 620 && y > 25 && y < 620)
            {
                int m = 0, n = 0;

                //计算预计落子坐标
                m = (x - 20) / 40;
                n = (y - 20) / 40;
                
                int mt = (m + 1) * 40, nt = (n + 1) * 40;

                //计算鼠标点击位置是否在以预计落子坐标为中心的20 * 20区域内，是则判断是否可落子，否则不落子
                if (x > mt - 10 && x < mt + 10 && y > nt - 10 && y < nt + 10)
                {
                    if (Rules.CanPut(m, n, board))
                    {
                        PutDown(m, n);
                        PCPut();
                        return true;  
                    }
                }
                return false;
            }
            else
                return false;
        }
        //电脑通过AI算法，计算落子位置，然后落子
        public void PCPut()
        {
            int m = 0, n = 0;
            int err = 0;
            do
            {
                pc.Down( board );
                m = pc.X;
                n = pc.Y;
                err++;
                if( err > 100 )
                {
                    System.Windows.Forms.MessageBox.Show("发生了一些错误，棋局将重新开始");
                    Start(true);
                }
            } while (!Rules.CanPut(m, n, board));

            PutDown(m, n);
        }
    }
}
