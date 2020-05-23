using System;
using System.Collections.Generic;
using System.Text;

namespace Labka6
{
    interface IDiscount
    {
        double Prise_time(double prise,double disc);
        double Prise_card(double prise,double disc,bool card);
        double Prise_code(double prise,double disc,string promocod, List<string> Lpromocode);
        double Prise_name(double prise,double disc,string name, List<string> Lname);
        double Prise(double prise, bool card, string name, string promocod);
    }
}
