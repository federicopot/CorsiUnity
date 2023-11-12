using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject LowObstacle;

    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        StartCoroutine(spawn());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawn(){
        while(GameObject.Find("Player") != null){
            yield return new WaitForSeconds(Random.Range(2.5f, 10));
            spawnObject(LowObstacle, new Vector3(9.3f, -4.039f));
        }
    }

    void spawnObject(GameObject gameObjectTospawn, Vector3 position){
        if(speed < 10){
            speed += 0.0015f;
        }
        GameObject g = Instantiate(gameObjectTospawn, position, Quaternion.identity);
        g.AddComponent<ObstacleBehavior>();
        g.GetComponent<ObstacleBehavior>().speed = speed;
    }
}

public class ObstacleBehavior : MonoBehaviour
{
    public float speed = 5;
    void Start(){
        speed = 5;
        Destroy(this.gameObject, 8);
    }
    void Update(){
        transform.Translate(Vector2.left*Time.deltaTime*speed);
    }
}