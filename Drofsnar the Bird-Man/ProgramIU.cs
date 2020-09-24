using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_the_Bird_Man
{
    public class ProgramIU : Birds
    {
        public void Run()
        {
            Birds birds = new Birds();

            Console.WriteLine($"Bird score count:  {birds.CountBird()}");
            Console.WriteLine($"Crested Ibis score count:  {birds.CountCrestedIbis()}");
            Console.WriteLine($"Great Kiskudee score count:  {birds.CountGreatKiskudee()}");
            Console.WriteLine($"Red-Necked Phalarope score count:  {birds.CountRed_NeckedPhalarope()}");
            Console.WriteLine($"Red Crossbill score count:  {birds.CountRedCrossbill()}");
            Console.WriteLine($"Evening Grosbeak score count:  {birds.CountEveningGrosbeak()}");
            Console.WriteLine($"Greater Prairie Chicken score count:  {birds.CountGreaterPrairieChicken()}");
            Console.WriteLine($"Iceland Gull score count:  {birds.CountIcelandGull()}");
            Console.WriteLine($"Orange-Bellied Parrot score count:  {birds.CountOrange_BelliedParrot()}");
            Console.WriteLine($"Vulnerable Bird Hunter count:  {birds.CountVulnerableBirdHunter()}");
            Console.WriteLine($"Invincible Bird Hunter count:  {birds.CountInvincibleBirdHunter()}");
            //birds.Score = CountBird() + CountCrestedIbis() + CountGreatKiskudee() + CountRedCrossbill() + CountRed_NeckedPhalarope() + CountEveningGrosbeak() + CountGreaterPrairieChicken() + CountIcelandGull() + CountOrange_BelliedParrot();
            //birds.Lives = CountInvincibleBirdHunter();
            //Console.WriteLine("\n");
            birds.PrintScoreBoard();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
