namespace PlayableCharacters.Players;

public record  Player
{
    public int PlayerId { get; private set; }
    public string Name { get; private set; }
    public PlayerStatus Status { get; private set; }
}