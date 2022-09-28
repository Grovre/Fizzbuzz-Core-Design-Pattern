using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Enums;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Modules;

public class FizzbuzzNumberDeterminer
{
    private readonly FizzbuzzContext _context;

    public FizzbuzzNumberDeterminer(FizzbuzzContext context)
    {
        _context = context;

        void DetermineRequestAction(object? sender, FizzbuzzDetermineNumberRequest rq)
        {
            Determine(rq.N);
        }

        _context.DetermineNumberRequestHandlers += DetermineRequestAction;
    }

    public void Determine(in int n)
    {
        var determineType = FizzbuzzDetermineType.Number;

        if (n % _context.Game?.FizzNumber == 0)
            determineType = FizzbuzzDetermineType.Fizz;
        if (n % _context.Game?.BuzzNumber == 0)
            determineType = determineType == FizzbuzzDetermineType.Fizz
                ? FizzbuzzDetermineType.Fizzbuzz
                : FizzbuzzDetermineType.Buzz;

        _context.FireNumberDeterminedEvent(this, new FizzbuzzNumberDeterminedEvent(determineType, n));
    }
}