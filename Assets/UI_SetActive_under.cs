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
            = "전체적인 디자인 및 오브젝트 배치 : 양민지, 오하은, 윤하은 "
            + "MagicFire 추가 및 배치 : 양민지, 윤하은"
            + "16777_Hades_V1_NEW 셰이더 적용 : 양민지"
            + "Explosion : 양민지 윤하은"
            + "Eagle_Normal : 윤하은"
            + "Rubble_3 : 양민지"
            + "Camera_minimap : 윤하은"
            + "Entrance : 양민지"
            + "Tree, Altar_2, Wolf_howl,Wolf : 양민지"
            + "Cube(지하에서 지상으로 이동) : 양민지"
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
