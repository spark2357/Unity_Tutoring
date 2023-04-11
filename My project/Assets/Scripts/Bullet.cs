using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("�Ѿ��� �ӵ��Դϴ�.")]
    public float speed = 8f;
    [Header("�̸�ŭ �ð��� ������ �Ѿ��� �������.")]
    public float timer = 5f;

    public void Shoot(Vector2 direction)
    {
        StartCoroutine(MoveRoutine(direction));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {
            Debug.Log("���� �Ѿ˿� �¾ҽ��ϴ�! ���� �׿����ϴ�!");
            Destroy(collision.gameObject);
            StopAllCoroutines();
            Destroy(gameObject);
        }
    }

    IEnumerator MoveRoutine(Vector2 direction)
    {
        float deltaTime = 0;
        while (deltaTime < timer)
        {
            deltaTime += Time.deltaTime;
            transform.Translate(speed * Time.deltaTime * direction);
            yield return null;
        }
        Destroy(gameObject);
    }
}