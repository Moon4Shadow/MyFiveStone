using System;
using System.Collections.Generic;
using System.Text;

namespace MyFiveStone
{
    public struct Pos
    {
        public int x;
        public int y;
    }
    public class FiveStoneStack
    {
        
        //设置栈的大小
        public const int MAXSIZE = 5000;
        //FiveStone栈的结构
        public struct FSStack
        {
            //public string[] data;
            public Pos[] data;
            public int top;
        }

        //定义一个新FS栈
        public FSStack st = new FSStack();

        //初始化该FS栈
        public void CreateStack()
        {
            st.data = new Pos[250];
            st.top = -1;
        }

        //插入
        public bool Insert(int x, int y)
        {
            if (st.top == MAXSIZE - 1)
            {
                return false;
            }
            else
            {
                st.top++;
                st.data[st.top].x = x;
                st.data[st.top].y = y;
                return true;
            }
        }
        //删除
        public bool Delete()
        {
            if (st.top == -1)
            {
                return false;
            }
            else
            {
                st.top--;
                return true;
            }
        }
        //取栈顶
        public Pos GetTopPos()
        {
            return st.data[st.top];
        }

        //如果FS栈非空，则取出电脑落子记录
        public string GetPCPosStr()
        {
            if( st.top != -1 )
            {
                return GetPosStr( st.data[st.top] );
            }
            else
            {
                return "";
            }
        }
        //如果FS栈非空，且不止一个元素，则取出玩家落子记录
        public string GetPersonPosStr()
        {
            if( st.top != -1 && st.top > 0 )
            {
                return GetPosStr( st.data[st.top - 1] );
            }
            else
            {
                return "";
            }
        }

        public string GetPosStr( Pos pos )
        {
            return "X：" + pos.x + " Y：" + pos.y;
        }
    }
}
