using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume2 : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2f;

    private int currentWaypointIndex = 0;
    public int hp = 0;

    void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("em1");
        Debug.Log(objectsWithTag.Length);
        if (objectsWithTag.Length < 1) {
           
        if (transform.position == waypoints[currentWaypointIndex].position)
        {

            if (currentWaypointIndex == waypoints.Length - 1)
            {
                currentWaypointIndex = 0;
                Destroy(gameObject);
                
            }
            else
            {

                currentWaypointIndex++;
            }
        }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bul")
        {
            hp = hp + 1;
            if (hp > 3)
            {
                Destroy(gameObject);
                hp = 0;
            }
        }
    }
}
