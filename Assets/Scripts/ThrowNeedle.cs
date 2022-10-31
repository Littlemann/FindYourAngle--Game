using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowNeedle : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed = 5f;
    private RotateNeedle _rotateScript;
    private Vector3 _rotationdir;
  
    void Start()
    {
        _rb =GetComponent<Rigidbody>();
        _rotationdir = new Vector3(transform.localPosition.x , 0f ,transform.localPosition.z);
        _rotateScript = GetComponent<RotateNeedle>();
         
         
    }

    // Update is called once per frame
    void Update()
    {   
        ThrowObject();
         
    }   
    IEnumerator DestroyTimeRoutine()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
    void ThrowObject()
     {
            if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            _rotateScript._isThrow = true;
            _rb.AddRelativeForce(_rotationdir * _speed , ForceMode.Impulse);
            StartCoroutine(DestroyTimeRoutine());
           
             
        }     
     }
}
