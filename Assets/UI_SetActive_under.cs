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
            = "전체적인 디자인 및 오브젝트 배치 : 양민지, 오하은, 윤하은\n"
            + "효과(사운드,Particle) 추가 : 윤하은, 양민지\n"
            + "조명 및 Terrain : 오하은\n"
            + "오브젝트 셰이더 추가 : 오하은, 양민지\n"
            + "MagicFire 추가 및 배치 : 양민지, 윤하은\n"
            + "16777_Hades_V1_NEW 셰이더 적용 : 양민지\n"
            + "Explosion : 양민지 윤하은\n"
            + "Eagle_Normal : 윤하은\n"
            + "Rubble_3 : 양민지\n"
            + "Post-Process Layer 및 Post-process Volume 카메라 후처리: 윤하은\n"
            + "Flashlight에 Spot 조명 효과: 윤하은\n"
            + "Camera_minimap, Minimap : 윤하은\n"
            + "Mirror 효과 : 윤하은\n"
            + "Entrance : 양민지\n"
            + "Tree, Altar_2, Wolf_howl,Wolf : 양민지\n"
            + "Cube(지하에서 지상으로 이동) : 양민지\n"
            + "stairs_1 (1), Chair, Chair(1),Fences : 오하은\n"
            + "StrangeCube : 오하은\n"
            + "skull : 양민지\n"
            + "Rock 관련 오브젝트 셰이더 : 양민지\n"
            + "Statues, Plates : 오하은\n"
            + "Column, Zombies 추가: 양민지\n" +
            "Image Effect : 윤하은\n"
            + "Cerabus 추가 및 애니매이터 : 오하은\n";
            
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
