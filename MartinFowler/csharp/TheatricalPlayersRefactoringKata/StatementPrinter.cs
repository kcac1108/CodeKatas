using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TheatricalPlayersRefactoringKata.Calculators;

namespace TheatricalPlayersRefactoringKata;

public class StatementPrinter
{
    public string Print(Invoice invoice, Dictionary<string, Play> plays)
    {
        return RenderPlainText(CreateStatementData(invoice, plays));
    }

    private string RenderPlainText(StatementData data)
    {
        var cultureInfo = new CultureInfo("en-US");
        var result = $"Statement for {data.Customer}\n";

        foreach (var perf in data.Performances)
            result += string.Format(cultureInfo,
                "  {0}: {1:C} ({2} seats)\n",
                perf.PlayName,
                perf.Amount / 100m,
                perf.Audience);

        result += string.Format(cultureInfo, "Amount owed is {0:C}\n", data.TotalAmount / 100m);
        result += $"You earned {data.TotalVolumeCredits} credits\n";
        return result;
    }

    private StatementData CreateStatementData(Invoice invoice, Dictionary<string, Play> plays)
    {
        var performances = new List<PerformanceData>();

        foreach (var perf in invoice.Performances)
        {
            var play = plays[perf.PlayID];
            var calculator = PerformanceCalculatorFactory.Create(perf, play);
            performances.Add(new PerformanceData(
                PlayName:      play.Name,
                Amount:        calculator.Amount,
                Audience:      perf.Audience,
                VolumeCredits: calculator.VolumeCredits
            ));
        }

        return new StatementData(
            Customer:           invoice.Customer,
            Performances:       performances,
            TotalAmount:        performances.Sum(p => p.Amount),
            TotalVolumeCredits: performances.Sum(p => p.VolumeCredits)
        );
    }
}

