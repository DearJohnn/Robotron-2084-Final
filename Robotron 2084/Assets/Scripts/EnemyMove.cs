using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float speed;
     private Vector3 targetPosition;
     void Start()
     {
         speed = 1.0f;
         targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height)));
 
    }

     void Update()
     {
             RandomMoveFlower();
         }
     private void RandomMoveFlower()
     {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
         }
}
