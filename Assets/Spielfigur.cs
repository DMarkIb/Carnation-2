using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Spielfigur : MonoBehaviour
{
    NavMeshAgent agent;
    public Animator Player;
    float extraRotationSpeed = 2f;
    float distanceToTarget;
    Vector3 Ziel;
    float clicktime = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 1f;
    }

    void extraRotation()
    {
        Vector3 lookrotation = agent.steeringTarget - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookrotation), extraRotationSpeed * Time.deltaTime);

    }

    void Update()
    {
        if (Player.GetBool("InBewegung"))
        {
            extraRotation();
        }
        if (Input.GetMouseButtonDown(0))
        {
            clicktime = Time.time;
            SetDestinationToMousePosition();
        }
        if (Time.time - clicktime > 5)
        {
            Player.SetBool("InBewegung", false);
        }
        CheckDestinationReached();


    }

    void SetDestinationToMousePosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Ziel = hit.point;
            Player.SetBool("InBewegung", true);
            agent.SetDestination(hit.point);
        }
    }
    void CheckDestinationReached()
    {
        distanceToTarget = Vector3.Distance(transform.position, Ziel);
        if (distanceToTarget < 0.4f)
        {
            Player.SetBool("InBewegung", false);
            
        }
    }
}
