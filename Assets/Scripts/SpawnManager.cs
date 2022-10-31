using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _needlePrefabs;
    [SerializeField] private GameObject _baloonPrefabs;
    private RotateNeedle _rotateScript;
    private Vector3 _spawnPos;

    private Vector3 _randomPos;

    [SerializeField] int _baloonCount ;

    [SerializeField] int _waveNumber;

    
    void Start()
    {
        _spawnPos = new Vector3(2f, 2.816f ,-10.83f);
        _rotateScript = GetComponent<RotateNeedle>();
        BaloonSpawn(_waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
        _baloonCount = FindObjectsOfType<Baloon>().Length;
        
         if(_baloonCount == 0)
        {
            _waveNumber++;
            BaloonSpawn(_waveNumber);

            
        }
         Instantiate(_needlePrefabs , _spawnPos ,transform.rotation);
        
    }
   

  

    void BaloonSpawn( int _baloonToSpawn)
    {
     
            for(int i=0 ; i < _baloonToSpawn ; i++)
        {
            Instantiate(_baloonPrefabs , GenerateRandomPositions() ,_baloonPrefabs.transform.rotation); 
           
            
        }
 
        
    }

    private Vector3 GenerateRandomPositions()
    {
        float _randomX = Random.Range(-1f , 5.1f);
        float _randomZ = Random.Range(-15f, -4f);
        _randomPos = new Vector3(_randomX , 2.95f ,_randomZ);
        return _randomPos;
    }


}
