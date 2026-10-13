int energy = 71;

// TODO: Energy må være mellom 40 og 70, inklusive.
bool isStable = energy >= 40 && energy <= 70;


Console.WriteLine($"Reactor stable: {isStable}");


//Test: `39`, `40`, `55`, `70`, `71`.