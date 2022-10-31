using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private AudioClip _expSound;

    [SerializeField] private int _volume;

    
   
      private void OnEnable() 
    {
        GameManager.Instance.OnHit += HitBaloon;
    }
     private void OnDisable() 
    {
        GameManager.Instance.OnHit -= HitBaloon;
    }

   
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Needle"))
        {     
           HitBaloon();   
       
           
        }    
    
    }
    private void HitBaloon()
    {   
        AudioSource.PlayClipAtPoint(_expSound, transform.position , _volume);
        Instantiate(_explosion , transform.position , transform.rotation);
            
        Destroy(this.gameObject);     
    }


 

}
