using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNeedle : MonoBehaviour
{   
    public static RotateNeedle Instance;
    public virtual bool IsDontDestroyOnLoad => true;
    [SerializeField] float _rotation;
    [SerializeField] float _speed;
    public bool _isThrow = false;

    void Start()
    {
       
    }
    void Awake()
    {
       Singleton();
    }

    private void Singleton()
    {
         if (Instance == null)
        {
          Instance = this;
            if (IsDontDestroyOnLoad)
            {
                DontDestroyOnLoad(this.gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this as RotateNeedle)
        {
            Instance = null;
        }
    }

    void FixedUpdate()
    {
         Rotate();
         
    }

    public void Rotate()
    {
        if(!_isThrow)
        {
             transform.Rotate(Vector3.up, _rotation * _speed * Time.deltaTime); 
        }
        
    }

   




}
