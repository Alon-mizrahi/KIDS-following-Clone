using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject GMobject;
    GameManager GM;

    float PlayerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        GM = GMobject.GetComponent<GameManager>();
        PlayerSpeed = GM.PlayerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }



    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.back) * Time.deltaTime * PlayerSpeed;
        }
    }



}
