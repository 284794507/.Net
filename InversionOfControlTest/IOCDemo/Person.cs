using IOCDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo
{
    public class Person
    {
        IiocTest myWeapon;

        public void SetWeapon(IiocTest newWeapon)
        {
            myWeapon = newWeapon;
        }

        public void ShowInfo()
        {
            myWeapon.Show();
        }
    }
}
