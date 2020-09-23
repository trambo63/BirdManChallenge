using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_the_Bird_Man
{
    public class Program : Birds
    {
        static void Main(string[] args)
        {
            Birds birds = new Birds();

            string text = System.IO.File.ReadAllText(@"C:\ElevenFiftyProjects\game-sequence.txt");
            Console.WriteLine($"Bird score count:  {CountBird()}");
            Console.WriteLine($"Crested Ibis score count:  {CountCrestedIbis()}");
            Console.WriteLine($"Great Kiskudee score count:  {CountGreatKiskudee()}");
            Console.WriteLine($"Red-Necked Phalarope score count:  {CountRed_NeckedPhalarope()}");
            Console.WriteLine($"Red Crossbill score count:  {CountRedCrossbill()}");
            Console.WriteLine($"Evening Grosbeak score count:  {CountEveningGrosbeak()}");
            Console.WriteLine($"Greater Prairie Chicken score count:  {CountGreaterPrairieChicken()}");
            Console.WriteLine($"Iceland Gull score count:  {CountIcelandGull()}");
            Console.WriteLine($"Orange-Bellied Parrot score count:  {CountOrange_BelliedParrot()}");
            Console.WriteLine($"Vulnerable Bird Hunter count:  {CountVulnerableBirdHunter()}");
            Console.WriteLine($"Invincible Bird Hunter count:  {CountInvincibleBirdHunter()}");
            birds.Score = CountBird() + CountCrestedIbis() + CountGreatKiskudee() + CountRedCrossbill() + CountRed_NeckedPhalarope() + CountEveningGrosbeak() + CountGreaterPrairieChicken() + CountIcelandGull() + CountOrange_BelliedParrot();
            birds.Lives = CountInvincibleBirdHunter();
            Console.WriteLine("\n");
            birds.PrintScoreBoard();
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

            int CountBird()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getBird().ToLowerInvariant()
                                 select word; 
                int birdCount = matchQuery.Count();
                int count = birdCount * 10;
                return count;
            }

            int CountCrestedIbis()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getCrestedIbis().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 100;
                return count;
            }

            int CountGreatKiskudee()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getGreatKiskudee().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 300;
                return count;
            }

            int CountRedCrossbill()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getRedCrossbill().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 500;
                return count;
            }

            int CountRed_NeckedPhalarope()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getRed_NeckedPhalarope().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 700;
                return count;
            }

            int CountEveningGrosbeak()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getEveningGrosbeak().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 1000;
                return count;
            }

            int CountGreaterPrairieChicken()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getGreaterPrairieChicken().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 2000;
                return count;
            }

            int CountIcelandGull()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getIcelandGull().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 3000;
                return count;
            }

            int CountOrange_BelliedParrot()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getOrange_BelliedParrot().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount * 5000;
                return count;
            }

            int CountVulnerableBirdHunter()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getVulnerableBirdHunter().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int count = birdCount + 200 + 400 + 800 + 1600;
                return count;
            }

            int CountInvincibleBirdHunter()
            {
                string[] source = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == birds.getInvincibleBirdHunter().ToLowerInvariant()
                                 select word;
                int birdCount = matchQuery.Count();
                int lifeCount = birdCount - 5;
                return lifeCount;
            }

        }

    }
}
