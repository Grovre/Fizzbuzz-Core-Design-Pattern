namespace Fizzbuzz_Core_Design_Pattern.Printer.Reactions;

public class PrinterWriteRequest
{
    public readonly bool NewLine;
    public readonly string ToWrite;

    public PrinterWriteRequest(string toWrite, bool newLine = true)
    {
        ToWrite = toWrite;
        NewLine = newLine;
    }
}