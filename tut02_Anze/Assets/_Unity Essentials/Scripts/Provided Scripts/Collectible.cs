using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotateSpeed;
    public GameObject onCollectEffect; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, rotateSpeed, 0); 
    }
   
    private void OnTriggerEnter(Collider other) 
    { 
    if (other.CompareTag("Player")) 
    { 

    Destroy(gameObject); 
    // instanciar el efecto de partículas 
    Instantiate(onCollectEffect, transform.position, 
transform.rotation);   
    } 
    
    //hace desaparecer el objeto coleccionable
    

    }

}
