using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class groundtoheaven : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("heaven");
    }

}
