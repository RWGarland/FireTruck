using System;
using System.Windows;

namespace FireTraining
{
    class Firetruck
    {
        public Firefighter Driver { get; set;}

        //composition - the ladder is a built in part of the Firetruck
        readonly Ladder ladder = new Ladder { Length = 30.0 };
        /*After creating a 30-foot ladder for itself, the truck class uses with a read-only property to retrieve it. */
        public Ladder Ladder
        {
            get
            {
                return ladder;
            }
        }
         
        //Aggregation - the containing object (truck) no longer controls the creation and lifetime of its own piece of apparatus
        public Hose Hose { get; set; }


        public void Drive(String coordinates)
        {
            if (Driver == null)
            {
                //can't drive there
                return;
            }
            Console.WriteLine("Driving to {0}", coordinates);
        }
    }
}
