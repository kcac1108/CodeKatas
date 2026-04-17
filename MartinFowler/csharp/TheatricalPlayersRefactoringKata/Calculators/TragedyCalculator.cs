using TheatricalPlayersRefactoringKata.Models;

namespace TheatricalPlayersRefactoringKata.Calculators
{
    public class TragedyCalculator : PerformanceCalculator
    {
        public TragedyCalculator(Performance performance, Play play)
            : base(performance, play) { }

        public override int Amount
        {
            get
            {
                var amount = 40000;
                if (Performance.Audience > 30)
                    amount += 1000 * (Performance.Audience - 30);
                return amount;
            }
        }
    }
}