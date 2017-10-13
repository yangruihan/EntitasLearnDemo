using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour
{

    private Systems _systems;

    void Start()
    {
        var contexts = Contexts.sharedInstance;

        _systems = CreateSystems(contexts);

        _systems.Initialize();
    }

    Systems CreateSystems(Contexts contexts)
    {
        return new Feature("Game")
            .Add(new InitializeHexGridSystem(contexts))
            ;
    }
}
