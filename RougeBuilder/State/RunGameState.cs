namespace RougeBuilder.State;

public class RunGameState : GameState
{
    public override GameState Update()
    {
        return new TutorialState();
    }
}