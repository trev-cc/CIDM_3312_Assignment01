using System;
using System.Linq;
namespace NickNameGenerator
{
    class Program
    {
                static void Main(string[] args)
        {
            string[] nicknames = new string[26];

            nicknames[0] = "Dude";
            nicknames[1] = "Jones";
            nicknames[2] = "Annoyer";
            nicknames[3] = "Firecracker";
            nicknames[4] = "Happy";
            nicknames[5] = "Cracker";
            nicknames[6] = "Quick";
            nicknames[7] = "Slow";
            nicknames[8] = "Bro";
            nicknames[9] = "Man";
            nicknames[10] = "Annoyin'";
            nicknames[11] = "Smilin'";
            nicknames[12] = "Shriekin'";
            nicknames[13] = "Fast";
            nicknames[14] = "Jumpy";
            nicknames[15] = "Real";
            nicknames[16] = "Pro";
            nicknames[17] = "Destroyer";
            nicknames[18] = "Professional";
            nicknames[19] = "Fake";
            nicknames[20] = "Real";
            nicknames[21] = "Irate";
            nicknames[22] = "Hater";
            nicknames[23] = "Lover";
            nicknames[24] = "Childish";
            nicknames[25] = "Old";


            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();
           
            //splitting into first and last name
            string[] nameparts = name.Split(' ');
            string fName = nameparts[0];
            string lName = nameparts[1];
            //into character array
            char [] charA = fName.ToCharArray();
            char[] charB = lName.ToCharArray();
            //deciding name based off 4th char of first name and 3rd of last
            char c = charB[2];
            char q = charA[3];
            //into int value
            int index = (int)c % 32 - 1;
            int index1 = (int)q % 32 - 1;
            //displaying nickname
            Console.Write("Your new name is " + nicknames[index1]);
            Console.WriteLine(" " + nicknames[index]);

        }
    }
}
