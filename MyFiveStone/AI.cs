using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiveStone
{
    public struct Move
    {
       public int count;
       public int block;
    }
    public class AI
    {
        private bool pc_first;  //用于标志电脑是否先手，true = 先手，false = 后手
        private bool level;     //用于标志难度

        public int X { get; set; }

        public int Y { get; set; }

        public AI( bool isfir, bool lev )
        {
            pc_first = isfir;
            level = lev;
        }
        public void SetPC_Status(bool flag)
        {
            pc_first = flag;
        }
        public void SetPC_Level(bool lev)
        {
            level = lev;
        }
        public bool GetPC_Status()
        {
            return pc_first;
        }
        //通过AI算法，计算每个未下点的权值
        public void Down( int[,] board )
        {
            int[,] q = new int[15, 15];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if( board[i, j] != -1 )
                        q[i, j] = -1;
                    else if( !level )
                             q[i, j] = FindQz_Easy(i, j, board);
                         else
                             q[i, j] = FindQz_Hard(i, j, board);
                }
            }
            ForMax(q);
        }

        //寻找权值最大的落子点
        public void ForMax( int[,] q )
        {
            int max = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if( q[i, j] > max )
                    {
                        X = i;
                        Y = j;
                        max = q[i, j];
                    }
                }
            }
        }

        //计算目标落子点的权值
        public int FindQz_Easy(int x,int y,int[,] board)
        {
            int qz = 0;
            //权值设置： w1 比 w2-w8 累加还大,下类推
            //因为同样的期望情况下，让己方达到总比阻止他方达到要有利，因此对应的权值要大些
            //故同样的期望情况下，电脑方的权值可设为w1、w3、w5、w7；玩家方的权值设为w2、w4、w6、w8
            int w1 = 10000000;
            int w2 = 50000;
            int w3 = 10000;
            int w4 = 5000;
            int w5 = 1000;
            int w6 = 500;
            int w7 = 100;
            int w8 = 50;
            Move[] move = new Move[4];

            //先计算该落子对电脑有利的权值
            if( pc_first )
                board[x, y] = 0;                           //电脑为黑子
            else
                board[x, y] = 1;                           //电脑为白子

            //记录若在此处落子，四个方向上连成一线的各个棋子数
            move[0].count = Rules.X1_Easy(x, y, board);
            move[1].count = Rules.X2_Easy(x, y, board);
            move[2].count = Rules.X3_Easy(x, y, board);
            move[3].count = Rules.X4_Easy(x, y, board);

            //如果落子位于天元，则权值先加1；因为天元位置，往往比其他位置更有利
            if( x == 7 && y == 7 )
                qz += 1;

            //根据move[]数组的值，对应的计算权值
            for( int i = 0; i < 4; i++ )
            {
                if (move[i].count == 5)
                    qz += w1;
                else if (move[i].count == 4)
                         qz += w3;
                else if (move[i].count == 3) 
                              qz += w5;
                          else if( move[i].count == 2 )
                                   qz += w7;
            }


            //再计算该落子对玩家不利的权值
            if( pc_first )
                board[x, y] = 1;
            else
                board[x, y] = 0;

            move[0].count = Rules.X1_Easy(x, y, board);
            move[1].count = Rules.X2_Easy(x, y, board);
            move[2].count = Rules.X3_Easy(x, y, board);
            move[3].count = Rules.X4_Easy(x, y, board);

            for (int i = 0; i < 4; i++)
            {
                if (move[i].count == 5)
                    qz += w2;
                else if (move[i].count == 4)
                         qz += w4;
                else if (move[i].count == 3)
                              qz += w6;
                          else if( move[i].count == 2 )
                                   qz += w8;
            }

            board[x, y] = -1;
            return qz;
        }

        public int FindQz_Hard(int x, int y, int[,] board)
        {
            int qz = 0;
            //  (count,block) =>  count为连成一线的同色棋子数，block表示该线上两端有几端被阻挡；以下为落子在各种情况的权值
            //  (1,1)      (1,0)       (2,1)       (2,0)       (3,1)        (3,0)        (4,1)         (4,0)         (5,-)
            int psw1 = 50, psw2 = 100, psw3 = 200, psw4 = 400, psw5 = 800,  psw6 = 4000, psw7 = 8000,  psw8 = 16000, psw9 = 32000;
            int pcw1 = 75, pcw2 = 150, pcw3 = 300, pcw4 = 600, pcw5 = 1200, pcw6 = 6000, pcw7 = 12000, pcw8 = 24000, pcw9 = 48000;

            //  当落子在以下情况下，有附加权值
            //  至少两个（2，0）   至少两个（3，0）   至少1个（3，0）和1个（4，1）   至少两个（4，-)或者只有1个(4,0)   至少有一个方向上五子一线
            int psw_d2 = 1600,     psw_d3 = 16000,    psw_34 = 32000,                psw_d4 = 56000,                   psw_5 = 152000;
            int pcw_d2 = 2400,     pcw_d3 = 24000,    pcw_34 = 48000,                pcw_d4 = 84000,                   pcw_5 = 228000;

            Move[] move = new Move[4];

            //先计算该落子对电脑有利的权值
            if (pc_first)
                board[x, y] = 0;                           //电脑为黑子
            else
                board[x, y] = 1;                           //电脑为白子

            move[0] = Rules.X1_Hard(x, y, board);
            move[1] = Rules.X2_Hard(x, y, board);
            move[2] = Rules.X3_Hard(x, y, board);
            move[3] = Rules.X4_Hard(x, y, board);

            //如果落子位于天元，则权值先加1；因为天元位置，往往比其他位置更有利
            if (x == 7 && y == 7)
                qz += 1;

            //根据move[]数组的值，对应的计算权值
            //记录move[]中 (2,0)    (3,0)    (4,1)    (4,0)   （5,-) 的个数
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;

            for (int i = 0; i < 4; i++)
            {
                switch (move[i].count)
                {
                    case 1:
                        if (move[i].block == 1)
                            qz += pcw1;
                        if (move[i].block == 0)
                            qz += pcw2;
                        break;
                    case 2:
                        if (move[i].block == 1)
                            qz += pcw3;
                        if (move[i].block == 0)
                        {
                            qz += pcw4;
                            c1++;
                        }
                        break;
                    case 3:
                        if (move[i].block == 1)
                            qz += pcw5;
                        if (move[i].block == 0)
                        {
                            qz += pcw6;
                            c2++;
                        }
                        break;
                    case 4:
                        if (move[i].block == 1)
                        {
                            qz += pcw7;
                            c3++;
                        }
                        if (move[i].block == 0)
                        {
                            qz += pcw8;
                            c4++;
                        }
                        break;
                    default:                 //count>=5时
                        qz += pcw9;
                        c5++;
                        break;
                }
            }
            if (c1 > 1)
                qz += pcw_d2;
            if (c2 > 1)
                qz += pcw_d3;
            if (c2 > 0 && c3 > 0)
                qz += pcw_34;
            if (c3 > 1 || c4 > 0)
                qz += pcw_d4;
            if (c5 > 0)
                qz += pcw_5;

            //再计算该落子对玩家不利的权值
            if (pc_first)
                board[x, y] = 1;
            else
                board[x, y] = 0;

            move[0] = Rules.X1_Hard(x, y, board);
            move[1] = Rules.X2_Hard(x, y, board);
            move[2] = Rules.X3_Hard(x, y, board);
            move[3] = Rules.X4_Hard(x, y, board);

            c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0;

            for (int i = 0; i < 4; i++)
            {
                switch (move[i].count)
                {
                    case 1:
                        if (move[i].block == 1)
                            qz += psw1;
                        if (move[i].block == 0)
                            qz += psw2;
                        break;
                    case 2:
                        if (move[i].block == 1)
                            qz += psw3;
                        if (move[i].block == 0)
                        {
                            qz += psw4;
                            c1++;
                        }
                        break;
                    case 3:
                        if (move[i].block == 1)
                            qz += psw5;
                        if (move[i].block == 0)
                        {
                            qz += psw6;
                            c2++;
                        }
                        break;
                    case 4:
                        if (move[i].block == 1)
                        {
                            qz += psw7;
                            c3++;
                        }
                        if (move[i].block == 0)
                        {
                            qz += psw8;
                            c4++;
                        }
                        break;
                    default:                 //count>=5时
                        qz += psw9;
                        c5++;
                        break;
                }
            }
            if (c1 > 1)
                qz += psw_d2;
            if (c2 > 1)
                qz += psw_d3;
            if (c2 > 0 && c3 > 0)
                qz += psw_34;
            if (c3 > 1 || c4 > 0)
                qz += psw_d4;
            if (c5 > 0)
                qz += psw_5;

            board[x, y] = -1;
            return qz;
        }
    }
}
