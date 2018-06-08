using System;
using praticapoo;

namespace pratica_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree un garaje
            GarageClass garage = new GarageClass();

            //Cree 2 coches
            VehiculeClass coche1 = new VehiculeClass("Toyota", "Corolla");
            VehiculeClass coche2 = new VehiculeClass("Honda", "Civic");

            var rand = new Random();
            //Agregar Coche
            garage.checkin(coche1, "aceite");
            coche1.incOilConsumption();
            coche1.incFixTotal(rand.Next(100, 1000));
            garage.chekout();

            garage.checkin(coche2, "aceite");
            coche1.incOilConsumption();
            coche2.incFixTotal(rand.Next(100, 1000));
            garage.chekout();

            garage.checkin(coche2, "Frenos");
            coche2.incFixTotal(rand.Next(100, 1000));
            garage.chekout();

            garage.checkin(coche2, "Transmision");
            coche2.incFixTotal(rand.Next(100, 1000));
            garage.chekout();

            garage.checkin(coche1, "Bomba");
            coche1.incFixTotal(rand.Next(100, 1000));
            garage.chekout();

           

            Console.WriteLine("{0} - {1}: Total Gastado->{2}", coche1.brand, coche1.model, coche1.fixesAmountTotal);
            Console.WriteLine("{0} - {1}: Total Gastado->{2}", coche2.brand, coche2.model, coche2.fixesAmountTotal);


        }
    }
}
