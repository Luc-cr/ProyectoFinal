using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public GameObject player;
	void Start () {
		
	}
	
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "Cube_2" || coll.gameObject.name == "Cube_1")
        {
            Destroy(player);
            
        }
    }
    
}
