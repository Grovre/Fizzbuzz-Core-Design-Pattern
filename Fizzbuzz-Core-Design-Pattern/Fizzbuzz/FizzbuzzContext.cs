using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Modules;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Print;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz;

public class FizzbuzzContext
{
    private FizzbuzzNumberDeterminer _determiner;
    private FizzbuzzGame _game;
    private FizzbuzzStepPrinter _printer;

    public FizzbuzzContext()
    {
        
    }

    public event EventHandler<FizzbuzzDetermineNumberRequest> DetermineNumberRequestHandlers;
    public event EventHandler<FizzbuzzNumberDeterminedEvent> NumberDeterminedEventHandlers;
    public event EventHandler<FizzbuzzPrintRequest> PrintRequestHandlers;
    public event EventHandler<FizzbuzzPrintedEvent> PrintEventHandlers;
}