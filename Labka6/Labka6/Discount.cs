using System;
using System.Collections.Generic;
using System.Text;

namespace Labka6
{
    public class Discount : IDiscount
    {
        public double Prise_time(double prise, double disc)
        {
            string time = DateTime.Now.Hour.ToString();
            if ((Convert.ToUInt32(time) >= 21 && Convert.ToUInt32(time) <= 24) || (Convert.ToUInt32(time) >= 0 && Convert.ToUInt32(time) <= 5))
            {
                prise = prise - prise * disc;
                return prise;
            }
            else
            {
                return prise;
            }
        }
        public double Prise_card(double prise, double disc, bool card)
        {
            if (card == true)
            {
                prise = prise - prise * disc;
                return prise;
            }
            else
            {
                return prise;
            }
        }
        public double Prise_code(double prise, double disc, string promocode, List<string> promocod)
        {
            for (int i = 0; i < promocod.Count; i++)
            {
                if (promocod[i] == promocode)
                {
                    prise = prise - prise * disc;
                    i = promocod.Count + 1;
                }
            }
            return prise;
        }
        public double Prise_name(double prise, double disc, string name, List<string> Lname)
        {

            for (int i = 0; i < Lname.Count; i++)
            {
                if (Lname[i] == name)
                {
                    prise = prise - prise * disc;
                    i = Lname.Count + 1;

                }
            }
            return prise;
        }
        public double Prise(double prise,bool card ,string name,string promocod)
        {
            List<string> Lpromocode = new List<string>() { "asd", "dwq" };
            List<string> Lname = new List<string>() { "adam", "eva" };
            //time discount N%
            double N = 0.15;
            //name discount X%
            double X = 0.07;
            // promocode discount Y%
            double Y = 0.05;
            // card discount Z%
            double Z = 0.1;
            Discount discount = new Discount();
            prise = discount.Prise_time(prise, N);
            prise = discount.Prise_card(prise, Z, card);
            prise = discount.Prise_code(prise, Y, promocod, Lpromocode);
            prise = discount.Prise_name(prise, X, name, Lname);
            return prise;
        }

    }
}
