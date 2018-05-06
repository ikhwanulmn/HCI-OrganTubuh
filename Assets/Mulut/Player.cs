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
    }
    public void gazeOnWaypoint(){
    }
}
