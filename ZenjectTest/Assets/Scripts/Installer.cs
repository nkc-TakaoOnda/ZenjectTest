using UnityEngine;
using Zenject;

public class Installer : MonoInstaller
{
    [SerializeField] GameObject player;
    public override void InstallBindings()
    {
        Container.Bind<IInputReceivable>()
            .To<Inputer>()
            .FromComponentOn(player)
            .AsCached();
    }
}