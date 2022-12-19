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
            = "��ü���� ������ �� ������Ʈ ��ġ : �����, ������, ������\n"
            + "ȿ��(����,Particle) �߰� : ������, �����\n"
            + "���� �� Terrain : ������\n"
            + "������Ʈ ���̴� �߰� : ������, �����\n"
            + "MagicFire �߰� �� ��ġ : �����, ������\n"
            + "16777_Hades_V1_NEW ���̴� ���� : �����\n"
            + "Explosion : ����� ������\n"
            + "Eagle_Normal : ������\n"
            + "Rubble_3 : �����\n"
            + "Post-Process Layer �� Post-process Volume ī�޶� ��ó��: ������\n"
            + "Flashlight�� Spot ���� ȿ��: ������\n"
            + "Camera_minimap, Minimap : ������\n"
            + "Mirror ȿ�� : ������\n"
            + "Entrance : �����\n"
            + "Tree, Altar_2, Wolf_howl,Wolf : �����\n"
            + "Cube(���Ͽ��� �������� �̵�) : �����\n"
            + "stairs_1 (1), Chair, Chair(1),Fences : ������\n"
            + "StrangeCube : ������\n"
            + "skull : �����\n"
            + "Rock ���� ������Ʈ ���̴� : �����\n"
            + "Statues, Plates : ������\n"
            + "Column, Zombies �߰�: �����\n" +
            "Image Effect : ������\n"
            + "Cerabus �߰� �� �ִϸ����� : ������\n";
            
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
