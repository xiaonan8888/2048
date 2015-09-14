using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class CL
    {
        private static int score;//得分

        public static int Score
        {
            get { return CL.score; }
        }
        public static bool isover(Qz[,] qz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (qz[i, j].Value == 0) return false;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (qz[i, j].Value == qz[i, j - 1].Value) return false;
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (qz[i, j].Value == qz[i - 1, j].Value) return false;
                }
            }
            return true;
        }
        public static void zj(Qz[,] qz)
        {
            int x, y;

            Random r = new Random();
            do{
                x = r.Next(0, 4);
                y = r.Next(0, 4);
            }while(qz[x, y].Value != 0);

            //qz[x, y].zj_Tick(null, null);
            qz[x, y].zj.Start();
            qz[x, y].Value = r.Next(0, 6) < 5 ? 2 : 4;//2、4出现的概率比为5:1
            
        }

        private static bool movelive(Qz[] q)
        {
            bool b = false;
            bool n = false;
            int x = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i].Value == 0) continue;

                if (n == false)
                {
                    if (x != i)
                    {
                        q[x].Value = q[i].Value;
                        q[i].Value = 0;
                        b = true;
                    }
                    n = true;
                }
                else
                {
                    if (q[i].Value == q[x].Value)
                    {
                        q[x].Value *= 2;
                        q[i].Value = 0;
                        CL.score += q[x].Value;//计算得分
                        q[x].hb.Start();//让棋子缩放
                        b = true;
                        x++;
                        n = false;
                    }
                    else
                    {
                        x++;
                        if (x != i)
                        {
                            q[x].Value = q[i].Value;
                            q[i].Value = 0;
                            b = true;
                        }
                    }
                }
            }
            return b;
        }
        public static bool up(Qz[,] qz)
        {
            bool b = false;
            CL.score = 0;
            for (int i = 0; i < 4; i++)
            {
                b = movelive(new Qz[4] { qz[0, i], qz[1, i], qz[2, i], qz[3, i] }) ? true : b;
            }
            return b;
        }
        public static bool down(Qz[,] qz)
        {
            bool b = false;
            CL.score = 0;
            for (int i = 0; i < 4; i++)
            {
                b = movelive(new Qz[4] { qz[3, i], qz[2, i], qz[1, i], qz[0, i] }) ? true : b;
            }
            return b;
        }
        public static bool left(Qz[,] qz)
        {
            bool b = false;
            CL.score = 0;
            for (int i = 0; i < 4; i++)
            {
                b = movelive(new Qz[4] { qz[i, 0], qz[i, 1], qz[i, 2], qz[i, 3] }) ? true : b;
            }
            return b;
        }
        public static bool right(Qz[,] qz)
        {
            bool b = false;
            CL.score = 0;
            for (int i = 0; i < 4; i++)
            {
                b = movelive(new Qz[4] { qz[i, 3], qz[i, 2], qz[i, 1], qz[i, 0] }) ? true : b;
            }
            return b;
        }
    }
}
