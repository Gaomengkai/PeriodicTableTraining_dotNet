﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt2
{
    public static class Libraries
    {
        #region normal elements
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
            "钅喜","钅波","钅黑","鿏","鐽",
            "錀","鎶","鉨","钅夫","镆",
            "钅立","石田","气奥"
        };

        public static double[] numToZ =
        {
            0,
            1.007941,4.0026022,6.9412,9.0121823,10.8117,12.01078,14.00672,15.99943,18.99840325,20.17976,22.98976928,24.30506,26.98153868,28.08553,30.9737622,32.0655,35.4532,39.9481,39.09831,40.0784,44.9559126,47.8671,50.94151,51.99616,54.9380455,55.8452,58.9331955,58.69342,63.5463,65.394,69.7231,72.641,74.921602,78.963,79.9041,83.7982,85.46783,87.621,88.905852,91.2242,92.906382,95.942,97.9072,101.072,102.905502,106.421,107.86822,112.4118,114.8183,118.7107,121.7601,127.603,126.904473,131.2936,132.9054519,137.3277,138.905477,140.1161,140.907652,144.2423,145,150.362,151.9641,157.253,158.925352,162.5001,164.93322,167.2593,168.934212,173.043,174.9671,178.492,180.947882,183.841,186.2071,190.233,192.2173,195.0849,196.9665694,200.592,204.38332,207.21,208.98401,208.9824,209.9871,222.0176,223,226,227,232.038062,231.035882,238.028913,238.8486,242.8798,244.8594,246.911,248.9266,252.9578,253.9656,259.0046,260.0124,261.0202,264.0436,269.0826,270.0904,273.1138,274.1216,272.106,278.1528,283.1918,282.184,287.223,286.2152,291.1964,290.1888,295.2268,293.2116,299.2572
        };
        #endregion

        #region IMPORTANT Elements
        public static int[] importElements =
        {
            1,2,3,6,7,8,9,
            11,12,13,14,15,16,17,
            19,20,26,29,30,35,47,79,
            53,56,10
        };
        #endregion
    }
}
