using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;   // �̵��� ����ϴ� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵� �ӷ�

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()   // 60FPS(Frame Per Secound) 1�ʿ� 60�� ����
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        /* 
         * rigidbody ������Ʈ�� ���� �ӵ��� ǥ���ϴ� Vector3Ÿ���� velocity ������ �����Ѵ�.
         * velocity ������ ���� �ӵ��� �� �� ������, �ݴ�� �ش� ������ ���ο� ���� �Ҵ��Ͽ� ���� �ӵ��� ���� �� �� �ִ�. 
        */
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);  // Vector3�� x, y, z�� ������ Ÿ��. ��ġ ũ�� ���� ������� ��Ÿ�� �� �ַ� ���
        // ������ٵ��� �ӵ���  newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;



        /*== ���1. key s ========================================*/
/*        if(Input.GetKey(KeyCode.UpArrow) == true)
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
        }*/
        /*== key e ========================================*/


    }

    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� �����Ͽ� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }

}
