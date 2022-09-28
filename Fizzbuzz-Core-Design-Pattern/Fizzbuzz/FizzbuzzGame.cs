using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Enums;
using Fizzbuzz_Core_Design_Pattern.Fizzbuzz.Reactions.Determine;

namespace Fizzbuzz_Core_Design_Pattern.Fizzbuzz;

public class FizzbuzzGame
{
    private FizzbuzzContext _context;
    private FizzbuzzDetermineType _determineType;
    private int _n;

    public FizzbuzzGame(int from, int to, int fizzNumber = 3, int buzzNumber = 5)
    {
        From = from;
        To = to;
        FizzNumber = fizzNumber;
        BuzzNumber = buzzNumber;
    }

    public int From { get; }
    public int To { get; }
    public int FizzNumber { get; }
    public int BuzzNumber { get; }

    public void Play()
    {
        _n = From;
        while (_n < To)
        {
            _context.RequestDetermineNumber(this, new FizzbuzzDetermineNumberRequest(_n));
            Console.WriteLine(_n + ": " + _determineType);
            ProgressN();
        }
    }

    private void ProgressN()
    {
        _n++;
    }

    public void AttachGameToContext(FizzbuzzContext context)
    {
        if (context.Game != null) throw new Exception("Context already has a game");
        _context = context;
        _context.Game = this;

        void CatchNumberDeterminedEvent(object? sender, FizzbuzzNumberDeterminedEvent ev)
        {
            _determineType = ev.DeterminedType;
        }

        _context.NumberDeterminedEventHandlers += CatchNumberDeterminedEvent;
    }
}