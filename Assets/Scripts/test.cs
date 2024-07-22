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
                case 3: StartCoroutine(TypingCoroutine("그렇게 21xx년 당신은 S사에 신입으로 들어오게 되었습니다.")); break;
                case 4: StartCoroutine(TypingCoroutine("그것도 S사의 핵심 부서중 하나인 연구부서의 4팀 신입으로 들어오게되었습니다.")); break;
                case 5: StartCoroutine(TypingCoroutine("당신은 엄청난 행복감과 미래에 황금빛 같은 생활을 할 생각을 하며 첫 출근을 하게됩니다.")); break;
                case 6: StartCoroutine(TypingCoroutine("첫날, 당신은 회사의 복잡한 구조와 수많은 연구 장비들에 놀라움을 금치 못합니다.")); break;
                case 7: StartCoroutine(TypingCoroutine("곧이어 팀장님께서 나타나 신입 환영 인사를 하십니다.")); break;
                case 8: StartCoroutine(TypingCoroutine("빅터: '환영합니다. 우리 팀에 합류하게 된걸 축하드립니다.'")); break;
                case 9: StartCoroutine(TypingCoroutine("당신은 팀원들과 인사를 나누고, 본격적인 업무를 시작합니다.")); break;
                case 10: StartCoroutine(TypingCoroutine("첫 과제는 SCP-173에 대한 연구 자료를 분석하는 것이었습니다.")); break;
                case 11: StartCoroutine(TypingCoroutine("빅터: '처음이라 어렵겠지만, 우리가 도와줄테니 걱정 마세요.'")); break;
                case 12: StartCoroutine(TypingCoroutine("당신은 팀원들의 도움으로 서서히 업무에 적응해 갑니다.")); break;
                case 13: StartCoroutine(TypingCoroutine("며칠 후, 첫 연구 결과를 발표하게 됩니다.")); break;
                case 14: StartCoroutine(TypingCoroutine("빅터: '잘 했습니다. 앞으로도 기대가 큽니다.'")); break;
                case 15: StartCoroutine(TypingCoroutine("당신은 연구원으로서의 첫 발걸음을 성공적으로 내딛었습니다.")); break;
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
