using System;

namespace carz
{
    public interface cars
    {
        float getmilage();

    }
    class SUV : cars
    {
        public float getmilage()
        {
            float Creta = 19;
            return Creta;
        }
    }
    class seden : cars
    {
        public float getmilage()
        {
            float city = 22;
            return city;
           
        }
    }
    class hatchback : cars
    {
        public float getmilage()
        {
            float indigo = 24;
            return indigo;
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            SUV cars1 = new SUV();
            Console.WriteLine("Creta mileage is " + cars1.getmilage()); 
            seden cars2=new seden();
            Console.WriteLine("City mileage is " + cars2.getmilage());
            hatchback cars3 = new hatchback();
            Console.WriteLine("indigo mileage is " + cars3.getmilage());
            Console.ReadKey();

            

        }

    }

}