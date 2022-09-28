using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Modules;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;
using Fizzbuzz_Core_Design_Pattern.Printer;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz;

public class FizzbuzzContext
{
    public FizzbuzzContext()
    {
        Determiner = new FizzbuzzNumberDeterminer(this);
    }

    public FizzbuzzNumberDeterminer Determiner { get; }
    public FizzbuzzGame? Game { get; internal set; }

    private Printer.Printer? PrinterObj { get; set; }
    
    public PrinterContext? PrinterContext { get; set; }

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

    public void SetupPrinter(TextWriter writer)
    {
        PrinterObj = new Printer.Printer(writer);
        PrinterContext = new PrinterContext();
        PrinterObj.AttachPrinterToContext(PrinterContext);
    }
}