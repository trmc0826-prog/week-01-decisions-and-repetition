int cargoWeight = 800;
int maxWeight = 800;
int containerCount = 4;
int expectedContainers = 5;

// TODO: Erstatt false med riktige sammenligningsuttrykk.
//bool isOverweight = false;
//bool isExactlyAtLimit = false;
//bool hasContainers = false;
//bool countDiffersFromExpected = false;

bool isOverweight = cargoWeight > maxWeight;
bool isExactlyAtLimit = cargoWeight == maxWeight; 
bool hasContainers = containerCount >= 1;
bool countDiffersFromExpected = containerCount != expectedContainers;


Console.WriteLine($"Overweight: {isOverweight}");
Console.WriteLine($"Exactly at limit: {isExactlyAtLimit}");
Console.WriteLine($"Has containers: {hasContainers}");
Console.WriteLine($"Unexpected count: {countDiffersFromExpected}");
