using System;
public class BaseCalculator
{
    public void Calculate()
    {
        Console.WriteLine("Виконування методу Calculate() базового класу BaseCalculator.");
    }
}
public class DerivedCalculator : BaseCalculator
{
    public new void Calculate()
    {
        Console.WriteLine("Виконується новий метод Calculate() похідного класу DerivedCalculator.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\nНатисніть Enter, щоб побачити роботу BaseCalculator...");
        Console.ReadLine();
        BaseCalculator baseCalc = new BaseCalculator();
        baseCalc.Calculate();
        Console.WriteLine("\nНатисніть Enter, щоб побачити роботу DerivedCalculator...");
        Console.ReadLine();
        DerivedCalculator derivedCalc = new DerivedCalculator();
        derivedCalc.Calculate();
        Console.WriteLine("\nНатисніть Enter, щоб побачити, що відбувається при приховуванні (BaseCalculator reference)...");
        Console.ReadLine();
        BaseCalculator hiddenCalc = new DerivedCalculator();
        hiddenCalc.Calculate();
        Console.WriteLine("\nДемонстрація завершена. Натисніть Enter для виходу.");
        Console.ReadLine();
    }
}