using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
    //variables GO HERE
    public float width = 5.0f;
    public float height = 5.0f;
    public int health = 3;
    public int numberOfHits = 0;
    public int motionCount = 0;
    float xmin;
    float ymin;
    float xmax;
    float ymax;
    
    //public enum DIRECTION() {UP, DOWN, LEFT, RIGHT };
    ////if player presses  left arrow advance one left
    ////if player presses up arrow advance one up
    ////if player presses down arrow advance one down
    ////if player presses right arrow advance one right
    //}

    // Use this for initialization
    void Start () {


     //constructor
	}
	
	// Update is called once per frame
	void Update () {
        
    
    }
    //method for player to move
    void Move()
    {
        this.transform.position = new Vector3();
    }

    //number of hits it can take
    void Hit()
    {


        health--;
        if (health <= 0)
        {
            Destroy(this);
            Destroy(trigger.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("weapon") == true)
        {
            Projectile projectile = trigger.gameObject.GetComponent<Projectile>();
            health -= projectile.damage;
            Destroy(trigger.gameObject);
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
            LoadSprites();
        }
    } 
}
