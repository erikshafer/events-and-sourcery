 using Core.Aggregates;
using PlayableCharacters.Jobs;
using PlayableCharacters.Players;
using PlayableCharacters.Species;
 using PlayableCharacters.Upbringings;

 namespace PlayableCharacters;

public sealed class PlayerCharacter : Aggregate
{
    public Guid PlayerCharacterId { get; private set; }

    public PlayerCharacterStatus Status { get; private set; }

    public Job Job { get; private set; }

    public Player Player { get; private set; }
    public Species.Species Species { get; private set; }

    public Upbringing Upbringing { get; private set; }

    public string Name { get; private set; }

    public int Level { get; private set; }

    public PlayerCharacter(){}

    private PlayerCharacter(Guid id, Player player, Species.Species species, Job job, string name)
    {
        PlayerCharacterId = id;
        Player = player;
        Species = species;
        Job = job;
        Name = name;

        Level = 1;
        Status = PlayerCharacterStatus.Draft;
    }

    public static PlayerCharacter Initialize(Guid id, Player player, Species.Species species, Job job, string name)
    {
        return new PlayerCharacter(id, player, species, job, name);
    }
}