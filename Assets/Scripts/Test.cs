using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public float moveSpeed = 4f;
    public float jumpSpeed = 6f;
    public float gravity = -12f;
    float yVelocity = 0.0f;

    public CharacterController characterController;
    // Use this for initialization
    void Start () {
        characterController = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x > 2.38f)
        {
            transform.position = new Vector3(2.38f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -3.81f)
        {
            transform.position = new Vector3(-3.81f, transform.position.y, transform.position.z);
        }
        float y = transform.position.y;
        if (y < 0.4f)
        {
            Destroy(gameObject);
        }
        float x = Input.GetAxis("Horizontal");  // 문자열로 변수설정 (x 값) 
       
        Vector3 moveDirection = new Vector3(x, 0, 0); //x,z 값으로 이동
       //TransformDirection 월드좌표에서 로컬좌표로 바꿔준다!!! ( 카메라의 시선 반향과 컨트롤의 반향을 위치화시켜줌)
        moveDirection *= moveSpeed; //캐릭터 자체 이동속도 곲

        if (characterController.isGrounded)  //캐릭터 컨트롤러가 땅에 있을때.
        {
            yVelocity = 0f;
            if (Input.GetButton("Jump"))  //스페이스바를 누르면 or if(intput.getkeydown(keycode.space)) 같은말
            {
                yVelocity = jumpSpeed;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }
        yVelocity += (gravity * Time.deltaTime); //중력에 위한 점프속도값 감소후 추락표현
        moveDirection.y = yVelocity; // 점프키를 눌엇을떄  y값 변화
        characterController.Move(moveDirection * Time.deltaTime);

       
    }
    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.collider.gameObject.tag == "Enemy" || hit.collider.gameObject.tag == "Bullet")
    //    {
    //        //Destroy(gameObject);
    //        print(hit.gameObject.tag);
    //    }
    //    //print(hit.gameObject.tag);
    //}
    //private void OnCollisionEnter(Collision col)
    //{
    //    print(col.gameObject.name);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bullet")
        {
            //Destroy(gameObject);
            print("Destory");

        }
    }
}
