using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
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

    public class Functions
    {
        public static List<string> Get_Adjecent(string strButton)
        {
            var lstAdjacent = new List<string>();

            int n = Convert.ToInt32(strButton);

            lstAdjacent.Add(strButton);

            if ((n + 1) < 26 && (n + 1) > 0 && n % 5 != 0) //n between 1 and 25 AND not divisible by 5
            {
                lstAdjacent.Add((n + 1).ToString());
            }

            if ((n - 1) < 26 && (n - 1) > 0 && (n - 1) % 5 != 0) //(n-1) between 1 and 25 AND not divisible by 5
            {
                lstAdjacent.Add((n - 1).ToString());
            }

            if ((n + 5) < 26 && (n + 5) > 0)
            {
                lstAdjacent.Add((n + 5).ToString());
            }

            if ((n - 5) < 26 && (n - 5) > 0)
            {
                lstAdjacent.Add((n - 5).ToString());
            }

            return lstAdjacent;

        }

        public static string[,] Update_Buttons(List<string> lstAdjacent, string[,] arrBtnVal)
        {
            string[,] arrBtnValUpdated = new string[25, 2];
            arrBtnValUpdated = arrBtnVal;

            foreach (var strButton in lstAdjacent)
            {
                int i = Convert.ToInt32(strButton);

                //change the values
                if (arrBtnValUpdated[i - 1, 1] == "0")
                {
                    arrBtnValUpdated[i - 1, 1] = "1";
                }
                else
                {
                    arrBtnValUpdated[i - 1, 1] = "0";
                }

            }

            return arrBtnValUpdated;
        }


    }

}
