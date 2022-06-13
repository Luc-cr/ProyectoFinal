using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierMovement : MonoBehaviour {

    // Publics Vars
    public GameObject prefab;
    public int barrierSpeed;
    public Text points;
    public GameObject player;
    // Private Vars
    private GameObject obj;
    private int score = 0;

    void Start () {
        // Crear una barrera
        Debug.Log("E: BarrierMovement");
        obj = Instantiate(prefab);
        obj.transform.position = new Vector3(Random.Range(-2.00f, 7.00f), -6, 5);
    }

    void Update()
    {
        // Movimiento de la barrera
        obj.transform.Translate(Vector3.forward * -barrierSpeed * Time.deltaTime);

        if (obj.transform.position.z <= -13f)
        {
            Debug.Log("E: OBJ Destoy");
            score++;
            points.text = "Puntaje " + score.ToString();
            Destroy(obj);
            barrierSpeed++;
            obj = Instantiate(prefab);
            obj.transform.position = new Vector3(Random.Range(-2.00f, 7.00f), -6, 5);
        }
    }
}
