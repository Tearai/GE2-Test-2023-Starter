using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
 


    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        
        ChangeColor();
        yield return new WaitForSeconds(1);
    }

    public void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        
    }



    public void Update()
    {
        StartCoroutine(WaitAndPrint());


    }

    public void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

  
}
