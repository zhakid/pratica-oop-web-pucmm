using System;
namespace praticapoo
{
    public class MotorClass
    {
        public int oilLiter { get; set; }
        public int power { get; set; }

        public MotorClass(int power)
        {
            this.power = power;
            this.oilLiter = 0;
        }
    }
}
