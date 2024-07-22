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
                case 8: StartCoroutine(TypingCoroutine("빅터: 환영합니다. 우리 팀에 합류하게 된걸 축하드립니다.")); break;
                case 9: StartCoroutine(TypingCoroutine("당신은 팀원들과 인사를 나누고, 본격적인 업무를 시작합니다.")); break;
                case 10: StartCoroutine(TypingCoroutine("첫 과제는 SCP-173에 대한 연구 자료를 분석하는 것이었습니다.")); break;
                case 11: StartCoroutine(TypingCoroutine("빅터: 처음이라 어렵겠지만, 우리가 도와줄테니 걱정 마세요.")); break;
                case 12: StartCoroutine(TypingCoroutine("당신은 팀원들의 도움으로 서서히 업무에 적응해 갑니다.")); break;
                case 13: StartCoroutine(TypingCoroutine("며칠 후, 첫 실습시간이 오게됩니다.")); break;
                case 14: StartCoroutine(TypingCoroutine("빅터: 긴장하지말고 잘 따라와주기만 해.")); break;
                case 15: StartCoroutine(TypingCoroutine("그렇게 당신은 연구원으로서의 첫 발걸음을 내딛기 위하여 실험실로 들어갑니다.")); break;
                case 16: StartCoroutine(TypingCoroutine("실험실 내부는 첨단 장비와 수많은 모니터로 가득 차 있었습니다.")); break;
                case 17: StartCoroutine(TypingCoroutine("빅터: 이곳이 우리가 일하는 장소입니다. 모든 실험은 여기서 진행되죠.")); break;
                case 18: StartCoroutine(TypingCoroutine("당신은 흥분과 약간의 두려움을 느끼며 장비들을 둘러봅니다.")); break;
                case 19: StartCoroutine(TypingCoroutine("빅터: 자, 오늘의 실습은 SCP-173의 특성을 분석하는 것입니다. 집중해 주세요.")); break;
                case 20: StartCoroutine(TypingCoroutine("당신은 팀장님의 지시에 따라 데이터를 수집하고 분석하기 시작합니다.")); break;
                case 21: StartCoroutine(TypingCoroutine("실습 도중, 갑자기 경보음이 울리기 시작합니다.")); break;
                case 22: StartCoroutine(TypingCoroutine("빅터: 침착하세요! 모두 지정된 위치로 대피하세요.")); break;
                case 23: StartCoroutine(TypingCoroutine("당신은 긴장된 마음으로 지시에 따라 대피합니다.")); break;
                case 24: StartCoroutine(TypingCoroutine("빅터: 시스템 오류입니다. SCP-173이 격리에서 탈출하려고 합니다.")); break;
                case 25: StartCoroutine(TypingCoroutine("당신은 공포에 휩싸이지만, 팀원들과 함께 문제를 해결하기 위해 최선을 다합니다.")); break;
                case 26: StartCoroutine(TypingCoroutine("결국, 팀의 협력으로 SCP-173을 다시 격리하는 데 성공합니다.")); break;
                case 27: StartCoroutine(TypingCoroutine("빅터: 잘했어요. 이번 경험은 앞으로 큰 도움이 될 겁니다.")); break;
                case 28: StartCoroutine(TypingCoroutine("당신은 안도의 한숨을 쉬며, 연구원으로서의 책임감을 더욱 느끼게 됩니다.")); break;
                case 29: StartCoroutine(TypingCoroutine("그렇게 첫 실습이 끝나고, 당신은 앞으로의 여정을 기대하며 사무실로 돌아갑니다.")); break;
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
