using Svelto.ECS;
using Svelto.ECS.Schedulers;

namespace Aeronautica.Game.ECS;

public class GameContext
{
    readonly EnginesRoot _engineRoot;

    public GameContext()
    {
        var simpleEntitySubmissionScheduler = new SimpleEntitiesSubmissionScheduler();

        _engineRoot = new EnginesRoot(simpleEntitySubmissionScheduler);
        
        var entityFactory = _engineRoot.GenerateEntityFactory();
        var entityFunctions = _engineRoot.GenerateEntityFunctions();
        
        
    }
    
    
}