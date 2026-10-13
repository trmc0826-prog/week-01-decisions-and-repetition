for (int cycle = 1; cycle <= 30; cycle++)
{
    if (cycle % 4 == 0 && cycle % 6 == 0) 
    {
    Console.WriteLine("FULL SERVICE");
    }
        else if (cycle % 4 == 0)
    {
    Console.WriteLine("FILTER CHECK");
    }
        else if (cycle % 6 == 0)
    {
        Console.WriteLine("THRUSTER CHECK");
    }
        else 
    {
        Console.WriteLine(cycle);
    }
}
    // TODO: Skriv riktig resultat for cycle.
