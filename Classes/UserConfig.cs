using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Classes
{
    public static class UserConfig
    {
        private static string theme;
        private static string mode;

        public static string Theme
        {
            get { return theme; }
            set
            {
                if (value == "light" || value == "dark" || value == "blue" || value == "pink" || value == "system")
                {
                    theme = value;
                }
                else
                {
                    theme = "light";
                }
            }
        }

        public static string Mode
        {
            get { return mode; }
            set
            {
                if (value == "standard" || value == "scientific")
                {
                    mode = value;
                }
                else
                {
                    mode = "standard";
                }
            }
        }
    }
}
