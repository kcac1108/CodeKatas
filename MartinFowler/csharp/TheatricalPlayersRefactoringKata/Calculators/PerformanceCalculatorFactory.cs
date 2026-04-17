using System;
using TheatricalPlayersRefactoringKata.Models;

namespace TheatricalPlayersRefactoringKata.Calculators
{
    public static class PerformanceCalculatorFactory
    {
        public static PerformanceCalculator Create(Performance perf, Play play) =>
            play.Type switch
            {
                PlayType.Tragedy => new TragedyCalculator(perf, play),
                PlayType.Comedy  => new ComedyCalculator(perf, play),
                _                => throw new Exception($"unknown type: {play.Type}")
            };
    }
}