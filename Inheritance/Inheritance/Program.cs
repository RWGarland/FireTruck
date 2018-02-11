using System;

namespace FireTraining
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Firefighter joe = new Firefighter { Name = "Joe" };
            joe.ExtinguishFire();
            Firefighter bill = new TraineeFireFighter { Name = "Bill" };
            bill.ExtinguishFire();

            FireChief harry = new FireChief { Name = "Harry" , NumberOne = joe };
            Firefighter harryAsAFirefighter = harry;
            harry.ExtinguishFire();
            harryAsAFirefighter.ExtinguishFire();
            Console.ReadKey();
        }
    }
}
