using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;

    Vector3 velocity;
    bool isGrounded;

    public Transform ground;
    public float distance = 0.3f;

    public float speed;
    public float JumpSpeed;
    public float gravity;
    public GameObject canvas;
    public GameObject mami;
    public LayerMask mask;





    void Start()
    {
        controller = GetComponent<CharacterController>();

    }
    void Update()

    {
        #region Movement
        float RightLeft = Input.GetAxis("Horizontal");
        float ForwardBack = Input.GetAxis("Vertical");

        Vector3 move = transform.right * RightLeft + transform.forward * ForwardBack;

        controller.Move(move * speed * Time.deltaTime);
        #endregion

        #region Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpSpeed * -3.0f * gravity);
        }


        #endregion

        #region Gravity

        isGrounded = Physics.CheckSphere(ground.position, distance, mask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        #endregion

        #region Fast
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed += 10;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed -= 10;
        }
        #endregion


        if (Input.GetKey("e"))
        {
            canvas.SetActive(false);
            mami.SetActive(false);

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GiantLine"))
        {
            Debug.Log("Temas");
            GiantAnimationController.animator.SetBool("isTouched", true);
            Destroy(other.gameObject);
            canvas.SetActive(true);
        }
        else
            GiantAnimationController.animator.SetBool("isTouched", false);
    }

}