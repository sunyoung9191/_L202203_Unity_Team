using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SetActive_ground : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText.GetComponent<Text>().text = "���� ����, �׸� �߰� : ������\n" +
            "���� �޽� ��ũ��Ʈ ����: ������ - Mesh_hyunseo, �ڼ��� - Mesh_S" +
            "ui ��� �޴��� ����: ������\n" +
            "ground���� heave, under�� �̵�: ������";
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
