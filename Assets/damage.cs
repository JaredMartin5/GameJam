using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damage : MonoBehaviour
{
    public int health = 100;

    void Update ()
    {
        if (health <= 0)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "CratePink")
        {
            health -= 5;
            print(health);
        }

    }

}
