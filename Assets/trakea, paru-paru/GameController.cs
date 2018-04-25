using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public string Virus;
    public Player player;
    public TextMesh infoText;
    public float movementSpeed = 2.5f;
    private Vector3 targetPosition;
    public static RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "Virus")
            {
                infoText.text = "Virus\n";
            }
        }
    }
    public void gazeOnVirus()
    {
        infoText.text = Virus+"\n";
    }
    public void gazeOffVirus()
    {
        infoText.text = "";
    }
    public void gazeOnWaypoint()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.tag == "Jalan")
            {
                //Debug.Log(hit.transform.tag);
                targetPosition = new Vector3(
                    Player.hit.transform.position.x,
                    Player.hit.transform.position.y,
                    Player.hit.transform.position.z
                );
            }
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
    public void clickOnVirus()
    {
        Destroy(gameObject);
        infoText.text = "";

    }
}
