using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText = GetComponent<Text>();
        if (GameOverText.enabled == true)
        {
            GameOverText.enabled = false;
        }

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            GameOverText.enabled = true;
        }

    }
}