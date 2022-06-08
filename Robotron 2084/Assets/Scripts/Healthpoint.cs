using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthpoint : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "EnemyBullet")
        {
            GameManager.Health();
        }
    }
}
