using System;
using System.Collections.Generic;

namespace praticapoo
{
    public class GarageClass
    {
        VehiculeClass vehicule;
        String failure;
        public Dictionary<string, int> failureCount;

        private int capacity = 1; //Default garage size
        private int vehiculeInside = 0; // On premise vehicules

        public GarageClass()
        {
            failureCount = new Dictionary<string, int>();
        }

        /*
         * Constructor for dynamic sizing
         */
        public GarageClass(int capacity) {
            this.capacity = capacity;
            failureCount = new Dictionary<string, int>();
        }

        /*
         *  Checkin Vehicule to the garage
         */
        public void checkin(VehiculeClass vehicule, String failure) {
            if (checkAvailability()) {
                this.vehicule = vehicule;
                this.failure = failure;

                if(this.failureCount.ContainsKey(failure)) {
                    this.failureCount[failure]++;
                } else {
                    this.failureCount.Add(failure, 0);
                }

            }
        }


        /*
         * Check for garage empty space
         * Can modify to check which space is open
         */
        private Boolean checkAvailability() {
            if (vehiculeInside == capacity) {
                return false;
            }

            vehiculeInside++;
            return true;
        }

        /*
         * Checkout Vehicule from garage
         */
        public void chekout() {
            vehiculeInside--;
        }
    }
}
