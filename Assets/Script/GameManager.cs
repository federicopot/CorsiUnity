using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player") == null){
            Canvas.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void reset(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
