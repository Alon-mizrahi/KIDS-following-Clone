using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public GameObject Target;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(22.5f, 0f, 0f, Space.Self);
        Target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }


    void FollowTarget()
    {
        gameObject.transform.position = Target.transform.position + offset;
    }




}
