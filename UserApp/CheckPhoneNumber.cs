using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace UserApp
{
    public class CheckPhoneNumber
    {
        public string checkNumber(string number)
        {
            string[] phoneNumber = Regex.Split(number, string.Empty);
            if (phoneNumber.Length - 2 == 12)
            {
                string[] data = new string[11];
                for (int i = 2; i < phoneNumber.Length; i++)
                {
                    data[i-2] = phoneNumber[i];
                    if (data.Length  == i-1)
                    {
                        break;
                    }
                }
                string datas = null;
                for (int i =0;i<data.Length;i++)
                {
                    datas = datas + data[i];
                }
                char[] ch = datas.ToCharArray();
                if (data[0]!="3")
                {
                    return "Prastas telefono numeris";
                }
                if (data[1]!="7")
                {
                    return "Prastas telefono numeris";
                }
                if (data[2]!="0")
                {
                    return "Prastas telefono numeris";
                }
                foreach(char c in ch)
                {
                    if (char.IsLetter(c))
                    {
                        return "Prastas telefono numeris";
                    }
                }
            }

            else if (phoneNumber.Length - 2 == 9)
            {
                char[] a = number.ToCharArray();
                if (phoneNumber[1]!="8")
                {
                    return "Prastas telefono numeris";
                }
                if (phoneNumber[2]!="6")
                {
                    return "Prastas telefono numeris";
                }
                foreach (char c in a)
                {
                    if (c < '0' || c > '9')
                    {
                        return "Prastas telefono numeris";
                    }
                }
            }
            else return "Prastas telefono numeris";


            return "Good";
        }
    }
}