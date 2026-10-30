using System;
using cSH_hw_Delegate2;

class Program
{
    static void ShowTime()
    {
        Console.WriteLine("Current time: " + DateTime.Now.ToLongTimeString());
    }

    static void ShowDate()
    {
        Console.WriteLine("Current date: " + DateTime.Now.ToShortDateString());
    }

    static void ShowDay()
    {
        Console.WriteLine("Day of the week: " + DateTime.Now.DayOfWeek);
    }

    static double GetTriangleArea(double baseLength, double height)
    {
        return baseLength * height / 2;
    }

    static double GetRectangleArea(double length, double width)
    {
        return length * width;
    }

    static bool IsAreaPositive(double area)
    {
        return area > 0;
    }

    static void Main()
    {
        // Action timeDelegate = ShowTime;
        // Action dateDelegate = ShowDate;
        // Action dayDelegate = ShowDay;
        //
        // timeDelegate();
        // dateDelegate();
        // dayDelegate();
        //
        // Func<double, double, double> triangleDelegate = GetTriangleArea;
        // Func<double, double, double> rectangleDelegate = GetRectangleArea;
        //
        // Console.Write("Enter triangle base: ");
        // double baseLength = Convert.ToDouble(Console.ReadLine());
        //
        // Console.Write("Enter triangle height: ");
        // double height = Convert.ToDouble(Console.ReadLine());
        //
        // double triangleArea = triangleDelegate(baseLength, height);
        // Console.WriteLine("Triangle area: " + triangleArea);
        //
        // Predicate<double> areaCheck = IsAreaPositive;
        //
        // if (areaCheck(triangleArea))
        //     Console.WriteLine("Predicate: area is positive");
        // else
        //     Console.WriteLine("Predicate: area is not positive");
        //
        // Console.Write("Enter rectangle length: ");
        // double length = Convert.ToDouble(Console.ReadLine());
        //
        // Console.Write("Enter rectangle width: ");
        // double width = Convert.ToDouble(Console.ReadLine());
        //
        // double rectangleArea = rectangleDelegate(length, width);
        // Console.WriteLine("Rectangle area: " + rectangleArea);
        //2
        CreditCard card = new CreditCard(
                "1234567890123456",
                "Anna Smith",
                "12/28",
                "1234",
                1000,
                500);

            card.ShowInfo();

            card.AddMoney(200);
            card.CheckMoneyAmount(700);

            card.SpendMoney(900);
            card.ChangePin("1234", "4321");
        
    }
}