using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameLvlManager : MonoBehaviour
{
    public Boat _boat;
    [Inject]
   public void Consruct(Boat boat)
    {
        _boat = boat;
    }
}
