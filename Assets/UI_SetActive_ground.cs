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
            "car ���� �߰� �� ��ġ : �ڼ���\n" +
            "���� �޽� ��ũ��Ʈ ����:\n������ - Mesh_hyunseo\n�ڼ��� - Mesh_S\n������ - Mesh_ohe\n����� - Mesh_mj\n������ - Mesh_yhe\n" +
            "ui ��� �޴��� ����: ������\n" +
            "ground���� heaven, under�� �̵�: ������";
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
