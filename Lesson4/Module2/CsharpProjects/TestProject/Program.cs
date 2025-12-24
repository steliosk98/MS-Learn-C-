/**
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

//Loop through the array of string and split to decimal array and string array
decimal[] decimalValues = new decimal[values.Length];
string[] stringValues = new string[values.Length];

for (int i = 0; i < values.Length; i++)
{
    if (decimal.TryParse(values[i], out decimal result))
    {
        decimalValues[i] = result;
        stringValues[i] = null;
    }
    else
    {
        decimalValues[i] = 0;
        stringValues[i] = values[i];
    }
}

//Output "Message: ABCDEF" and "Total: 68.3"
string message = "Message: ";
decimal total = 0;    

for (int i = 0; i < values.Length; i++)
{
    if (stringValues[i] != null)
    {
        message += stringValues[i];
    }
    total += decimalValues[i];
}
Console.WriteLine(message);
Console.WriteLine($"Total: {total}");