using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public float moveSpeed = 7f;
    public float jumpSpeed = 14f;
    public float gravity = -12f;
    float yVelocity = 0.0f;
    public bool icesteped;
    public bool Reversed;
    public float Reopsidetime;
    public float reverscool;
    public float cool;
    public float opsidetime;
    public float Sp = 100;
    public Animation Chiackmove;
    public GameObject Spba;
    public bool jumpping;
    public bool rightmove;
    public bool leftmove;
    public GameObject chirk1;
    public GameObject chirk2;
    public GameObject chirk3;
    public GameObject chirk4;
    public GameObject chirk5;
    public float Score;
    public float Best;
    
    public float scoregolde;
    public GameObject ScoreUp;
    public GameObject scroe;
    public GameObject gold;
    public GameObject bestup;
    public float Savegold;
   







    public CharacterController characterController;
    // Use this for initialization
    void Start () {
        characterController = GetComponent<CharacterController>();
        Best = PlayerPrefs.GetInt("Bestscore");
        bestup.GetComponent<UILabel>().text = "Best : " + (int)Best;
        Savegold = PlayerPrefs.GetInt("Gold");
        gold.GetComponent<UILabel>().text = "" + Savegold;
        Time.timeScale = 0;
       


        if (PlayerPrefs.GetInt("chari1") == 1)
        {
            chirk1.SetActive(true);
            chirk2.SetActive(false);
            chirk3.SetActive(false);
            chirk4.SetActive(false);
            chirk5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari2") == 1)
        {
            chirk2.SetActive(true);
            chirk1.SetActive(false);
            chirk3.SetActive(false);
            chirk4.SetActive(false);
            chirk5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari3") == 1)
        {
            chirk3.SetActive(true);
            chirk2.SetActive(false);
            chirk1.SetActive(false);
            chirk4.SetActive(false);
            chirk5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari4") == 1)
        {
            chirk4.SetActive(true);
            chirk2.SetActive(false);
            chirk3.SetActive(false);
            chirk1.SetActive(false);
            chirk5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("chari5") == 1)
        {
            chirk5.SetActive(true);
            chirk2.SetActive(false);
            chirk3.SetActive(false);
            chirk4.SetActive(false);
            chirk1.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        Score += Time.deltaTime;
        if (Score > Best)
        {
           
            PlayerPrefs.SetInt("Bestscore", (int)Score);
        }
        scroe.GetComponent<UILabel>().text = "Score : " + (int)Score;
       
        scoregolde += Time.deltaTime;
        golesystem();
        gold.GetComponent<UILabel>().text = "" + (int)Savegold;
       
        PlayerPrefs.SetInt("Gold", (int)Savegold);
        if (Reversed == true)
        {
            Reopsidetime += Time.deltaTime;
            moveSpeed = -7f;
            if (Reopsidetime > reverscool)
            {
                Reopsidetime = 0f;
                   moveSpeed = 7f;
                Reversed = false;
            }
        }
        if (Sp <= 0)
        {
            PlayerPrefs.DeleteKey("Stage");
            Time.timeScale = 0f;
            ScoreUp.transform.localPosition = new Vector3(-7, -10, 0);
            Destroy(gameObject);   
        }
        if(Sp >= 100)
        {
            Sp = 100;
        }
        Sp -= 3*Time.deltaTime;
        Spba.GetComponent<UIProgressBar>().value = Sp / 100;
      
        if (icesteped == true)
        {
            opsidetime += Time.deltaTime;
            if (opsidetime < cool)
            {
                moveSpeed = -moveSpeed;
            }
        }
        if (opsidetime > cool)
        {
            moveSpeed = 7f;
            opsidetime = 0;
            icesteped = false;

        }
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
            PlayerPrefs.DeleteKey("Stage");
            Time.timeScale=0f;
            ScoreUp.transform.localPosition = new Vector3(-7, -10, 0);
            Destroy(gameObject);
            
        }

        float x = Input.GetAxis("Horizontal");  // 문자열로 변수설정 (x 값) 

        Vector3 moveDirection = new Vector3(x, 0, 0); //x,z 값으로 이동
      
        moveDirection *= moveSpeed; //캐릭터 자체 이동속도 곲
       
        if (characterController.isGrounded)  //캐릭터 컨트롤러가 땅에 있을때.
        {
            chirk1.GetComponent<Animator>().SetBool("Jump", false);
            chirk2.GetComponent<Animator>().SetBool("Jump", false);
            chirk3.GetComponent<Animator>().SetBool("Jump", false);
            chirk4.GetComponent<Animator>().SetBool("Jump", false);
            chirk5.GetComponent<Animator>().SetBool("Jump", false);
            //Chiackmove.Play("RUN00_F");
            yVelocity = 0f;
            if (Input.GetButton("Jump"))  //스페이스바를 누르면 or if(intput.getkeydown(keycode.space)) 같은말
            {
                yVelocity = jumpSpeed;
               
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
                //Chiackmove.Play("JUMP00B");
                chirk1.GetComponent<Animator>().SetBool("Jump", true);
                chirk2.GetComponent<Animator>().SetBool("Jump", true);
                chirk3.GetComponent<Animator>().SetBool("Jump", true);
                chirk4.GetComponent<Animator>().SetBool("Jump", true);
                chirk5.GetComponent<Animator>().SetBool("Jump", true);


            }
            if (jumpping == true)
            {
                yVelocity = jumpSpeed;
                //Chiackmove.Play("JUMP00B");
                jumpping =false;
                chirk1.GetComponent<Animator>().SetBool("Jump", true);
                chirk2.GetComponent<Animator>().SetBool("Jump", true);
                chirk3.GetComponent<Animator>().SetBool("Jump", true);
                chirk4.GetComponent<Animator>().SetBool("Jump", true);
                chirk5.GetComponent<Animator>().SetBool("Jump", true);

            }
        }
        yVelocity += (gravity * Time.deltaTime); //중력에 위한 점프속도값 감소후 추락표현
        moveDirection.y = yVelocity; // 점프키를 눌엇을떄  y값 변화
        characterController.Move(moveDirection * Time.deltaTime);
       
        if (leftmove == true)
        {
            x = -20*Time.deltaTime;
            Vector3 moveDirection2 = new Vector3(x, 0, 0);
            moveDirection2 *= moveSpeed;
            characterController.Move(moveDirection2 * Time.deltaTime);
        }
        if (rightmove == true)
        {
            x = 20* Time.deltaTime;
            Vector3 moveDirection3 = new Vector3(x, 0, 0);
            moveDirection3 *= moveSpeed;
            characterController.Move(moveDirection3 * Time.deltaTime);
           
        }


    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bullet")
        {
            PlayerPrefs.DeleteKey("Stage");
            Time.timeScale = 0f;
            ScoreUp.transform.localPosition = new Vector3(-7, -10, 0);
            //Destroy(gameObject);
            print("Destory");

        }
  
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "ICE")
        {
            print("!");
            icesteped = true;
            
          
        }
        if (hit.gameObject.tag == "Yellow")
        {
            Sp = Sp + 15*Time.deltaTime;
        }
        if (hit.gameObject.tag == "Revers")
        {
            Reversed = true;
        }
       

    }
    void golesystem()
    {
        if (scoregolde > 2)
        {
            Savegold = Savegold + 1;
            scoregolde = 0;
        }
    }
   public void jump()
    {
        jumpping = true;
    }
    public void Left()
    {
        print("Left");
        leftmove = true;
        //transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        //float x = Input.GetAxis("Horizontal");


        //Vector3 moveDirection = new Vector3(x, 0, 0);
        //moveDirection *= moveSpeed;
        //characterController.Move(-moveDirection * Time.deltaTime);
    }
    public void Right()
    {
        print("Right");
        rightmove = true;
        //transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        //float x = Input.GetAxis("Horizontal");

        //Vector3 moveDirection = new Vector3(x, 0, 0);
        //moveDirection *= moveSpeed;
        //characterController.Move(moveDirection * Time.deltaTime);
    }
    public void Left2()
    {
        leftmove = false;
    }
    public void Right2()
    {
        rightmove = false;
    }
}
