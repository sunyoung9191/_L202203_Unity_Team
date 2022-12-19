using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SetActive_ground : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText.GetComponent<Text>().text = "도시 에셋, 테린 추가 : 박현서\n" +
            "각각 메시 스크립트 구현: 박현서 - Mesh_hyunseo, 박선영 - Mesh_S" +
            "ui 사용 메뉴얼 구현: 박현서\n" +
            "ground에서 heave, under로 이동: 박현서";
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
