using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace UserApp
{
    public class CheckPersonalCode
    {
        public string checkCode(string code, string lytis)
        {
            string[] asmensKodas = Regex.Split(code, string.Empty);
            char[] a = code.ToCharArray();
            if (asmensKodas.Length - 2 == 11)
            {
                foreach (char c in a)
                {
                    if (c < '0' || c > '9')
                    {
                        return "Prastas asmens kodas";
                    }
                }
            }
            else return "Prastas asmens kodas";

            if (asmensKodas[1] == "1" || asmensKodas[1] == "2" || asmensKodas[1] == "3" || asmensKodas[1] == "4" || asmensKodas[1] == "5" || asmensKodas[1] == "6")
            {

            }
            else return "Prastas asmens kodas";

            if (lytis =="Vyras")
            {
                if (asmensKodas[1] == "1" || asmensKodas[1] == "3" || asmensKodas[1] == "5")
                {

                }
                else return "Prastas asmens kodas";
            }
            else
            {
                if (asmensKodas[1] == "2" || asmensKodas[1] == "4" || asmensKodas[1] == "6")
                {

                }
                else return "Prastas asmens kodas";
            }
            string[] data = new string[11];
            for (int i =0;i<data.Length;i++)
            {
                data[i] = asmensKodas[i + 1];
            }
            int[] myCode = Array.ConvertAll(data, int.Parse);
            float cal = (myCode[0] * 1) + (myCode[1] * 2) + (myCode[2] * 3) + (myCode[3] * 4) + (myCode[4] * 5) + (myCode[5] * 6) + (myCode[6] * 7) + (myCode[7] * 8) + (myCode[8] * 9) + (myCode[9] * 1);
            float cal1 = (myCode[0] * 3) + (myCode[1] * 4) + (myCode[2] * 5) + (myCode[3] * 6) + (myCode[4] * 7) + (myCode[5] * 8) + (myCode[6] * 9) + (myCode[7] * 1) + (myCode[8] * 2) + (myCode[9] * 3);
            double datas = cal % 11;

            if (datas ==10)
            {
                double dat = cal1 % 11;
                if (dat==10)
                {
                    if (myCode[10] == 0)
                    {

                    }
                    else return "Prastas asmens kodas";
                }
                else
                {
                    if (myCode[10] == dat)
                    {

                    }
                    else return "Prastas asmens kodas";
                }
            }
            else
            {
                if (myCode[10] == datas)
                {

                }
                else return "Prastas asmens kodas";
            }


            return "Good";
        }
    }
}