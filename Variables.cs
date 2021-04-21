using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial1
{
    class Variables

    {
        public static decimal ACalculated;
        public static decimal BCalculated;
        public static decimal CCalculated;
        public static decimal DCalculated;
        public static decimal FCalculated;
        public static decimal JCalculated;
        public static decimal HCalculated;
        public static decimal ICalculated;
        public static decimal DistIn;
        public static decimal ListenerIdeal;
        public static decimal AIdeal;
        public static decimal BIdeal;
        public static decimal CIdeal;
        public static decimal DIdeal;
        public static decimal FIdeal;
        public static decimal JIdeal;
        public static decimal HIdeal;
        public static decimal IIdeal;
        public static string UnitsIn;



        public static string CalculateA(decimal Distance)
        {
            ACalculated = Convert.ToDecimal(Convert.ToDecimal(0.5773502692) * Distance);
            return Convert.ToString(ACalculated);

        }
        public static string CalculateB(decimal Width)
        {
            BCalculated = Convert.ToDecimal((Convert.ToDecimal(0.3639702343) * Convert.ToDecimal(Width*Convert.ToDecimal(.5))));
            return Convert.ToString(BCalculated);
        }

        public static string CalculateC(decimal Width, decimal A)
        {
            CCalculated = Convert.ToDecimal((Width*Convert.ToDecimal(.5))-A);
            return Convert.ToString(CCalculated);
        }

        public static string CalculateD(decimal Length, decimal Distance)
        {
            DCalculated = Convert.ToDecimal(Length - Distance);
            return Convert.ToString(DCalculated);
        }

        public static string CalculateF(decimal D, decimal B)
        {
            FCalculated = Convert.ToDecimal(D - B);
            return Convert.ToString(FCalculated);

        }

        public static string CalculateJ(decimal D)
        {
            JCalculated = Convert.ToDecimal(D * Convert.ToDecimal(0.83909963117));
            return Convert.ToString(JCalculated);

        }
        public static string CalculateH(decimal Width, decimal J)
        {
            HCalculated = Convert.ToDecimal(Width*Convert.ToDecimal(.5)-J);
            return Convert.ToString(HCalculated);

        }

        public static string CalculateI(decimal Width)
        {
            ICalculated = Convert.ToDecimal(Width * Convert.ToDecimal(.5) * Convert.ToDecimal(0.5773502692));
            return Convert.ToString(ICalculated);

        }

        public static string CalculateDistIn(decimal Distance)
        {
            DistIn = Convert.ToDecimal(Distance);
            return Convert.ToString(DistIn);


        }

        public static string CalcList(decimal Length)
        {
            ListenerIdeal = Convert.ToDecimal(Convert.ToDecimal(.68) * Length);
            return Convert.ToString(ListenerIdeal);


        }

        public static string CalcA(decimal Distance)
        {
            AIdeal = Convert.ToDecimal(Convert.ToDecimal(0.5773502692) * Distance);
            return Convert.ToString(AIdeal);

        }
        public static string CalcB(decimal Width)
        {
            BIdeal = Convert.ToDecimal((Convert.ToDecimal(0.3639702343) * Convert.ToDecimal(Width * Convert.ToDecimal(.5))));
            return Convert.ToString(BIdeal);
        }

        public static string CalcC(decimal Width, decimal A)
        {
            CIdeal = Convert.ToDecimal((Width * Convert.ToDecimal(.5)) - A);
            return Convert.ToString(CIdeal);
        }

        public static string CalcD(decimal Length, decimal Distance)
        {
            DIdeal = Convert.ToDecimal(Length - Distance);
            return Convert.ToString(DIdeal);
        }

        public static string CalcF(decimal D, decimal B)
        {
            FIdeal = Convert.ToDecimal(D - B);
            return Convert.ToString(FIdeal);

        }

        public static string CalcJ(decimal D)
        {
            JIdeal = Convert.ToDecimal(D * Convert.ToDecimal(0.83909963117));
            return Convert.ToString(JIdeal);

        }
        public static string CalcH(decimal Width, decimal J)
        {
            HIdeal = Convert.ToDecimal(Width * Convert.ToDecimal(.5) - J);
            return Convert.ToString(HIdeal);

        }

        public static string CalcI(decimal Width)
        {
            IIdeal = Convert.ToDecimal(Width * Convert.ToDecimal(.5) * Convert.ToDecimal(0.5773502692));
            return Convert.ToString(IIdeal);

        }

        public static string Units(string units)
        {
            UnitsIn = units;
            return UnitsIn;
        }





    }
}

