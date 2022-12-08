using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{
    internal class MDigits
    {
        public int DP { get; set; }
        public int MP { get; set; }
        public MDigits(int dP, int mP)
        {
            DP = dP;
            MP = mP;
        }
        public MDigits() { }
        public static MDigits operator +(MDigits m1,MDigits m2)
        {
            return new MDigits() { DP = m1.DP + m2.MP, MP = m1.MP + m2.MP };
        }
        public static MDigits operator -(MDigits m1, MDigits m2)
        {
            return new MDigits() { DP = m1.DP - m2.MP, MP = m1.MP - m2.MP };
        }
        public static MDigits operator *(MDigits m1, MDigits m2)
        {
            return new MDigits() { DP = m1.DP * m2.MP - m1.MP*m2.MP, MP = m1.DP*m2.MP +m1.MP*m2.DP};
        }
        public static bool operator ==(MDigits d1, MDigits d2)
        {
            return d1.DP == d2.DP && d1.MP == d2.MP;
        }
        public static bool operator !=(MDigits d1, MDigits d2)
        {
            return d1.DP != d2.DP || d1.MP != d2.MP;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is MDigits d1)
                return DP == d1.DP && MP == d1.MP;
            return false;
        }
        public override string ToString()
        {
            string t = $"{DP} i{MP}";
            return t;
        }
    }
}
