using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time > 3.0f)
        {
            transform.position = new Vector3(8.5f, Random.Range(-4.5f, 4.5f), 0);
             Instantiate(enemyPrefab, transform.position, Quaternion.identity);
          
            time = 0;

        }
       



    }
}
