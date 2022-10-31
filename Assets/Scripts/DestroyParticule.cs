using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticule : MonoBehaviour
{
  

   private void Start()
   {
        InvokeRepeating("DestroyParticules" , 3f , 3f);
   }
   private void DestroyParticules()
   {
     Destroy(this.gameObject);
   }
}