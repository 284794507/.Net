using IOCDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo
{
    public class WoodWeapon:IiocTest
    {
        public void Show()
        {
            Console.WriteLine("My material is wood!");
        }
    }
}
