using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminesWhetherString
{
    public static class Solution
    {

        public static string solution(string s, string t)
        {
            if (s == t) return "EQUAL";
            var delta = s.Length - t.Length;
            var res = "IMPOSSIBLE";
            switch (delta)
            {
                case 0:
                    res = ChecSwap(s, t);
                    if (res == "IMPOSSIBLE") 
                        res = ChecReplace(s, t);
                    break;
                case 1:
                    res = ChecDelete(s, t);
                    break;
                case -1:
                    res = ChecInsert(s, t);
                    break;
                default: break;
            }
            return res;

        }
      
        private static string ChecDelete(string s, string t)
        {
            var res = "IMPOSSIBLE";
            var arrS = s.ToCharArray();
            var arrT = t.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (arrS[i] != arrT[i])
                {
                    string arrss = new string(arrS);
                    var c = arrss.Substring(i, 1)[0];
                    if (c.ToString() == t)
                    {
                        res = "DELETE " + c;
                    }
                    else break;
                }
            }
            return res;
        }
        private static string ChecInsert(string s, string t)
        {
            var res = "IMPOSSIBLE";
            var arrS = s.ToCharArray();
            var arrT = t.ToCharArray();
            for (var i = 0; i < t.Length; i++)
            {
                if (arrS[i] != arrT[i])
                {
                    string arrSs = new string(arrS);
                    var newS = arrSs.Insert(i, arrT[i].ToString());
                    if (newS == t)
                    {
                        res = "INSERT " + newS[i];
                    }
                    else break;
                }
            }

            return res;

        }
        private static string ChecReplace(string s, string t)
        {
            var res = "IMPOSSIBLE";
            var arrS = s.ToCharArray();
            var arrT = t.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (arrS[i] != arrT[i])
                {
                    var tmpS = arrS;
                    var tmpT = arrT;
                    var tmp = arrS[i];
                    string arrSs = new string(arrS);
                    if (arrSs != t)
                    {
                        tmpS[i] = tmpT[i];
                        arrSs = new string(tmpS);
                        if (arrSs == t)
                        {
                            res = "REPLACE " + tmp + " " + arrT[i];
                        }
                    }
                    else break;
                }
            }

            return res;
        }
        private static string ChecSwap(string s, string t)
        {
            var res = "IMPOSSIBLE";
            var arrS = s.ToCharArray();
            var arrT = t.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (arrS[i] != arrT[i])
                {
                    var tmp = arrS[i];
                    arrS[i] = arrS[i + 1];
                    arrS[i + 1] = tmp;
                    string arrSs = new string(arrS);
                    if (arrSs == t)
                    {
                        res = "SWAP " + arrS[i + 1] + " " + arrS[i];
                    }

                    else break;
                }
            }
            return res;
        }

       
    }
}
