using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud : MonoBehaviour
{

    // Start is called before the first frame update
    public Text myText;

    void Update()
    {
        myText.text = GameObject.Find("CharacterRobotBoy").GetComponent<damage>().health.ToString();
        
    }
}
