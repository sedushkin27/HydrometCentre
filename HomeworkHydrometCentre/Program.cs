using System.Reflection.Metadata;

namespace HomeworkHydrometCentre
{
    struct TemperatureInformation
    {
        public string Date { get; set; }
        public double C { get; set; }
        public double F { get; set; }
        public double K { get; set; }

        public TemperatureInformation(string date, double c, double f, double k) 
        { 
            Date = date;
            C = c;
            F = f;
            K = k;
        }

        public void GetInfo() 
        {
            Console.WriteLine($"for the date {Date} has been recorded in Celsius: {C}, Forringeit: {F} and Kelvin: {K}.");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HydrometCentre hydrometCentre = new HydrometCentre();
            
            bool works = true;
            while (works)
            {
                Console.WriteLine("choose what you want");
                Console.WriteLine("1-if you're an admin");
                Console.WriteLine("2-see the temperature for a particular day");
                Console.WriteLine("3-find out the temperature for a certain period");
                Console.WriteLine("0-exit");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        {
                            Console.WriteLine("1-enter new temperature information");
                            Console.WriteLine("2-delete date information");
                            Console.WriteLine("3-display all information ");
                            Console.WriteLine("0-exit");
                            string selection2 = Console.ReadLine();

                            switch (selection2)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("enter the date");
                                        string date = Console.ReadLine();

                                        Console.WriteLine("enter the temperature in Celsius ");
                                        double C = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("enter the temperature in Fahrenheit ");
                                        double F = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("enter the temperature in Kelvin");
                                        double K = Convert.ToDouble(Console.ReadLine());

                                        hydrometCentre.AddTemperatureInformation(date, C, F, K);
                                        break;
                                    }
                                case "2":
                                    {
                                        Console.WriteLine("enter the date you want to delete");
                                        string date = Console.ReadLine();

                                        hydrometCentre.RemoveTemperatureInformation(date);
                                        break;
                                    }
                                case"3":
                                    {
                                        hydrometCentre.PrintAllTemperatureInformation();
                                        break;
                                    }
                                case"0":
                                    {
                                        works = false;
                                        break;
                                    }
                                default:
                                    Console.WriteLine("error try again make a selection (enter 1, 2, 3, 0)");
                                    break;
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("enter the date for which you want to know the temperature ");
                            string date = Console.ReadLine();

                            hydrometCentre.GetTempretureByDate(date);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("enter from which date you want to know the temperature ");
                            string start = Console.ReadLine();

                            Console.WriteLine("enter the date for which you want to know the temperature ");
                            string end = Console.ReadLine();

                            hydrometCentre.GetTempretureByPeriod(start, end);
                            break;
                        }
                    case "0":
                        works = false;
                        break;
                    default:
                        Console.WriteLine("error try again make a selection (enter 1, 2, 3, 0)");
                        break;
                }
            }
        }
    }
}