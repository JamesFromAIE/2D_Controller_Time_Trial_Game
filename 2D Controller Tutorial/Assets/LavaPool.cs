using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPool : MonoBehaviour
{
    public Collider2D Player;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other == Player)
        {
            Player.transform.position = Death.Instance.spawnPos;
        }
            
    }
}
