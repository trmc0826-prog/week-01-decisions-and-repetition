int energy = 130;
string classification;

if (energy >= 80)
{
    classification = "Critical!";
}
else if (energy < 20)
{
    classification = "Dormant";
}
else if (energy >= 20 && energy <= 49)
{
    classification = "Stable";
}
else
{
    classification = "Unstable";
}
// TODO: Sett classification med if / else if / else.
//Test minst `0`, `19`, `20`, `49`, `50`, `79`, `80`, `130`.

Console.WriteLine($"Classification: {classification}");
