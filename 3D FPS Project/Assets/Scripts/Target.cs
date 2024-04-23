using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
   
    void Start()
    {
        this.gameObject.SetActive(true);
    }
   void OnCollisionEnter(Collision other)
   {
    
    if(other.gameObject.CompareTag("Bullet"))
    {
        if(this.gameObject.tag == "Floating Target")
        {
            //Destroy(this.gameObject);
            GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount(-1);
        
            this.gameObject.SetActive(false);
        }
        //add grayscale
        if(this.gameObject.tag == "Target")
        {
            GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount(-1);
            this.gameObject.SetActive(false);
        }
     }
   }
  
}
