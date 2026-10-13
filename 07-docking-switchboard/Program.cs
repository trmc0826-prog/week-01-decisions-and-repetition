string dockingCode = "NORTH";
string instruction = "";

switch (dockingCode)
{
    case "NORTH":
    instruction = "Dock at Gate 1";
    break;

    case "EAST":
    instruction = "Dock at Gate 2";
    break;

    case "SERVICE":
    instruction = "Dock at maintenance bay";
    break;

    case "CLOSED":
    instruction = "Hold Position";
    break;

    default:
    instruction = "Unknown docking code";
    break;
}
// TODO: Bruk switch statement til å sette instruction.

Console.WriteLine(instruction);
