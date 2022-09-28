using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Enums;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;

public class FizzbuzzNumberDeterminedEvent
{
    public readonly FizzbuzzDetermineType DeterminedType;
    public readonly int N;

    public FizzbuzzNumberDeterminedEvent(FizzbuzzDetermineType determinedType, int n)
    {
        DeterminedType = determinedType;
        N = n;
    }
}