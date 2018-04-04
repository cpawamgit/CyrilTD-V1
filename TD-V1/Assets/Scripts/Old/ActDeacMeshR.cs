using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActDeacMeshR : MonoBehaviour
{

    private bool active = true;
    private float activationRate = 0.1f;
    private float nextActivation;

    void Update()
    {
        if (Input.GetKey(KeyCode.D) && Time.time > nextActivation)
        {
            if (active == true)
            {
                foreach (Renderer r in GetComponentsInChildren<Renderer>())
                    r.enabled = false;
                active = false;
            }
            else if (active == false)
            {
                foreach (Renderer r in GetComponentsInChildren<Renderer>())
                    r.enabled = true;
                active = true;
            }
            nextActivation = Time.time + activationRate;
        }
    }
}
