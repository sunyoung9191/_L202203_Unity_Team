using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_text : MonoBehaviour
{
    public GameObject MyGameObject;
    // Start is called before the first frame update
    void Start()
    {
        ///string name = MyGameObject.name;
        GetComponent<Text>().text = "����, �Ȱ�, ��, �ٶ� ȿ��, ���� �߰�, ������: �ڼ��� ������" +
            "��ʽ� �̹��� ���̴� ����(���̴� �ٷ�� 7-10): ������" +
            "��, �༺, ����, ���ڻ� ��� ���̴� ����, ȸ��: �ڼ���" +
            "�̹��� ����Ʈ ���̴�(invert, gray,depth,����ȥ��):������" +
            "ī�޶� �ٷ��(1-3): �ڼ���" +
            "���� ����: �ڼ���" +
            "3D ������Ʈ�� Ȱ���� ������: ������" +
            "�ε��� ĵ���� ����: �ڼ���" +
            "�ε��� Ȱ�� ����, �� �ε�: ������";

    }

    // Update is called once per frame
    void Update()
    {

    }
}