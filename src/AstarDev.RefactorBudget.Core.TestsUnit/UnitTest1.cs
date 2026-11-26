namespace AstarDev.RefactorBudget.Core.TestsUnit;

public class UnitTest1
{
    [Test]
public void Debt_budget_must_not_exceed_40_hours()
{
    var report = RefactorScanner.Scan(
        typeof(SomeType).Assembly);

    report.TotalEstimatedHours
          .Should()
          .BeLessThanOrEqualTo(40);
}
}
