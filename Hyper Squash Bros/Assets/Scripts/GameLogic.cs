using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using BeardedManStudios.Forge.Networking.Unity;
public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random r = new System.Random();
        int rInt = r.Next(-11, 11);
        NetworkManager.Instance.InstantiateCharacterDriver(position:  new Vector3(rInt, 14));
    }

}
