using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminesWhetherString
{
    public class AllVersions
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
        public static string solutionIf(string s, string t)
        {
            // Strings are equal
            if (s == t) return "EQUAL";
            // Find difference in string lengths
            var delta = s.Length - t.Length;
            // Try swapping
            if (delta == 0)
            {
                var res = ChecSwap(s, t);

                if (res == "IMPOSSIBLE")
                {
                    res = ChecReplace(s, t);
                }
                return res;

            }
            // Try deleting
            else if (delta == 1)
            {
                return ChecDelete(s, t);

            }
            // Try inserting
            else if (delta == -1)
            {

                return ChecInsert(s, t);
            }
            // Strings are too different
            return "IMPOSSIBLE";
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

        public static bool solutionTrue(string S, string T)
        {
            if (S == null || T == null) { return false; }

            // Length of strings
            var m = S.Length;
            var n = T.Length;

            // difference between the length of both strings is more than one
            if (Math.Abs(m - n) > 1) { return false; }

            // counter of edits
            var edits = 0;
            //  current characters
            var i = 0;
            var j = 0;

            //loop till either string runs out
            while (i < m && j < n)
            {
                // if the current character of both strings doesn't match
                if (S[i] != T[j])
                {
                    // якщо довжина першого рядка більше тому переходимо на наступний символ першого рядка
                    if (m > n)
                    {
                        i++;
                    }
                    // якщо довжина другого рядка більше тому переходимо на наступний символ другого рядка
                    else if (m < n)
                    {
                        j++;
                    }
                    // якщо довжина однакова то переходимо на наступний символ у обох рядках
                    else
                    {
                        i++;
                        j++;
                    }

                    edits++;
                }
                // якщо символи співпадають то переходимо на наступний
                else
                {
                    i++; j++;
                }
            }

            // перевірка залишків першого рядка
            if (i < m)
            {
                edits++;
            }
            // перевірка залишків другого рядка
            if (j < n)
            {
                edits++;
            }

            return (edits == 1);
        }
    }
}
