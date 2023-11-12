using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoManager : MonoBehaviour
{
    public Animator rainyClouds;
    public Animator rainyCamera;
    public ParticleSystem [] listParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rain());
    }
    IEnumerator Rain(){
        while(true){
            yield return new WaitForSeconds(Random.Range(10, 50));
            foreach (ParticleSystem element in listParticleSystem)
            {
                element.Play();
            }
            rainyClouds.Play("CloudRainy");
            rainyCamera.Play("CameraIn");
            yield return new WaitForSeconds(Random.Range(10, 17));
            rainyClouds.Play("CloudRainyOut");
            rainyCamera.Play("CameraOut");
            foreach (ParticleSystem element in listParticleSystem)
            {
                element.Stop();
            }
            yield return new WaitForSeconds(Random.Range(3, 25));
        }
    }
}
