using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    float time;
    private AudioSource audioSource;
    public AudioClip explosionSound;
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 1f)
        {
            gameObject.transform.Translate(bulletSpeed, 0, 0);
            time = time + Time.deltaTime;
            if(time > 2f)
            {
                Destroy(gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Explosion"));
            }
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            audioSource.clip = explosionSound;
            audioSource.Play();
            Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
            GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>().Score(10);
        }
      
    }
}
