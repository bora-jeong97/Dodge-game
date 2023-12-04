using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public float speed = 8f; // 이동 속력

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   // 60FPS(Frame Per Secound) 1초에 60번 갱신
    {

        /*== key s ========================================*/
        if(Input.GetKey(KeyCode.UpArrow) == true)
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
        }
        /*== key e ========================================*/


    }

    public void Die()
    {
        //자신의 게임 오브젝트에 접근하여 비활성화
        gameObject.SetActive(false);
    }

}
