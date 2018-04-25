using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastThing : MonoBehaviour {

    public Canvas myCanvas;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.tag == "popTelinga")
                {
                    if (myCanvas.enabled == false) myCanvas.enabled = true;
                    else myCanvas.enabled = false;
                }
            }
        }
    }
}
