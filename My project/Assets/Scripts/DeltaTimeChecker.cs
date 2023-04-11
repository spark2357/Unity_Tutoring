using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeChecker : MonoBehaviour
{
    [Header("�� �� ���� ������ ������ ���մϴ�.")]
    public float time = 3f;

    private float timer;
    private float value;
    private float dValue;
    private bool isEnd = false;

    private void Start()
    {
        timer = 0f;
        value = 0f;
        dValue = 0f;
    }

    void Update()
    {
        if (timer < time)
        {
            value += 1;
            dValue += 1 * Time.deltaTime;
            timer += Time.deltaTime;
        }
        else
        {
            if (isEnd == false)
            {
                isEnd = true;
                Debug.Log(
                    timer + " �ʰ� �������ϴ�.\n" +
                    "DeltaTime�� ����� �������� " + dValue + "�Դϴ�. DeltaTime�� ������� ���� �������� " + value + " �Դϴ�.");
            }
        }
    }
}