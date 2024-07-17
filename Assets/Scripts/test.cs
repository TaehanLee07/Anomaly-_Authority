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
                case 0: StartCoroutine(TypingCoroutine("20xx�� SCP��� ������ ���簡 ó�� �߰ߵ� ���� ������ ��ȥ�� �ӿ� ��ư���.")); break;
                case 1: StartCoroutine(TypingCoroutine("�׷��� ����� S�� ��� ȸ�簡 ��Ÿ�� �ΰ迡 �ִ� SCP���� ��� �ü��� �ݸ��ϱ� �����Ͽ���")); break;
                case 2: StartCoroutine(TypingCoroutine("������ ������ ���� �������� �ڿ��� ��� �η��� ������ �⿩�ϸ� ���� �ְ��� ȸ��ν� �����Ͽ���.")); break;
                case 4: StartCoroutine(TypingCoroutine("�׷��� 21xx�� ����� S�翡 �������� ������ �Ǿ����ϴ�.")); break;
                case 5: StartCoroutine(TypingCoroutine("�װ͵� S���� �ٽ� �μ��� �ϳ��� �����μ��� 4�� �������� �����ԵǾ����ϴ�.")); break;
                case 6: StartCoroutine(TypingCoroutine("����� ��û�� �ູ���� �̷��� Ȳ�ݺ� ���� ��Ȱ�� �� ������ �ϸ� ù ����� �ϰԵ˴ϴ�.")); break;

            }

            index++;
        }
    }

    public IEnumerator TypingCoroutine(string str)
    {
        int strTypingLength = str.GetTypingLength();      // �ִ� Ÿ���� ���� ���ϰ�

        for (int i = 0; i <= strTypingLength; i++)        // �ִ� Ÿ���� �� ��ŭ �ݺ�
        {
            text.text = str.Typing(i);                    // �ؽ�Ʈ Ÿ����

            yield return new WaitForSeconds(0.02f); // ���Ƿ� ���� �ð� ��ŭ ��ٸ�
        }
    }
}
