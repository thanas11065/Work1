using System;

public class Program
{
    static void Main(string[] args)
    {
        string Name = InputName();
        long Number = InputNumber();
        string Owner_Name = InputOwnerName();
        long Registered_Value = InputRegisteredValue();
        Data data = new Data();
        data.OutputData(Name, Number, Owner_Name, Registered_Value);
        string baht = InputMoney();
        double Money = ConvertStringToDouble(baht);
        Change change = new Change();
        change.Calculator(Money);
    }

    public static string InputName()
    {
        Console.Write("Please Input Name: ");
        return Console.ReadLine();
    }
    public static long InputNumber()
    {
        Console.Write("Please Input Number: ");
        return long.Parse(Console.ReadLine());
    }
    public static string InputOwnerName()
    {
        Console.Write("Please Input Owner Name: ");
        return Console.ReadLine();
    }
    public static long InputRegisteredValue()
    {
        Console.Write("Please Input Registered Value: ");
        return long.Parse(Console.ReadLine());
    }
    public static string InputMoney()
    {
        Console.Write("Please Input Money: ");
        return Console.ReadLine();
    }
    public static double ConvertStringToDouble(string Registered_Value)
    {
        if (double.TryParse(Registered_Value, out double Number))
        {
            return Number;
        }
        throw new Exception("Please Input your Number again!");
    }
    public static double ConvertStringToDoubleRV(string Registered_Value)
    {
        if (double.TryParse(Registered_Value, out double Number))
        {
            return Number;
        }
        throw new Exception("Please Input your Registered_Value again!");
    }
    public static double ConvertStringToDoubleM(string Registered_Value)
    {
        if (double.TryParse(Registered_Value, out double Number))
        {
            return Number;
        }
        throw new Exception("Please Input your money again!");
    }
    public class Data
    {
        public void OutputData(string Name, long Number, string OwnerName, long RegisteredValue)
        {
            Console.WriteLine("—--------- Shop Information —---------");
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Number: {0}", Number);
            Console.WriteLine("Owner Name: {0}", OwnerName);
            Console.WriteLine("Registered Value: {0}", RegisteredValue);
            Console.WriteLine("—-----------------------------------------------------");
        }
    }
    public class Change
    {
        public void Calculator(double Money)
        {
            Money = Money * 100;

            int A, B, C, D, E, F, G, H, I, J, K, remain;

            A = (int)(Money / 100000);
            remain = (int)(Money % 100000);
            Console.WriteLine("1000: {0}", A);
            
            B = remain / 50000;
            remain = remain % 50000;
            Console.WriteLine("500 : {0}", B);
           
            C = remain / 10000;
            remain = remain % 10000;
            Console.WriteLine("100 : {0}", C);
           
            D = remain / 5000;
            remain = remain % 5000;
            Console.WriteLine(" 50 : {0}", D);
           
            E = remain / 2000;
            remain = remain % 2000;
            Console.WriteLine(" 20 : {0}", E);
           
            F = remain / 1000;
            remain = remain % 1000;
            Console.WriteLine(" 10 : {0}", F);
           
            G = remain / 500;
            remain = remain % 500;
            Console.WriteLine("  5 : {0}", G);
           
            H = remain / 200;
            remain = remain % 200;
            Console.WriteLine("  2 : {0}", H);
           
            I = remain / 100;
            remain = remain % 100;
            Console.WriteLine("  1 : {0}", I);
           
            J = remain / 50;
            remain = remain % 50;
            Console.WriteLine(".50 : {0}", J);
           
            K = remain / 25;
            remain = remain % 25;
            Console.WriteLine(".25 : {0}", K);
         
        }
    }
}
