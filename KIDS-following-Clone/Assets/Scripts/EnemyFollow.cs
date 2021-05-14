using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public  GameObject Target;
    //public GameObject GMobject;
   // GameManager GM;


    // Start is called before the first frame update
    void Start()
    {
        //GMobject = GameObject.FindWithTag("GameController");
        //GM = GMobject.GetComponent<GameManager>();
        Target = GameObject.FindWithTag("Player");
        enemy = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }


    void FollowTarget()
    {
        enemy.SetDestination(Target.transform.position);
    }


}
