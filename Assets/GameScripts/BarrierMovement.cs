using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMovement : MonoBehaviour {

    // Publics Vars
    public GameObject prefab;
    public int barrierSpeed;
    // Private Vars
    private GameObject obj;


    void Start () {
        // Crear una barrera
        Debug.Log("E: BarrierMovement");
        obj = Instantiate(prefab);
        obj.transform.position = new Vector3(Random.Range(-2.00f, 7.00f), -6, 5);
    }
	
	void Update () {
        // Movimiento de la barrera
        obj.transform.Translate(Vector3.forward * -barrierSpeed * Time.deltaTime);
        
        // 
        if(obj.transform.position == new Vector3(2.00f,-6.00f,-14.00f))
        {
            Debug.Log("E: OBJ Destoy");
            Destroy(obj);
        }
    }
}
