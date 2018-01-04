using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    class Animal
    {
        public Animal()
        {

        }
        private string namn;
        private double vikt;
        private int ålder;
        class Dog:Animal
        {
            public string Type;
        }
        class Horse : Animal
        {
            public double Hairlength;
        }   
        class Hedgehog : Animal
        {
            public int NrOfSpikes;
        }
        class Worm : Animal
        {
            public bool IsPoisonous;
        }
        class Bird : Animal
        {
            public int WingSpan;
        }
        class Pelican : Bird
        {
            public double Length;
        }
         class Flamingo : Bird
        {
            public string Voice;
        }
        class Swan : Bird
        {
            public double BeakLength;
        }

        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public double Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }
        public int Ålder
        {
            get { return ålder; }
            set { ålder = value; }
        }

    }
}
