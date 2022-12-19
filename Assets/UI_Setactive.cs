using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setactive : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText.GetComponent<Text>().text = "����, �Ȱ�, ��, �ٶ� ȿ��, ���� �߰�, ������, �ִϸ����� ������Ʈ ���ǵ� �Ӽ� ����: �ڼ��� ������" +
            "��ʽ� �̹��� ���̴� ����(���̴� �ٷ�� 7-10): ������" +
            "��, �༺, ����, ���ڻ� ��� ���̴� ����, ȸ��: �ڼ���" +
            "�̹��� ����Ʈ ���̴�(invert, gray,depth,����ȥ��):������" +
            "ī�޶� �ٷ��(1-3): �ڼ���" +
            "���� ����: �ڼ���" +
            "3D ������Ʈ�� Ȱ���� ������: ������" +
            "�ε��� ĵ���� ����: �ڼ���" +
            "�ε��� Ȱ�� ����, �� �ε�: ������";
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