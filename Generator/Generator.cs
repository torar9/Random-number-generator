using System;
using System.Windows;

namespace Generator
{
    class GeneratorE
    {
        private int lowAmout;
        private int highAmout;
        private int finalNumber;
        private const sbyte maxNumber = 30;
        private sbyte numberAmout;
        private string message = "";
        private Random random;

        public GeneratorE(string lowAmout, string highAmout, string numberAmout)
        {
            try
            {
                this.lowAmout    = int.Parse(lowAmout);
                this.highAmout   = int.Parse(highAmout);
                this.numberAmout = sbyte.Parse(numberAmout);

                if (this.numberAmout < 0)
                    this.numberAmout *= -1;
                if (this.numberAmout > maxNumber)
                    this.numberAmout = maxNumber;


                random = new Random();
            }

            catch
            {
                MessageBox.Show("The entered parameters are too big!");
            }
        }

        public string Generate()
        {
            if (highAmout < lowAmout)
            { 
                MessageBox.Show("Mistakenly entered the upper limit!");
                return 0.ToString();
            }

            else
            {
                while(numberAmout != 0)
                {
                    finalNumber = random.Next(lowAmout, highAmout + 1);
                    message += finalNumber.ToString() + "  ";
                    
                    numberAmout--;
                }

                return message;
            }
        }

    }
}
