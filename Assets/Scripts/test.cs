using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KoreanTyper;

public class test : MonoBehaviour
{
    public Text text;
    public int index = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch (index)
            {
                case 0: StartCoroutine(TypingCoroutine("20xx년 SCP라는 미지의 존재가 처음 발견된 이후 세상은 대혼란 속에 살아갔다.")); break;
                case 1: StartCoroutine(TypingCoroutine("그러던 어느날 S사 라는 회사가 나타나 셰계에 있는 SCP들을 잡아 시설에 격리하기 시작하였고")); break;
                case 2: StartCoroutine(TypingCoroutine("미지의 존재들로 부터 에너지와 자원을 얻어 인류의 발전에 기여하며 세계 최고의 회사로써 성장하였다.")); break;
                case 4: StartCoroutine(TypingCoroutine("그렇게 21xx년 당신은 S사에 신입으로 들어오게 되었습니다.")); break;
                case 5: StartCoroutine(TypingCoroutine("그것도 S사의 핵심 부서중 하나인 연구부서의 4팀 신입으로 들어오게되었습니다.")); break;
                case 6: StartCoroutine(TypingCoroutine("당신은 엄청난 행복감과 미래에 황금빛 같은 생활을 할 생각을 하며 첫 출근을 하게됩니다.")); break;

            }

            index++;
        }
    }

    public IEnumerator TypingCoroutine(string str)
    {
        int strTypingLength = str.GetTypingLength();      // 최대 타이핑 수를 구하고

        for (int i = 0; i <= strTypingLength; i++)        // 최대 타이핑 수 만큼 반복
        {
            text.text = str.Typing(i);                    // 텍스트 타이핑

            yield return new WaitForSeconds(0.02f); // 임의로 정한 시간 만큼 기다림
        }
    }
}
