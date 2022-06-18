using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Desktop.Util
{
    public class TextBoxCheckUtil
    {
        public static int ValidateIntTextBox(string text)
        {
            int retNum;

            bool isNum = int.TryParse(text, out retNum);

            if (!isNum)
            {
                throw new Exception("Text box must be filled by int");
            }

            return retNum;
        }
        public static string ValidateStringTextBox(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new Exception("Text box must be filled");
            }
            else
            {
                return text;
            }
        }
    }
}
