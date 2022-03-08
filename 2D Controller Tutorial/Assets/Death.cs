using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public static Death Instance;

    void Awake() => Instance = this;

    public Collider2D Player;
    public Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = Player.transform.position;
    }

    private void NewSpawnPoint(Vector3 newPoint)
    {
        spawnPos = newPoint;
    }
}
