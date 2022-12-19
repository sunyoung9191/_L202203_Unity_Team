using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setactive : MonoBehaviour
{
    public Text GameOverText;

    void Start()
    {
        GameOverText.GetComponent<Text>().text = "지형, 안개, 물, 바람 효과, 에셋 추가, 디자인, 애니메이터 컴포넌트 스피드 속성 제어: 박선영 박현서" +
            "비너스 이미지 세이더 삽입(세이더 다루기 7-10): 박현서" +
            "고래, 행성, 신전, 사자상 흑백 세이더 삽입, 회전: 박선영" +
            "이미지 이펙트 세이더(invert, gray,depth,색상혼합):박현서" +
            "카메라 다루기(1-3): 박선영" +
            "폭포 생성: 박선영" +
            "3D 오브젝트를 활용한 구조물: 박현서" +
            "인덱스 캔버스 생성: 박선영" +
            "인덱스 활동 내역, 씬 인도: 박현서";
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