using System;
using System.Diagnostics;


namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" The Hollow Night");
            ProcessStartInfo theProcess = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theProcess.Arguments = "https://i.imgur.com/mc1SHbe.gif";
            Process.Start(theProcess);
            Console.ReadKey();
            Console.WriteLine("In this world there exists the Hollow Night");
            Console.WriteLine(" this night exists another world of danger and peril. Only during the Red Moon, Voids, creatures of unimaginable power and a desire for distruction, come out to hunt humans.");
            Console.ReadKey();
            Console.WriteLine("Voids when they attack a human soul will cause extreme pain,  then insainty until the victim eventaully  evaporates.");
            Console.ReadKey();
            Console.WriteLine("However, If  you managed to survive the attack of a void, you become a being of Spiral energy, and granted the power to control existence. and this is where our story begins");
            ProcessStartInfo theProcess2 = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theProcess2.Arguments = "https://i2.wp.com/i.imgur.com/vsZ2M.gif";
            Process.Start(theProcess2);
            Console.ReadKey();
            Console.Write(" Here is our hero. They fight on behalf of the humans with their  powerful spiral energy [Enter Name]");
            string Hname = Console.ReadLine();
            superHero goodGuy = new superHero(Hname, 100, 15, 15);
            Console.WriteLine("{0} waits on the usual voids that come upon the hollow knight. However,{0} feels a strange different aura around the stormy alleyway.", Hname);
            Console.ReadKey();
            Console.WriteLine("From the shadows exist another Void user, however they use the anti spiral power to not only destroy voids, but everything humans included. the anti spiral users use their powers to one day take control of all the world governments");
            Console.ReadKey();
            Console.Write("{0}: Ha! so you have come to battle do you think I would forget you...... [enter name]", Hname);
            string Vname = Console.ReadLine();
            superVillain badGuy = new superVillain(Vname, 200, 20, 2);
            Console.ReadKey();
            Console.WriteLine("{0}: You think I would forget you {1}? I won't let you hurt anyone else! Prepare to fight!",Hname,Vname);
            Console.ReadKey();
            Console.WriteLine("{0}: Very well you and your Precous humanity can die by my hands!",Vname);
            int Herohp = goodGuy._hp;
            Herohp -= 20;
            Console.ReadKey();
            Console.WriteLine("{0}: ARRGH  he hit me for {1} hp! I wont take this standing down!! take this !", Hname, badGuy._strength);
            int Vilhp = badGuy._hp;
            Vilhp -= 2;
            Console.ReadKey();
            Console.WriteLine("{0}: HAAHAHAAHAH I still have {1} hp! with that type of hit do you think you can defeat me?", Vname, Vilhp);
            Console.ReadKey();





        }
    }
}
