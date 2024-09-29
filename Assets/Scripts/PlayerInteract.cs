using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    Outline outline;
    public RawImage defaultCH;
    public RawImage searchCH;
    public RawImage grabCH;
    // Start is called before the first frame update
    void Start()
    {
        searchCH.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Simple Interactions with Reach Tool
    private void OnTriggerEnter(Collider other)
    {
        //Interact with Clock
        if(other.gameObject.tag=="Clock")
        {
            Debug.Log("It's missing it's Hands");
            outline = other.GetComponent<Outline>();
            outline.enabled = true;
            defaultCH.enabled = false;
            searchCH.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Interact with Clock
        if (other.gameObject.tag == "Clock")
        {
            outline = other.GetComponent<Outline>();
            outline.enabled = false;
            defaultCH.enabled = true;
            searchCH.enabled = false;
        }
    }


}
