namespace Fizzbuzz_Core_Design_Pattern.Printer.Reactions;

public class PrinterWriteEvent
{
    public readonly bool NewLine;
    public readonly string Wrote;

    public PrinterWriteEvent(string wrote, bool newLine)
    {
        Wrote = wrote;
        NewLine = newLine;
    }
}