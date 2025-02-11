using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypathing : MonoBehaviour
{

    public Transform[] waypoints;
    public float speed = 5f;
    private int currentWaypointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waypoints.Length == 0) return; // Safety check

        // Move enemy toward the current waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Check if the enemy has reached the waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.2f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Loop through waypoints
        }
    }
}
