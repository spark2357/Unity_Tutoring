using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingCamera : MonoBehaviour
{
    // �÷��̾� ��ġ
    public Transform target;
    // õõ�� ���󰡴� �ӵ� ���� ��ġ
    public float chase_speed = 10f;
    // �÷��̾�� ī�޶� �Ÿ�
    public Vector3 offset;
    void FixedUpdate()
    {
        Vector3 final_target = target.position + offset;
        Vector3 slow_chase_player_target = Vector3.Lerp(transform.position, final_target, chase_speed * Time.deltaTime);

        transform.position = new Vector3(slow_chase_player_target.x, slow_chase_player_target.y, transform.position.z);
    }
}
