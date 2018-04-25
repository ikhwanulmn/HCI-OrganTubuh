using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float movementSpeed = 2.5f;
    private Vector3 targetPosition;
    public static RaycastHit hit;


    // Use this for initialization
    void Start () {
        targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "Jalan")
            {
                Debug.Log(hit.transform.tag);
                targetPosition = new Vector3(
                    hit.transform.position.x,
                    hit.transform.position.y,
                    hit.transform.position.z
                );
            }
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
    public void gazeOnWaypoint(){
        targetPosition = new Vector3(
            hit.transform.position.x,
            hit.transform.position.y,
            hit.transform.position.z
        );
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
