using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pt2
{
    public static class Libraries
    {
        public static String[] numToSign = {
            "000",
            "H","He","Li","Be","B",
            "C","N","O","F","Ne",
            "Na","Mg","Al","Si","P",
            "S","Cl","Ar","K","Ca",
            "Sc","Ti","V","Cr","Mn",
            "Fe","Co","Ni","Cu","Zn",
            "Ga","Ge","As","Se","Br",
            "Kr","Rb","Sr","Y","Zr",
            "Nb","Mo","Tc","Ru","Rh",
            "Pd","Ag","Cd","In","Sn",
            "Sb","Te","I","Xe","Cs",
            "Ba","La","Ce","Pr","Nd",
            "Pm","Sm","Eu","Gd","Tb",
            "Dy","Ho","Er","Tm","Yb",
            "Lu","Hf","Ta","W","Re",
            "Os","Ir","Pt","Au","Hg",
            "Tl","Pb","Bi","Po","At",
            "Rn","Fr","Ra","Ac","Th",
            "Pa","U","Np","Pu","Am",
            "Cm","Bk","Cf","Es","Fm",
            "Md","No","Lr","Rf","Db",
            "Sg","Bh","Hs","Mt","Ds",
            "Rg","Cn","Nh","Fl","Mc",
            "Lv","Ts","Og","Uue","Ubn"
        };

        public static String[] numToName = {
        "000",
        "氢","氦","锂","铍","硼",
        "碳","氮","氧","氟","氖",
        "钠","镁","铝","硅","磷",
        "硫","氯","氩","钾","钙",
        "钪","钛","钒","铬","锰",
        "铁","钴","镍","铜","锌",
        "镓","锗","砷","硒","溴",
        "氪","铷","锶","钇","锆",
        "铌","钼","碍","钌","铑",
        "钯","银","镉","铟","锡",
        "锑","碲","碘","氙","铯",
        "钡","镧","铈","镨","钕",
        "钷","钐","铕","钆","铽",
        "镝","钬","铒","铥","镱",
        "镥","铪","钽","钨","铼",
        "锇","铱","铂","金","汞",
        "铊","铅","铋","钋","砹",
        "氡","钫","镭","锕","钍",
        "镤","铀","镎","钚","镅",
        "锔","锫","锎","锿","镄",
        "钔","锘","铹","鈩","钅杜",
        "𬭳","𬭛","𬭶","鿏","鐽",
        "錀","鎶","鉨","𫓧","镆",
        "𫟷","石田","气奥"
        };
    }

    public class Element
    {
        public static int num;
        public static bool isSucceed = false;
        public Element(int n)
        {
            num = n;
        }

        public String GetName()
        {
            return Libraries.numToName[num];
        }
        public String GetSign()
        {
            return Libraries.numToSign[num];
        }
        public int GetNum()
        {
            return num;
        }
        public bool GetResult()
        {
            return isSucceed;
        }
        public Element(String str)
        {
            int i = 1;
            while (i <= 120)
            {
                if (str.Equals(Libraries.numToSign[i]))
                {
                    break;
                }
                i += 1;
            }
            if (i >= 121)
            {
                isSucceed = false;
                num = 0;
            }
            isSucceed = true;
            num = i;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
