using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SetActive_under : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText.GetComponent<Text>().text 
            = "��ü���� ������ �� ������Ʈ ��ġ : �����, ������, ������ "
            + "MagicFire �߰� �� ��ġ : �����, ������"
            + "16777_Hades_V1_NEW ���̴� ���� : �����"
            + "Explosion : ����� ������"
            + "Eagle_Normal : ������"
            + "Rubble_3 : �����"
            + "Camera_minimap : ������"
            + "Entrance : �����"
            + "Tree, Altar_2, Wolf_howl,Wolf : �����"
            + "Cube(���Ͽ��� �������� �̵�) : �����"
            +"";
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
