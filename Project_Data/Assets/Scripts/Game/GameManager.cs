using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public GameData gameData;

    private void Awake()
    {
        Instance = this;
    }
}
