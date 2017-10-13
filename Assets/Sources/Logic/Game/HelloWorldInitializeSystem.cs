using Entitas;
using UnityEngine;

public class HelloWorldInitializeSystem : IInitializeSystem
{
    void IInitializeSystem.Initialize()
    {
        Debug.Log("Hello world");
    }
}
