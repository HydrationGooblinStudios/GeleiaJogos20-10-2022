using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float speed = 5f;

    public Transform target;
    private int wavepointIndex = 0;
    public Waypoints waypoints;

    private void Start()
    {
        target = Waypoints.points[0];
    }
    private void Update()
    {
        Vector2 dir  = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(transform.position, target.position) <= 0.001f)
        {
            GetNextWaypoints();
        }
    }
    void GetNextWaypoints()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
