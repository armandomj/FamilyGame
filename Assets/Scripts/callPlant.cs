using UnityEngine;
using System.Collections;

public class callPlant : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Create() {
        Instantiate(gameObject);
    }

}
