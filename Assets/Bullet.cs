using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;    // 탄알 이동 속력
    private Rigidbody bullectRigidbody; 


    void Start()
    {
        bullectRigidbody = GetComponent<Rigidbody>();
        // 리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bullectRigidbody.velocity = transform.forward * speed;  // tranform 변수는 자신의 게임 오브젝트의 트랜스폼 컴포넌트로 바로 접근 할 수 잇게 해주는 변수이다.

        // 3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f); 

        
    }

    // 트리거 충돌 시 자동 실행 메서드
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if(other.tag == "Player")
        {
            // 상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();


            // 상대방으로부터 PlayerController 컴포넌트 가져오는데 성공햇다면
            if(playerController != null)
            {
                // 상대방이 PlayerController 컴포넌트의 Die() 메서드 실행
                playerController.Die();
            }
        }
    }


}
 