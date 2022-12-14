using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public virtual bool IsDontDestroyOnLoad => true;

    public event System.Action OnHit;

    public bool _isBreak = false;



 void Awake()
    {
         if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
         else if (Instance != this) 
        {
            Destroy(Instance.gameObject);
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    private void OnDestroy()
    {
        if (Instance == this as GameManager)
        {
            Instance = null;
        }
    }

    public void Hit()
    {
        OnHit?.Invoke();
        
    }

    
}
