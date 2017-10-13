using UnityEngine;
using Entitas;

public class GameController : MonoBehaviour {

    private Systems _systems;

	void Start () {
        _systems = CreateSystems();

        _systems.Initialize();
	}

    Systems CreateSystems()
    {
        return new Feature("Game")
            .Add(new HelloWorldInitializeSystem())
            ;
    }
}
