using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 1f)
        {
            transform.Translate(new Vector3(bulletSpeed * Time.deltaTime, 0, 0));
            time = time + Time.deltaTime;
            time = 0;
        }
       
    }
}
