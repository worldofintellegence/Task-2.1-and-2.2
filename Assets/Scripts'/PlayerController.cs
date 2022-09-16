using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float  speed = 10.0f;
    public float rangex = 10;
    public GameObject[] animal;
    float  spawnrangex = 20;
    float spawnrangez = 20;
    public GameObject prefabprojectile;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnanimal",2,1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
            
     
       if(transform.position.x < -rangex )
      { transform.position =new Vector3(-rangex,transform.position.y,transform.position.z);}
       if(transform.position.x > rangex)
       {
        transform.position = new Vector3(rangex,transform.position.y,transform.position.z);
       }
           float x = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * speed * x * Time.deltaTime);   
       if(Input.GetKeyDown(KeyCode.Space))
       {
        Instantiate(prefabprojectile,transform.position,prefabprojectile.transform.rotation);
       }
       
    }
    void spawnanimal()
    {
         Vector3 Spawnpoint = new Vector3(Random.Range(-spawnrangex,spawnrangex),0,spawnrangez);
            int animalindex = Random.Range(0,animal.Length);
            Instantiate(animal[animalindex],Spawnpoint,animal[animalindex].transform.rotation);
    }
   

}
