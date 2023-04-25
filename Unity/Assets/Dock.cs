using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dock : MonoBehaviour
{
    public bool DockTrue;



    // Start is called before the first frame update
    void Start()
    {
               

        DockTrue = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && DockTrue == true)
        {
            FollowCamera Docking = GetComponent<FollowCamera>();
            Docking.enabled = true;
            FPSController control = GetComponent<FPSController>();
            control.enabled = false;
        }

        if (Input.GetKey(KeyCode.O) && DockTrue == false)
        {
            FollowCamera Docking = GetComponent<FollowCamera>();
            Docking.enabled = false;
            FPSController control = GetComponent<FPSController>();
            control.enabled = true;
        }


    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mech")
        {
            DockTrue = true;

       
                
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Mech")
        {
            DockTrue = false;



        }
    }




}
