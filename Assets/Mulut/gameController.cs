using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
    public string tulisan;
    public TextMesh infoText;
    public static RaycastHit hit;
    public Player player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void gazeOnKuman()
    {
        infoText.text = tulisan + "\n";
    }
    public void gazeOffVirus()
    {
        infoText.text = "";
    }
    public void clickOnKuman()
    {
        Destroy(gameObject);
        infoText.text = "";
    }
}
