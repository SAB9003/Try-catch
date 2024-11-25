// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number:");
string input = Console.ReadLine();

try
{
    try
    {
        float floatResult = Convert.ToSingle(input);
        Console.WriteLine("This number can be an float");
    }
    catch (OverflowException) { }
    catch (FormatException) { }

    try
    {
        double doubleResult = Convert.ToDouble(input);
        Console.WriteLine("This number can be an double");
    }
    catch (OverflowException) { }
    catch (FormatException) { }
    try
    {
        decimal decimalResult = Convert.ToDecimal(input);
        Console.WriteLine("This number can be an decimal");
    }
    catch (OverflowException) { }
    catch (FormatException) { }
    try
    {
        byte byteResult = Convert.ToByte(input);
        Console.WriteLine("This number can be an byte");
    }
    catch (OverflowException) { }
    catch (FormatException) { }
    try
    {
        short shortResult = Convert.ToInt16(input);
        Console.WriteLine("This number can be an short");
    }
    catch (OverflowException) { }
    catch (FormatException) { }
    try
    {
        int intResult = Convert.ToInt32(input);
        Console.WriteLine("This number can be an int");
    }
    catch (OverflowException) { }
    catch (FormatException) { }

    try
    {
        long longResult = Convert.ToInt64(input);
        Console.WriteLine("This number can be an long");
    }
    catch (OverflowException) { }
    catch (FormatException) { }
}

catch (Exception)
{
    Console.WriteLine("Error it's not a number");
}