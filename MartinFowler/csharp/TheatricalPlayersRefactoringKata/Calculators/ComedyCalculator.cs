using System;
using TheatricalPlayersRefactoringKata.Models;

namespace TheatricalPlayersRefactoringKata.Calculators
{
    public class ComedyCalculator : PerformanceCalculator
    {
        public ComedyCalculator(Performance performance, Play play)
            : base(performance, play) { }

        public override int Amount
        {
            get
            {
                var amount = 30000;
                if (Performance.Audience > 20)
                    amount += 10000 + 500 * (Performance.Audience - 20);
                amount += 300 * Performance.Audience;
                return amount;
            }
        }

        public override int VolumeCredits =>
            base.VolumeCredits + (int)Math.Floor((decimal)Performance.Audience / 5);
    }
}