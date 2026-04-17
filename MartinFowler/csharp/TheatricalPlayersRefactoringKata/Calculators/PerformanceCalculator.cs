using System;
using TheatricalPlayersRefactoringKata.Models;

namespace TheatricalPlayersRefactoringKata.Calculators
{
    public abstract class PerformanceCalculator
    {
        protected readonly Performance Performance;
        protected readonly Play Play;

        protected PerformanceCalculator(Performance performance, Play play)
        {
            Performance = performance;
            Play = play;
        }

        public abstract int Amount { get; }

        public virtual int VolumeCredits =>
            Math.Max(Performance.Audience - 30, 0);
    }
}