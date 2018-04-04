using System.Collections;
using UnityEngine;

public class EnemyShortRed : MonoBehaviour
{

    public float speed = 30f;

    private Transform target;
    private int wavepointindex = 0;

    void Start()
    {
        target = BlueToRedShortWaypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointindex >= BlueToRedShortWaypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointindex++;
        target = BlueToRedShortWaypoints.points[wavepointindex];
    }
}
