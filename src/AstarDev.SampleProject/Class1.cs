namespace AstarDev.SampleProject;

public class Class1
{
[Refactor(
    PainPoint = PainPoint.High,
    EstimatedResolutionHours = 16,
    Description = "Replace legacy repository")]
    public void SomeDummyRepositoryMethod()
    {
        Console.WriteLine("Not important");
    }
}
