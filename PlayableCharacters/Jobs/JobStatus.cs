namespace PlayableCharacters.Jobs;

public enum JobStatus
{
    Unset = 0,
    WorkInProgress = 1,
    Playable = 2,
    Unplayable = 3,
    Restricted = 4
}