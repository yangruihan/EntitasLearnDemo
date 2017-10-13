using Entitas;
using UnityEngine;

public class InitializeHexGridSystem : IInitializeSystem
{
    private Contexts _context;

    public InitializeHexGridSystem(Contexts context)
    {
        _context = context;
    }

    void IInitializeSystem.Initialize()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                var entity = _context.game.CreateEntity();
                entity.AddPosition(new IntVector2(i, j));
            }
        }
    }
}
