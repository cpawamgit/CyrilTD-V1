using System.Collections;
using UnityEngine;

public class EnemyLongBlue : MonoBehaviour
{

    public float speed = 20f;

    private Transform target;
    private int wavepointindex = 0;

    void Start()
    {
        target = BlueToRedLongWaypoints.points[0];
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
        if (wavepointindex >= BlueToRedLongWaypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointindex++;
        target = BlueToRedLongWaypoints.points[wavepointindex];
    }
}
