using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Button btn1;
    public Text sufb;
    public int count = 10;
    void Start() {
        Button btn = btn1.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(Coroutine());

    }
    IEnumerator Coroutine()
    {
        for (int i = 10; i > 0; i--)
        {
            sufb.text = i.ToString();
            Debug.Log(i.ToString());
            yield return new WaitForSeconds(1   );
        }
        SceneManager.LoadScene("GameScene");
    }
}

