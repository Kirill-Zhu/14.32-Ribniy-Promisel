using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameMonoinstaller : MonoInstaller
{
    [SerializeField] private Boat _boat;
    public override void InstallBindings()
    {
        Container.Bind<Boat>().FromInstance(_boat);
    }
}
