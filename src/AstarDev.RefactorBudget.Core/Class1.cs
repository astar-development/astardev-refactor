namespace AstarDev.RefactorBudget.Core;

public enum PainPoint
{
    Low,
    Medium,
    High,
    Critical
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public sealed class RefactorAttribute : Attribute
{
    public PainPoint PainPoint { get; init; } = PainPoint.Medium;

    public int EstimatedResolutionHours { get; init; } = 5;

    public string? Description { get; init; }
}
