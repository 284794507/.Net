using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newP = new Person();
            WoodWeapon newW = new WoodWeapon();
            newP.SetWeapon(newW);
            newP.ShowInfo();

            IornWeapon newIornW = new IornWeapon();
            newP.SetWeapon(newIornW);
            newP.ShowInfo();

            Console.ReadLine();
        }
    }
}
