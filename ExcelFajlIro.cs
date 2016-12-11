using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFajlIro
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("SzabadságJelentés.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            //=ÖSSZEFŰZ(HA(ÁPOLÓ!$C3="SZ";ÁPOLÓ!$C$1&",";"");...........AG-ig
            byte i = 3;
            char c;
            for (i = 3; i < 52; i+=2)
            {
                for (c = 'c'; c <= 'z'; c++)
                {
                    sw.WriteLine("====ÁPOLÓ====Sor#: " + i + " ====");
                    //első sor
                    sw.WriteLine("=ÖSSZEFŰZ(HA(ÁPOLÓ!$C" + i + "=\"SZ\";ÁPOLÓ!$C$1&\",\";\"\");");
                    //többi sor
                    sw.WriteLine("HA(ÁPOLÓ!$" + c + i + "=\"SZ\";ÁPOLÓ!");
                    sw.WriteLine();
                }
                for (c = 'c'; c <= 'z'; c++)
                {
                    sw.WriteLine("====GÉPÉSZ====Sor#: " + i + " ====");
                    sw.WriteLine();
                    sw.WriteLine("=ÖSSZEFŰZ(HA(GÉPKOCSIVEZETŐ!$" + c + i + "=\"SZ\";GÉPKOCSIVEZETŐ!$" + c + "$1&\",\";\"\")");
                }
                for (c = 'c'; c <= 'z'; c++)
                {
                    sw.WriteLine("====TISZT====Sor#: " + i + " ====");
                    sw.WriteLine();
                    sw.WriteLine("=ÖSSZEFŰZ(HA(TISZT!$" + c + i + "=\"SZ\";TISZT!$" + c + "$1&\",\";\"\")");
                }
            }
        }
    }
}
