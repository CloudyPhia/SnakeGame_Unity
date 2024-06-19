using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSnakeScript : MonoBehaviour
{
    private Transform target; 
    private string prevDir;
    private Vector2 direction = Vector2.right; // EvilSnake can move in both x and y axis
    private List<Transform> segments; // List of EvilSnake's Segments
    public float speed;

    public Transform segmentPrefab; 
    public int initialSize = 4;

    private void Start(){

        segments = new List<Transform>();
        segments.Add(this.transform);
        speed = 0.1f;
        prevDir = "";
        
        target = GameObject.FindGameObjectWithTag("Food").GetComponent<Transform>();

        ResetState();
    }

    // Update: called every frame the game is running (variable)
    private void Update() {

        // float xdistance = Vector3.Distance(target.transform.position.x, this.transform.position.x);
        // float ydistance = Vector3.Distance(target.transform.position.y, this.transform.position.y);

        // negative means move left, positive means move right
        float xpos = Mathf.Abs(target.transform.position.x - this.transform.position.x); 
        // negative means move down, positive means move up 
        float ypos = Mathf.Abs(target.transform.position.y - this.transform.position.y);
        // Input Directions

        float xp = target.transform.position.x - this.transform.position.x;
        float yp = target.transform.position.y - this.transform.position.y;

        if ( (ypos >= xpos) && (yp >= 0) && prevDir != "up") {
            direction = Vector2.up;
            prevDir = "up";
        } else if ( (xpos > ypos) && (xp < 0) && prevDir != "left") {
            direction = Vector2.left;
            prevDir = "left";
        } else if ((ypos >= xpos) && (yp < 0) && prevDir != "down") {
            direction = Vector2.down;
            prevDir = "down";
        } else if ((xpos > ypos) && (xp >= 0) && prevDir != "right") {
            direction = Vector2.right;
            prevDir = "right";
        }
    }

    // FixedUpdate: ran at a fixed time interval ~ important for physics related code
    private void FixedUpdate() {

        // Add segments ~> iterating in reverse order such that each segment follows the head

        for (int i = segments.Count - 1; i > 0; i--) {
            segments[i].position = segments[i - 1].position;
        }

        // Movement of Snake
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + direction.x,
            Mathf.Round(this.transform.position.y) + direction.y,
            0.0f
        );
    
    }

    private void ResetState() {

        for (int i = 1; i < segments.Count; i++) { // index 0 is snake head, thus start at index 1
            
                Destroy(segments[i].gameObject);
        }
        segments.Clear(); // ensure references are destroyed
        segments.Add(this.transform);

        for (int i = 1; i < this.initialSize; i++) {
            segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero * 2f;

    }

    private void Grow() {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = segments[segments.Count - 1].position;

        segments.Add(segment); 
    }

    private void OnTriggerEnter2D(Collider2D otherCollider) {
        
        if (otherCollider.tag == "Food") {
            Grow();
        } else if (otherCollider.tag == "Obstacle" || otherCollider.tag == "Body" || otherCollider.tag == "Player") {
            // StartCoroutine(WaitForFunction(5));
            ResetState();
            // dead = true;
            // PlayerDeath();
        }
    } 

}
