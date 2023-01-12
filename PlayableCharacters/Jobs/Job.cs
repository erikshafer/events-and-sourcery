namespace PlayableCharacters.Jobs;

public record Job
{
    public int JobId { get; private set; }
    public string Name { get; private set; }
    public JobStatus Status { get; private set; }
}