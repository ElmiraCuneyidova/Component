
using UnityEngine;

public class task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.tag = "Changed";
        if (gameObject.tag == "Changed")
        {
            gameObject.GetComponent<task1>().enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    




}
