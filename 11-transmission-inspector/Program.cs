string transmission = "AB#CD##EF##";
int interferenceCount = 0;

// TODO: Bruk foreach over transmission.

foreach (char character in transmission)
{
    if (character == '#')
    {
        interferenceCount++;
    }
}

Console.WriteLine($"Interference markers: {interferenceCount}");
