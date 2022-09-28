using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Modules;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz;

public class FizzbuzzContext
{
    public FizzbuzzContext()
    {
        Determiner = new FizzbuzzNumberDeterminer(this);
    }

    public FizzbuzzNumberDeterminer Determiner { get; }
    public FizzbuzzGame? Game { get; internal set; }

    public event EventHandler<FizzbuzzDetermineNumberRequest>? DetermineNumberRequestHandlers;
    public event EventHandler<FizzbuzzNumberDeterminedEvent>? NumberDeterminedEventHandlers;

    public void RequestDetermineNumber(object? sender, FizzbuzzDetermineNumberRequest rq)
    {
        DetermineNumberRequestHandlers?.Invoke(sender, rq);
    }

    public void FireNumberDeterminedEvent(object? sender, FizzbuzzNumberDeterminedEvent ev)
    {
        NumberDeterminedEventHandlers?.Invoke(sender, ev);
    }
}