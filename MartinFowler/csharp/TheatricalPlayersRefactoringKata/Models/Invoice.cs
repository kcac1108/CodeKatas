using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata.Models;

public record Invoice(string Customer, List<Performance> Performances);
