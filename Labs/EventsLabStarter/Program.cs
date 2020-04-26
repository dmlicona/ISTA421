using System;

namespace EventsLabStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("At a lonely outpost in far off mountains...\n");

            Attacker a = new Attacker();
            a.Attack("snipers");

            Defender d = new Defender();
            d.ReturnFire("rifle fire");

            a.Attack("full auto rifle fire");
            d.ReturnFire("grenade launcher");

            //7. subscribe to UnderAttackEvent
            d.UnderAttackEvent += Responder.HelpDefender;

            string attackType = "heavy machine guns";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "moms bringing reinforcements in trucks";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "armored vehicles";
            a.Attack(attackType);
            d.CallForHelp(attackType);

            attackType = "SCUD missles";
            a.Attack(attackType);
            d.CallForHelp(attackType);
        }
    }

    class Attacker
    {
        public void Attack(string s)
        {
            Console.WriteLine($"A. Enemy attacks with {s}");
        }
    }

    public class Defender
    {
        //1. declare event handler
        public event EventHandler<string> UnderAttackEvent;
        //2. create get help method
        private void RaiseGetHelp(string weapon)
        {
            UnderAttackEvent?.Invoke(this, weapon);
        }
        public void ReturnFire(string s)
        {
            Console.WriteLine($"D. Defender responds with {s}\n");
        }

        public void CallForHelp(string weapon)
        {
            Console.WriteLine($"D. Help, we are under attack by {weapon}");
            //3. create call help method
            RaiseGetHelp(weapon);
            //4.   comment out the remainder of the method, it will be raised by the event

            //if (weapon == "heavy machine guns")
            //    Responder.MaDeuce(weapon);
            //if (weapon == "moms bringing reinforcements in trucks")
            //    Responder.Predator(weapon);
            //if (weapon == "armored vehicles")
            //    Responder.WartHog(weapon);
            //if (weapon == "SCUD missles")
            //    Responder.BUFF(weapon);
        }
    }

    public class Responder
    {
        public static void HelpDefender(object sender, string weapon)
        {
            if (weapon == "heavy machine guns")
                MaDeuce(weapon);
            else if (weapon == "moms bringing reinforcements in trucks")
                Predator(weapon);
            else if (weapon == "armored vehicles")
                WartHog(weapon);
            else if (weapon == "SCUD missles")
                BUFF(weapon);
        }
        private static void MaDeuce(string w)
        {
            Console.WriteLine($"Ma Deuce: 50 Cal opens up and smokes the Sons of Witches shooting {w}. Rat..tat...tat...\n");
        }
        private static void Predator(string w)
        {
            Console.WriteLine($"Predator: We just hellfired those mother trucking {w}. kaBOOM\n");
        }
        private static void WartHog(string w)
        {
            Console.WriteLine($"Wart Hog: We just shot the shift out of the {w} with our Gatling Gun. Zzzzzzip\n");
        }
        private static void BUFF(string w)
        {
            Console.WriteLine($"BUFF: The Big Ugly Fat Fuggers just obliterated the {w}\n");
        }
    }
}

