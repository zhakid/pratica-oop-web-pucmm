using System;
namespace praticapoo
{
    public class VehiculeClass
    {
        private MotorClass motor { get; set; }
        public String brand { get; }
        public String model { get; }
        public double fixesAmountTotal { get; set; }


        public VehiculeClass(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
            this.motor = new MotorClass(model == "Civic" ? 10:20); ///Depends of brand and model
        }


        public double incFixTotal(double total) {
            return this.fixesAmountTotal += total;
        }

        public void incOilConsumption() {
            this.motor.oilLiter += 10; 
        }
    }
}
