using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �� ������Ʈ�� �÷��̾ ������ �� �� �ְ� �ϴ� ����� �߰��մϴ�.
public class PlayerAttack : MonoBehaviour
{
    [Header("�� �Ѿ�")]
    public Bullet bullet;
    [Header("���� �Ѿ��� �� �� ���� �������� ����")]
    public float cooldown = .25f;

    private float timer = 0f;

    void Update()
    {
        // �츮�� ��ũ��Ʈ�� �ۼ��� ��, Input.GetMouseButton(0) �̶�� �Լ��� ���� ���콺 ���� ��ư�� ���ȴ��� Ȯ���� �� �־��.
        if (Input.GetMouseButton(0))    // ���콺 ���� ��ư�� ������ �� �κ��� �����ؿ�.
        {
            if (timer <= 0)
            {
                Shoot();                // �� �κ��� ���콺 Ŀ���� ���� �Ѿ��� �߻��ؿ�.
                timer = cooldown;
            }
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }


    void Shoot()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mouseDirection = mousePosition - transform.position;
        Bullet newBullet = Instantiate(bullet);
        newBullet.transform.position = transform.position;
        newBullet.Shoot(mouseDirection.normalized);
    }
}