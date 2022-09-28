namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.GameStep;

public class FizzbuzzGameStepRequest
{
    public readonly FizzbuzzGame GameToStep;

    public FizzbuzzGameStepRequest(FizzbuzzGame gameToStep)
    {
        GameToStep = gameToStep;
    }
}