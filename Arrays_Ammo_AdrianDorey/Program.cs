using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Ammo_AdrianDorey
{
    internal class Program
    {
        // declarations
        static string[] Weapon; //name of weapon
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

            Weapon = new string[4];
            Weapon[0] = "Pistol";
            Weapon[1] = "Shotgun";
            Weapon[2] = "Spreader";
            Weapon[3] = "Rocket Launcher";

            currentWeapon = 1; 

            ShowHUD();
            Fire();
            Fire();
            Fire();
            Fire();
            Fire();
            ShowHUD();
            Reload(3);
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Reload(2);
            ShowHUD();
            Fire();
            ShowHUD();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void Fire()
        {
            if (ammo[currentWeapon] > 0)
            {
                Console.WriteLine("Bang! Weapon fired!");
                Console.WriteLine();
                ammo[currentWeapon] -= 1;
            }
            else
            {
                Console.WriteLine("Weapon out of ammo, Reload!");
                Console.WriteLine();
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("Current Weapon: " + Weapon[currentWeapon]);
            Console.WriteLine("Amount of Ammo: " + ammo[currentWeapon]);
            Console.WriteLine("");
        }

        static void Reload(int ammoAmount)
        {
            ammo[currentWeapon] = ammo[currentWeapon] + ammoAmount;

            Console.WriteLine(Weapon[currentWeapon] + " got an extra " + ammoAmount + " rounds");
            Console.WriteLine();

            if (ammo[0] >= 50) // if pistol ammo is more than 50
            {
                Console.WriteLine("Pistol ammo is full");
                ammo[0] = 50;
            }
            else if (ammo[1] >= 20) // if shotgun is more than 20
            {
                Console.WriteLine("Shotgun ammo is full");
                ammo[1] = 20;
            }
            else if (ammo[2] >= 100)    // if spreader is more than 100
            {
                Console.WriteLine("Spreader ammo is full");
                ammo[2] = 100;
            }
            else if (ammo[3] >= 6)  // if rocket launcher is more than 6
            {
                Console.WriteLine("Rocket Launcher ammo is full");
                ammo[3] = 6;
            }
        }
    }
}
