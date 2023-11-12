using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoManager : MonoBehaviour
{
    public Animator rainyClouds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rain());
    }
    IEnumerator Rain(){
        while(true){
            yield return new WaitForSeconds(Random.Range(10, 17));
            rainyClouds.Play("CloudRainy");
            yield return new WaitForSeconds(Random.Range(10, 17));
            rainyClouds.Play("CloudRainyOut");
            yield return new WaitForSeconds(Random.Range(3, 25));
        }
    }
}
