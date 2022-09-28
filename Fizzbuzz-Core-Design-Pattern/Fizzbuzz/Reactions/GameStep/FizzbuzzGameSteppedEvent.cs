namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.GameStep;

public class FizzbuzzGameSteppedEvent
{
    public readonly int CurrentStepNumber;
    public readonly FizzbuzzGame GameStepped;

    public FizzbuzzGameSteppedEvent(int currentStepNumber, FizzbuzzGame gameStepped)
    {
        CurrentStepNumber = currentStepNumber;
        GameStepped = gameStepped;
    }
}