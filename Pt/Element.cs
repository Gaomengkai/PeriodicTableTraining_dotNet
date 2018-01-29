using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt2
{
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
        public double GetZ()
        {
            return Libraries.numToZ[num];
        }
    }
}
