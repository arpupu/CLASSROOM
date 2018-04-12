using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 班級名字表
{
    class Program
    {
        static void Main(string[] args)
        {   // 身高資料


            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };


            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int sum = 0;
            int sum1 = 0;


            for (int i = 0; i<gender.LongLength; i++)
            {
                if (gender[i] == "男")
                {
                    a += 1;
                }
                if (gender[i] == "女")
                {
                    b += 1;
                }
                
               

            }
            for (int p = 0; p < gender.LongLength; p++)
            {
                if (blood[p] == "O")
                {
                    c += 1;
                }
                if (blood[p] == "A")
                {
                    d += 1;
                }
                if (blood[p] == "B")
                {
                    e += 1;
                }
                if (blood[p] == "AB")
                {
                    f += 1;
                }

            }
            for(int l = 0; l < heights.Length; l++)
            {
                if (heights[l] > 100 && heights[l] < 200)
                {
                    if (gender[l] == "男")
                    {
                        sum = sum + heights[l];

                    }
                }
                {
                    if (gender[l] == "女")
                    {
                        sum1 = sum1 + heights[l];

                    }
                }
            }
            
            double  aa = (double)a / (double)gender.Length * 100 ;
            double  bb  = (double)b / (double)gender.Length * 100 ;
            double  cc = (double)c / (double)blood.Length * 100;
            double  dd = (double)d / (double)blood.Length * 100;
            double  ee = (double)e / (double)blood.Length * 100;
            double  ff = (double)f / (double)blood.Length * 100;
            double gg = (double)sum / a;
            double hh = (double)sum1 / b;
            double ii = (double)(sum + sum1) / (a + b);

            Console.WriteLine("男生人數" + a);
            Console.WriteLine("男生比例" + aa);
            Console.WriteLine("女生人數" + b);
            Console.WriteLine("女生比例" + bb);
            Console.WriteLine("O型人數" + c);
            Console.WriteLine("O型比例" + cc);
            Console.WriteLine("A型人數" + d);
            Console.WriteLine("A型比例" + dd);
            Console.WriteLine("B型人數" + e);
            Console.WriteLine("B型比例" + ee);
            Console.WriteLine("AB型人數" + f);
            Console.WriteLine("AB型比例" + ff);
            Console.WriteLine("男生身高平均" + gg);
            Console.WriteLine("女生身高平均" + hh);
            Console.WriteLine("全班身高平均" + ii);


            for (int k = 0; k < heights.Length; k++)
            {
                if (star[k] == "天蠍" && blood[k] == "O")
                {
                    Console.WriteLine(name[k]);
                }
            }





                Console.ReadKey();
            


            




            








        }
    }
}
