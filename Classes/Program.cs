namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //dot way 
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            //object initializer way
            var Mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            //passing in using constructor
            var chevy = new Car("Chevy", "Impala", 2001);
            var carList = new List<Car>() { myCar, Mazda, chevy };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model}{vehicle.Year}");
            }
        }
    }
}
