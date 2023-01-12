namespace Jobs;

public abstract class Job
{
    protected Job(
        int JobId,
        string Name)
    {
        this.JobId = JobId;
        this.Name = Name;
    }

    public int JobId { get; init; }
    public string Name { get; init; }

    public void Deconstruct(out int JobId, out string Name)
    {
        JobId = this.JobId;
        Name = this.Name;
    }
}