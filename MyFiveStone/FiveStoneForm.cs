using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace MyFiveStone
{
    public partial class FiveStoneForm : Form
    {
        //public bool first=true;
        public FiveStoneForm()
        {
            InitializeComponent();
        }

        public ChessBoard bd;

        //初始化棋盘
        private void Form1_Load(object sender, EventArgs e)
        {
            bd = new ChessBoard(this.CreateGraphics());
            bd.ClearBoards(); 
        }
        //绘制棋盘
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bd.DrawBoard();
        }

        //鼠标在棋盘上移动时，实时显示落子坐标
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 620 && e.Y < 620)
            {
                int n = 0, m = 0;
                //计算预计落子坐标
                m = (e.X - 20) / 40;
                n = (e.Y - 20) / 40;

                label1.Text = "X：" + m.ToString() + "  Y：" + n.ToString()  ;
                toolStripStatusLabel1.Text = "落子点：X " + m.ToString() + " Y " + n.ToString() + "";
            }
        }
        //落子时，更新落子记录
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bd.PersonPut(e.X, e.Y))
            {
                if (historylist.Items.Count == 0)
                {
                    historylist.Items.Add(bd.st.GetPersonPosStr());
                    historylist.Items.Add(bd.st.GetPCPosStr());
                }
                else
                {
                    if (historylist.Items[historylist.Items.Count - 1].ToString() != bd.st.GetPCPosStr() &&
                        historylist.Items[historylist.Items.Count - 2].ToString() != bd.st.GetPersonPosStr())
                    {
                        historylist.Items.Add(bd.st.GetPersonPosStr());
                        historylist.Items.Add(bd.st.GetPCPosStr());
                    }
                }
            }          
        }
        

        //开始新游戏
        private void NewGame_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                bd.Start(false);
            }
            else
            {
                bd.Start(true);
            }
            historylist.Items.Clear();
        }
        //设置玩家先手
        private void PersonFirst_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( !PersonFirst.Checked )
            {
                bd.Start(true);
                bd.pc.SetPC_Status(false);                        //改变电脑先手状态
                historylist.Items.Clear();
                PersonFirst.Checked = true;
                PCFirst.Checked = false;
                black.Text = "玩家";
                white.Text = "计算机";
                label2.Text = "1";
            }
        }
        //设置电脑先手
        private void PCFirst_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( !PCFirst.Checked )
            {
                bd.Start(false);
                bd.pc.SetPC_Status( true );                        //改变电脑先手状态
                historylist.Items.Clear();
                PCFirst.Checked = true;
                PersonFirst.Checked = false;
                black.Text = "计算机";
                white.Text = "玩家";
                label2.Text = "0";
            }
        }
        //设置简单难度
        private void Easy_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Easy.Checked)
            {
                bd.Start(true);
                bd.pc.SetPC_Level(false);                        //改变为简单难度
                historylist.Items.Clear();
                Easy.Checked = true;
                Hard.Checked = false;
            }
        }
        //设置困难难度
        private void Hard_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Hard.Checked)
            {
                bd.Start(true);
                bd.pc.SetPC_Level(true);                        //改变为困难难度
                historylist.Items.Clear();
                Hard.Checked = true;
                Easy.Checked = false;
            }
        }
        //退出游戏
        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //记事本打开Rules.txt文件
        private void Rule_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process Pnotepad = new Process();
            Pnotepad.StartInfo.FileName = "Rules.txt";
            Pnotepad.Start();
        }

        private void Retract_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //玩家先手，没有下棋，但点悔棋
            if (bd.st.st.top == -1)
                return;
            //电脑先手，玩家一步都没下就点悔棋
            if (bd.st.st.top == 0 && bd.pc.GetPC_Status() == true)
                return;
            
            //悔棋时，电脑方已经赢了，需重设 Winflag 才可继续下棋
            if (bd.GetWinflag())
                bd.SetWinflag(false);

            historylist.Items.RemoveAt(historylist.Items.Count - 1);
            historylist.Items.RemoveAt(historylist.Items.Count - 1);

            Pos pos = new Pos();

            pos = bd.st.GetTopPos();
            bd.st.Delete();
            bd.board[pos.x, pos.y] = -1;

            pos = bd.st.GetTopPos();
            bd.st.Delete();
            bd.board[pos.x, pos.y] = -1;

            //玩家先手，且第一手后悔棋时，程序执行到这，st栈已空
            if (bd.st.st.top != -1)
                pos = bd.st.GetTopPos();
            bd.DrawBoard();
            if (bd.st.st.top != -1)
                bd.stone.DrawTarget(pos.x, pos.y);          
        }

    }
}
