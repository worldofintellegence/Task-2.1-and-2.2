using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison : MonoBehaviour
{
    public float  score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
   
    void OnTriggerEnter(Collider other)
    {
      Destroy(gameObject);
      Destroy(other.gameObject);
      score++;
      Debug.Log("score: "+ score);
    }
}
