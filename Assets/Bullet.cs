using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;    // ź�� �̵� �ӷ�
    private Rigidbody bullectRigidbody; 


    void Start()
    {
        bullectRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bullectRigidbody.velocity = transform.forward * speed;  // tranform ������ �ڽ��� ���� ������Ʈ�� Ʈ������ ������Ʈ�� �ٷ� ���� �� �� �հ� ���ִ� �����̴�.

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f); 

        
    }

    // Ʈ���� �浹 �� �ڵ� ���� �޼���
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag == "Player")
        {
            // ���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();


            // �������κ��� PlayerController ������Ʈ �������µ� �����޴ٸ�
            if(playerController != null)
            {
                // ������ PlayerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();
            }
        }
    }


}
 