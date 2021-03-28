using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
    public int health = 100;
    public AudioSource audioSource;

    void Update ()
    {
        if (health <= 0)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "CratePink")
        {
            //health -= 5;
            //print(health);
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

        if (col.gameObject.name == "CrateGreen")
        {
            
            if (health < 100 )
            {
                if (health > 75)
                {
                    health = 100;
                }
                else
                {
                    health += 25;
                }
                

            }

            Destroy(col.gameObject);
            print(health);
        }

        if (col.gameObject.name == "CrateRed")
        {
            // play sound
            audioSource.Play();
            health -= 25;
            Destroy(col.gameObject);

            print(health);
        }

    }

}
