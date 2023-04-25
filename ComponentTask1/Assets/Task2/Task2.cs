using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MeshRenderer>().enabled = false;
    }
    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log("Entered");

    }


}
