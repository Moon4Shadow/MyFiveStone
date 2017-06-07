using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiveStone
{
    public class Rules
    {
        //判断该落子位置是否已落子，true = 已落子； false = 未落子
        public static bool CanPut(int x,int y,int[,] board)
        {
            if( board[x, y] == -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //左右方向连成一线的同色棋子数
        public static int X1_Easy(int x, int y, int[,] board)
        {
            int count = 1;

            //右方向
            int i = x + 1;
            while( i < 15 )
            {
                if( board[x, y] == board[i, y] )
                {
                    count++;
                    i++;
                }
                else
                    break;
            }

            //左方向
            i = x - 1;
            while( i > 0 )
            {
                if( board[x, y] == board[i, y] )
                {
                    count++;
                    i--;
                }
                else
                    break;
            }

            return count;
        }
        //上下方向
        public static int X2_Easy(int x, int y, int[,] board)
        {
            int count = 1;
            int i = y + 1;
            while( i < 15 )
            {
                if( board[x, i] == board[x, y] )
                {
                    count++;
                    i++;
                }
                else
                    break;
            }

            i = y - 1;
            while( i > 0 )
            {
                if( board[x, i] == board[x, y] )
                {
                    count++;
                    i--;
                }
                else
                    break;
            }

            return count;
        }
        //左上的斜线方向
        public static int X3_Easy(int x, int y, int[,] board)
        {
            int count = 1;
            int i = x - 1;
            int j = y - 1;
            while( i > 0 && j > 0 )
            {
                if( board[x, y] == board[i, j] )
                {
                    count++;
                    i--;
                    j--;
                }
                else
                    break;
            }

            i = x + 1;
            j = y + 1;
            while( i < 15 && j < 15 )
            {
                if( board[x, y] == board[i, j] )
                {
                    count++;
                    i++;
                    j++;
                }
                else
                    break;
            }

            return count;
        }
        //右上的斜线方向
        public static int X4_Easy(int x, int y, int[,] board)
        {
            int count = 1;
            int i = x - 1;
            int j = y + 1;

            while( i > 0 && j < 15 )
            {
                if( board[i, j] == board[x, y] )
                {
                    count++;
                    i--;
                    j++;
                }
                else
                    break;
            }

            i = x + 1;
            j = y - 1;

            while( i < 15 && j >= 0 )
            {
                if( board[i, j] == board[x, y] )
                {
                    count++;
                    i++;
                    j--;
                }
                else
                    break;
            }

           return count;
        }


        //左右方向
        public static Move X1_Hard(int x, int y, int[,] board)
        {
            Move move = new Move();
            move.count = 1;
            move.block = 0;

            //右方向
            int i = x + 1;
            while (i < 15)
            {
                if (board[x, y] == board[i, y])
                {
                    move.count++;
                    i++;
                }
                else 
                {
                    if (board[i, y] != -1)
                        move.block++;
                    break;
                }
            }

            if(i == 15)
                move.block++;

            //左方向
            i = x - 1;
            while (i > 0)
            {
                if (board[x, y] == board[i, y])
                {
                    move.count++;
                    i--;
                }
                else
                {
                    if (board[i, y] != -1)
                        move.block++;
                    break;
                }
            }
            if (i == -1)
                move.block++;

            return move;
        }
        //上下方向
        public static Move X2_Hard(int x, int y, int[,] board)
        {
            Move move = new Move();
            move.count = 1;
            move.block = 0;

            int i = y + 1;
            while (i < 15)
            {
                if (board[x, i] == board[x, y])
                {
                    move.count++;
                    i++;
                }
                else
                {
                    if (board[x, i] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == 15)
                move.block++;

            i = y - 1;
            while (i > 0)
            {
                if (board[x, i] == board[x, y])
                {
                    move.count++;
                    i--;
                }
                else
                {
                    if (board[x, i] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == -1)
                move.block++;

            return move;
        }
        //左上的斜线方向
        public static Move X3_Hard(int x, int y, int[,] board)
        {
            Move move = new Move();
            move.count = 1;
            move.block = 0;

            int i = x - 1;
            int j = y - 1;
            while (i > 0 && j > 0)
            {
                if (board[x, y] == board[i, j])
                {
                    move.count++;
                    i--;
                    j--;
                }
                else
                {
                    if (board[i, j] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == -1 || j == -1)
                move.block++;

            i = x + 1;
            j = y + 1;
            while (i < 15 && j < 15)
            {
                if (board[x, y] == board[i, j])
                {
                    move.count++;
                    i++;
                    j++;
                }
                else
                {
                    if (board[i, j] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == 15 || j == 15)
                move.block++;

            return move;
        }
        //右上的斜线方向
        public static Move X4_Hard(int x, int y, int[,] board)
        {
            Move move = new Move();
            move.count = 1;
            move.block = 0;

            int i = x - 1;
            int j = y + 1;
            while (i > 0 && j < 15)
            {
                if (board[i, j] == board[x, y])
                {
                    move.count++;
                    i--;
                    j++;
                }
                else
                {
                    if (board[i, j] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == -1 || j == 15)
                move.block++;

            i = x + 1;
            j = y - 1;
            while (i < 15 && j >= 0)
            {
                if (board[i, j] == board[x, y])
                {
                    move.count++;
                    i++;
                    j--;
                }
                else
                {
                    if (board[i, j] != -1)
                        move.block++;
                    break;
                }
            }

            if (i == 15 || j == -1)
                move.block++;

            return move;
        }


        //判断是否和局
        public static bool Over(int[,] board)
        {
            bool over = true;
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15; j++)
                {
                    if( board[i, j] == -1 )
                        over = false;
                }
            }
            return over;
        }

        //判断是否有输赢
        public static int Winer(int x, int y, int[,] board)
        {
            Move[] move = new Move[4];
            move[0].count = Rules.X1_Easy(x, y, board);
            move[1].count = Rules.X2_Easy(x, y, board);
            move[2].count = Rules.X3_Easy(x, y, board);
            move[3].count = Rules.X4_Easy(x, y, board);
            bool win = false;

            for (int i = 0; i < 4; i++)
            {
                if (move[i].count == 5)
                    win = true;
            }

            if (win)
                return 1;
            else
            {
                if (Over(board))
                    return 2;
                else
                    return 3;
            }
                
        }
    }
}
