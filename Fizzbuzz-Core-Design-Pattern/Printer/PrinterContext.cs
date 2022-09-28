using Fizzbuzz_Core_Design_Pattern.Printer.Reactions;

namespace Fizzbuzz_Core_Design_Pattern.Printer;

public class PrinterContext
{
    public Printer? PrinterObj { get; internal set; }

    public event EventHandler<PrinterWriteRequest>? WriteRequestHandlers;
    public event EventHandler<PrinterWriteEvent>? PrinterWriteEventHandlers;

    public void RequestPrinterWrite(object? sender, PrinterWriteRequest rq)
    {
        WriteRequestHandlers?.Invoke(sender, rq);
    }

    public void FirePrinterWriteEvent(object? sender, PrinterWriteEvent ev)
    {
        PrinterWriteEventHandlers?.Invoke(sender, ev);
    }
}