using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR1
{
    static public class MapEditor
    {
        static public bool KeyPressed(char sym, List<char> elems)
        {
            if(elems == null)
            {
                return true;
            }
            return !elems.Contains(sym);
        }

        static public string BorderChanged(string text, int maxSize)
        {
            uint num;
            try
            {
                num = uint.Parse(text);
            }
            catch
            {
                return "";
            }
            string answer = (num > maxSize) ? maxSize.ToString() : num.ToString();
            return answer;
        } 

        static public int CreateBorder(int initVal, string text, int maxSize)
        {
            int value = initVal;
            try
            {
                value = int.Parse(text);
            }
            catch
            {
                if (text == "")
                {
                    value = initVal;
                }
                else
                {
                    throw new ArgumentException("Not a number");
                }
            }
            return (value > maxSize) ? maxSize : value;
        }
    }
}
