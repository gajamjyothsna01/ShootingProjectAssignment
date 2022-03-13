using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        transform.Translate(Vector3.left * enemySpeed*Time.deltaTime) ;
        transform.Rotate(2f, 0f, 0f, Space.Self) ;

        /*if(transform.position.x < -8.7f)
        {
            Destroy(gameObject);
        }*/

    }
    //This method works for 2D method. This method tells that Once the Enemy is out of the game view,
    //enemy is automatically invisible with this method.
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
