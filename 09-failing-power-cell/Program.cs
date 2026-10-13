int charge = 24;
int drainPerCycle = 5;

// TODO: Bruk while til å simulere utladingen.

while (charge > 0)
{
    Console.WriteLine($"Current charge: {charge}%");
    charge -= drainPerCycle;
}

Console.WriteLine("Power cell offline.");
