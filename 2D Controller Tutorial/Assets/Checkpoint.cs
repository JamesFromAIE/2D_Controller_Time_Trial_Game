using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarodevController
{
    public class Checkpoint : MonoBehaviour
    {
        public bool FlipCamX;
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Death.Instance.spawnPos = transform.position;
                this.GetComponent<BoxCollider2D>().enabled = false;

                if (FlipCamX)
                {
                    MoveCamera.Instance.FlipOffset();
                }
                    
            }

        }
    }
}
