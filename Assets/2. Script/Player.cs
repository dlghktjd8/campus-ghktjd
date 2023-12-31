using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator PlayerAnim;
    public Rigidbody PlayerRigid;
    public float w_speed, wb_speed, olw_speed, rn_speed, ro_speed;
    public bool walking;
    public Transform PlayerTrans;
    
    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRigid.velocity = transform.forward * w_speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            PlayerRigid.velocity = -transform.forward * w_speed * Time.deltaTime;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerAnim.SetTrigger("walk");
            PlayerAnim.ResetTrigger("idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            PlayerAnim.ResetTrigger("walk");
            PlayerAnim.SetTrigger("idle");
            walking = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerAnim.SetTrigger("walkback");
            PlayerAnim.ResetTrigger("idle");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            PlayerAnim.ResetTrigger("walkback");
            PlayerAnim.SetTrigger("idle");
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTrans.Rotate(0, -ro_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTrans.Rotate(0, ro_speed * Time.deltaTime, 0);
        }
        if (walking == true)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                w_speed = w_speed + rn_speed;
                PlayerAnim.SetTrigger("run");
                PlayerAnim.ResetTrigger("walk");
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                w_speed = olw_speed;
                PlayerAnim.ResetTrigger("run");
                PlayerAnim.SetTrigger("walk");
            }
        }
    }
}
