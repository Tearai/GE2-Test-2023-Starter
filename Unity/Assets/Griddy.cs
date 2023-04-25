using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Griddy : MonoBehaviour
{
    public Dock Mech;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.P) && Mech.DockTrue == true)
        {
            FPSController control = GetComponent<FPSController>();
            control.enabled = true;
            Boid boid = GetComponent<Boid>();
            boid.enabled = false;
            ObstacleAvoidance obsta = GetComponent<ObstacleAvoidance>();
            obsta.enabled = false;
            Seek seeker = GetComponent<Seek>();
            seeker.enabled = false; 
        }

        if (Input.GetKey(KeyCode.O) && Mech.DockTrue == false)
        {
            FPSController control = GetComponent<FPSController>();
            control.enabled = false;
            Boid boid = GetComponent<Boid>();
            boid.enabled = true;
            ObstacleAvoidance obsta = GetComponent<ObstacleAvoidance>();
            obsta.enabled = true;
            Seek seeker = GetComponent<Seek>();
            seeker.enabled = true;
        }

    }
}
