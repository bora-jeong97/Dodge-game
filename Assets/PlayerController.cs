using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;   // 이동에 사용하는 리지드바디 컴포넌트
    public float speed = 8f; // 이동 속력

    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()   // 60FPS(Frame Per Secound) 1초에 60번 갱신
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        /* 
         * rigidbody 컴포넌트는 현재 속도를 표현하는 Vector3타입의 velocity 변수를 제공한다.
         * velocity 변수로 현재 속도를 알 수 있으며, 반대로 해당 변수에 새로운 값을 할당하여 현재 속도를 변경 할 수 있다. 
        */
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);  // Vector3은 x, y, z를 가지는 타입. 위치 크기 솓도 방향등을 나타낼 때 주로 사용
        // 리지드바디의 속도에  newVelocity 할당
        playerRigidbody.velocity = newVelocity;



        /*== 방법1. key s ========================================*/
/*        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            // 위쪽 방향키 입력이 감지된 경우 z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘 주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }


        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘 주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }


        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // 왼쪽 방향키 입력이 감지된 경우 -x 방향 힘 주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }*/
        /*== key e ========================================*/


    }

    public void Die()
    {
        //자신의 게임 오브젝트에 접근하여 비활성화
        gameObject.SetActive(false);
    }

}
