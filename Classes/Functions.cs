using CalculatorProject.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Classes
{
    public static class Functions
    {
        public static List<string> history = new List<string>();
        public static List<double> memory = new List<double>();

        public static BigInteger Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static BigInteger nCr(int n, int r)
        {
            return Factorial(n) / Factorial(r) * Factorial(n - r);
        }

        public static double ConvertToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        public static void saveConfig()
        {
            StreamWriter sr = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "config.txt", false);
            try
            {
                using (sr)
                {
                    string line = $"Mode={UserConfig.Mode}/,Theme={UserConfig.Theme}/,";
                    sr.WriteLine(line);
                }
            }
            catch (IOException ex)
            {

            }
            finally
            {
                sr.Close();
            }
        }

        public static void readConfig()
        {
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "config.txt");
            try
            {
                using (sr)
                {
                    string line = sr.ReadLine();
                    string[] temp = line.Split(',');
                    for (int i = 0; i < temp.Length; i++)
                    {
                        int startIndex = temp[i].IndexOf("=") + 1;
                        int endIndex = temp[i].IndexOf('/');
                        switch (i)
                        {
                            case 0:
                                UserConfig.Mode = temp[i].Substring(startIndex, endIndex - startIndex);
                                break;
                            case 1:
                                UserConfig.Theme = temp[i].Substring(startIndex, endIndex - startIndex);
                                break;
                        }
                    }
                }
            }
            catch (IOException ex)
            {

            }
            finally
            {
                sr.Close();
            }
        }

        public static string getUserSystemTheme()
        {
            const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string appsUseLightThemeValue = "AppsUseLightTheme";

            object? value = Registry.GetValue(registryKey, appsUseLightThemeValue, null);

            if (value is int themeValue)
            {
                return themeValue == 1 ? "Light" : "Dark";
            }

            throw new InvalidOperationException("Unable to determine Windows theme.");
        }
    }
}
