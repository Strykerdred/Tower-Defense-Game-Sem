using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypathing : MonoBehaviour

{

    public Transform[] waypoints;
    public float speed = 5f;
    private int currentWaypointIndex = 0;
    public float MobHealth = 10f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (waypoints.Length == 0) return;


        Transform targetWaypoint = waypoints[currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // doouble checking if it reached checkpoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.2f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // repeat to check if it dies propperly
        }
    }
}
