string signal = "CRIMSON";

switch (signal)
{
    case "CRIMSON":
    case "RED":
    case "SCARLET":
    Console.WriteLine ("Evacuate deck");
    break;

    case "AMBER":
    case "YELLOW":
    Console.WriteLine ("Prepare crew");
    break;

    case "GREEN":
    Console.WriteLine("No Emergency");
    break;

    default: 
    Console.WriteLine ("Unknown signal");
    break;
}

// TODO: Lag switch med kombinerte case-labels.

