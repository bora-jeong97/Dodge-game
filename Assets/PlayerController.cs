using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float speed = 8f; // �̵� �ӷ�

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   // 60FPS(Frame Per Secound) 1�ʿ� 60�� ����
    {

        /*== key s ========================================*/
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }


        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // ������ ����Ű �Է��� ������ ��� x ���� �� �ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }


        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ��� -x ���� �� �ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        /*== key e ========================================*/


    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� �����Ͽ� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }

}
