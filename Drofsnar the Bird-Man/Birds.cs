using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drofsnar_the_Bird_Man
{
    public class Birds
    {
        public string Bird { get; set; }
        public string CrestedIbis { get; set; }
        public string GreatKiskudee { get; set; }
        public string RedCrossbill { get; set; }
        public string Red_NeckedPhalarope { get; set; }
        public string EveningGrosbeak { get; set; }
        public string GreaterPrairieChicken { get; set; }
        public string IcelandGull { get; set; }
        public string Orange_BelliedParrot { get; set; }
        public string VulnerableBirdHunter { get; set; }
        public string InvincibleBirdHunter { get; set; }
        public int Score { get; set; }
        public int Lives { get; set; }

        public Birds()
        {
            Bird = "Bird";
            CrestedIbis = "CrestedIbis";
            GreatKiskudee = "GreatKiskudee";
            RedCrossbill = "RedCrossbill";
            Red_NeckedPhalarope = "Red-neckedPhalarope";
            EveningGrosbeak = "EveningGrosbeak";
            GreaterPrairieChicken = "GreaterPrairieChicken";
            IcelandGull = "IcelandGull";
            Orange_BelliedParrot = "Orange-belliedParrot";
            VulnerableBirdHunter = "VulnerableBirdHunter";
            InvincibleBirdHunter = "InvincibleBirdHunter";
            Score = 5000;
            Lives = 3;
        }

        public string getBird()
        {
            return Bird;
        }

        public string getCrestedIbis()
        {
            return CrestedIbis;
        }

        public string getGreatKiskudee()
        {
            return GreatKiskudee;
        }

        public string getRedCrossbill()
        {
            return RedCrossbill;
        }

        public string getRed_NeckedPhalarope()
        {
            return Red_NeckedPhalarope;
        }

        public string getEveningGrosbeak()
        {
            return EveningGrosbeak;
        }

        public string getGreaterPrairieChicken()
        {
            return GreaterPrairieChicken;
        }

        public string getIcelandGull()
        {
            return IcelandGull;
        }

        public string getOrange_BelliedParrot()
        {
            return Orange_BelliedParrot;
        }

        public string getVulnerableBirdHunter()
        {
            return VulnerableBirdHunter;
        }

        public string getInvincibleBirdHunter()
        {
            return InvincibleBirdHunter;
        }

        //public void AddBird()
        //{
        //    Score += 10;
        //}

        //public void AddCrestedIbis()
        //{
        //    Score += 100;
        //}

        //public void AddGreatKiskudee()
        //{
        //    Score += 300;
        //}

        //public void AddRedCrossbill()
        //{
        //    Score += 500;
        //}

        //public void AddRed_NeckedPhalarope()
        //{
        //    Score += 700;
        //}

        //public void AddEveningGrosbeak()
        //{
        //    Score += 1000;
        //}

        //public void AddGreaterPrairieChicken()
        //{
        //    Score += 2000;
        //}

        //public void AddIcelandGull()
        //{
        //    Score += 3000;
        //}

        //public void AddOrange_BelliedParrot()
        //{
        //    Score += 5000;
        //}

        //public void AddVulnerableBirdHunter()
        //{
        //    Score += 200;
        //}
        
        public void PrintScoreBoard()
        {
            Console.WriteLine($"Score: {Score}| Lives: {Lives}" );
        }
    }
}
