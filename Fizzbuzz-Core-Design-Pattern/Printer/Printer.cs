using System.Runtime.CompilerServices;
using Fizzbuzz_Core_Design_Pattern.Printer.Reactions;

namespace Fizzbuzz_Core_Design_Pattern.Printer;

public class Printer
{
    private PrinterContext? _context;
    private readonly TextWriter _writer;

    public Printer(TextWriter writer)
    {
        _writer = writer;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void Print(in PrinterWriteRequest printerWriteRequest)
    {
        if (printerWriteRequest.NewLine)
            _writer.WriteLine(printerWriteRequest.ToWrite);
        else
            _writer.Write(printerWriteRequest.ToWrite);
        
        _context?.FirePrinterWriteEvent(this, 
            new PrinterWriteEvent(printerWriteRequest.ToWrite, printerWriteRequest.NewLine));
    }

    public void AttachPrinterToContext(PrinterContext context)
    {
        if (context.PrinterObj != null) throw new Exception("PrinterObj is already assigned");

        _context = context;
        context.PrinterObj = this;

        void CatchPrintRequests(object? sender, PrinterWriteRequest rq)
        {
            Print(rq);
        }

        context.WriteRequestHandlers += CatchPrintRequests;
    }
}