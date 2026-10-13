int signalStrength = 69;

/*\
if (signalStrength >= 70)
{
    string status = "STRONG";
}
else
{
    string status = "WEAK";
}

Console.WriteLine(status); // status finnes ikke her
*/

// TODO: Lag en løsning der status kan brukes etter if/else.
string status;
if (signalStrength >= 70)
{
    status = "STRONG";
}
else
{
    status = "WEAK";
}

Console.WriteLine($"Signal status: {status}");
