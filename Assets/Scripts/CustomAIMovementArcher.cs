using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class CustomAIMovementArcher : MonoBehaviour
{
    public Animator anim;
    private Transform target;

    public float radius;
    public Transform raycastPos;
    public GameObject player;

    public float speed = 200f;
    public float nextWaypointDistance = 3f;
    public float pathUpdateSpeed = .2f;
    public bool randomizerToggle = false;

    private Vector2 force;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    Rigidbody2D rb;
    public Vector2 targetPos;

    public Transform[] moveSpots;
    private int randomSpot;

    // Start is called before the first frame update
    void Start()
    {
        if (randomizerToggle == true)
        {
            Randomizer();
        }

        player = GameObject.Find("Player");
        target = player.GetComponent<Transform>();

        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, pathUpdateSpeed);

        seeker.StartPath(rb.position, moveSpots[randomSpot].position, OnPathComplete);

    }//End of Start

    void Update()
    {

        anim.SetFloat("dirx", rb.velocity.normalized.x);
        anim.SetFloat("diry", rb.velocity.normalized.y);
    }
    void FixedUpdate() //Ideal when working with physics
    {

        if (path == null)
        {
            return;
        }

        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
        }

        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position);
        force = direction * speed * Time.deltaTime;
        rb.AddForce(force);

        //Flip();

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }
        
        
        }//End of FixedUpdate

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }//End of OnPathComplete

    void UpdatePath() //This functions runs at update.
    {
        float distance = Vector2.Distance(target.position, transform.position);

        if (seeker.IsDone())
        {
            //if (distance <= AOA && AOAToggle == true) //So long as the distance of the player is less than the AOA and the aoa toggle is active
            
                Ranged(); //execute ranged
            
            
        }
    }// End of UpdatePath

    void Randomizer()
    {
        speed = Random.Range(700f, 800f);
        Debug.Log(speed);
        pathUpdateSpeed = Random.Range(.1f, 1f);
        Debug.Log(pathUpdateSpeed);
    }
    /*void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = Direction;
        Gizmos.DrawRay(transform.position, direction);
    }
    */
    void Ranged()
    {
       // int layerMask = 1 << 9;

       

        targetPos = target.position; //Setting target pos to player position as a vector2
        Vector2 Direction; //Declaring direction vec2
        Direction = targetPos - (Vector2)transform.position; //Getting the difference of the two positions
        RaycastHit2D ray = Physics2D.Raycast(raycastPos.transform.position, Direction);//Shooting a ray cast array of atleast two to see what we hit at the bow position heading in the direction of the difference
        Debug.Log(ray.transform.gameObject.name); 
        if (ray.transform.gameObject != null && ray.transform.gameObject.tag == "Player") //If ray is not null, which means if it is there, and so long as tag is no player
        {
             //Tell us what the raycast is
            seeker.StartPath(rb.position, target.position, OnPathComplete); //move
        }
            if (ray.transform.gameObject != null && ray.transform.gameObject.tag != "Player" && currentWaypoint >= path.vectorPath.Count) //If ray is not null, which means if it is there, and so long as tag is no player
            {
                seeker.StartPath(rb.position, moveSpots[randomSpot].position, OnPathComplete);

                if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
                {
                    randomSpot = Random.Range(0, moveSpots.Length);

                }
            }

        else
        {
            return;
        }
    }

    /*void Flip()
    {
        if (force.x >= 0.01f)
        {
            enemyGFX.localScale = new Vector3(-1f, 1f, 1f);
            firingpoint.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (force.x <= -0.01f)
        {

            enemyGFX.localScale = new Vector3(1f, 1f, 1f);
            firingpoint.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    */
}
    
