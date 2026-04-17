using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata
{
    public record StatementData(
        string Customer,
        IReadOnlyList<PerformanceData> Performances,
        int TotalAmount,
        int TotalVolumeCredits
    );
}