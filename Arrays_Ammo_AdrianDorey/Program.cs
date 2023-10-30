using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Ammo_AdrianDorey
{
    internal class Program
    {
        // declarations
        static int[] ammo;
        static int currentWeapon;

        static void Main(string[] args)
        {
            Console.WriteLine("Arrays - Ammo");
            Console.WriteLine("-------------");
            Console.WriteLine();
                        
            ammo = new int[4];
            ammo[0] = 50; // pistol
            ammo[1] = 20; // shotgun
            ammo[2] = 100; // spreader
            ammo[3] = 6; // rocket launcher

            currentWeapon = 0; // pistol

            


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        // 
        void Fire()
        {
            if (ammo[currentWeapon] <= 0) return;
            ammo[currentWeapon] -= 1;

        }

        void Reload(int ammoAmount)
        {
            ammo[currentWeapon] = ammo[currentWeapon] + ammoAmount;

            if (ammo[0] >= 50) // if pistol ammo is more than 50
            {
                ammo[0] = 50;
            }
            else if (ammo[1] >= 20) // if shotgun is more than 20
            {
                ammo[1] = 20;
            }
            else if (ammo[2] >= 100)    // if spreader is more than 100
            {
                ammo[2] = 100;
            }
            else if (ammo[3] >= 6)  // if rocket launcher is more than 6
            {
                ammo[3] = 6;
            }
        }
    }
}
