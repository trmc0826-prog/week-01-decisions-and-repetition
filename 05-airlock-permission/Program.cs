bool hasSuit = true;
int oxygenPercent = 30;
int pressure = 101;
bool alarmActive = false;

// TODO: Kombiner alle kravene i ett logisk uttrykk.
bool canOpenAirlock = hasSuit == true
    && oxygenPercent >= 30 
    && pressure >= 90 
    && pressure <= 110 
    && alarmActive == false;

if (canOpenAirlock)
{
    Console.WriteLine("ACCESS GRANTED");
}
else
{
    Console.WriteLine("ACCESS DENIED");
}
