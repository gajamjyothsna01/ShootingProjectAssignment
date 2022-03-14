using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float time;
    public GameObject bulletPrefab;
    public Vector3 offset;
    public AudioSource bulletSound;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        float xPosition = Mathf.Clamp(transform.position.x, -8.2f, 8.1f);
        float yPosition = Mathf.Clamp(transform.position.y, -4.5f, 4.3f);

        transform.Translate(Vector3.right * speed * inputX * Time.deltaTime);
        transform.Translate(Vector3.up * speed * inputY * Time.deltaTime);

      
        //transform.position = new Vector3(xPosition, yPosition, inputX);
        if (transform.position.x > 5.79f)
        {
            transform.position = new Vector3(5.79f, transform.position.y,0);

        }
         if (transform.position.x < -5.79f)
        {
            
            transform.position = new Vector3(-5.79f, transform.position.y, 0);
        }

        if (transform.position.y > 4.23 )
        {
            transform.position = new Vector3(transform.position.x,4.3f, 0);

        }
        if (transform.position.y < -4.23f)
        {
            transform.position = new Vector3(transform.position.x,-4.23f, 0);
        }
      //  time = time + Time.deltaTime;
        if(Input.GetButtonDown("Fire1"))
        {

            Instantiate(bulletPrefab, transform.position+offset, Quaternion.identity);
            bulletSound.clip = audioClip;
            bulletSound.Play();
            //time = 0f;

        }


       

    }
}
