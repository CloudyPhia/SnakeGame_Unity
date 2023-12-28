using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    // Credit to Zigurous on Youtube [https://www.youtube.com/watch?v=U8gUnpeaMbQ&ab_channel=Zigurous] 
    // for the base tutorial 

    public BoxCollider2D gridArea;

    private void Start() {
        RandomizePosition();
    }

    private void RandomizePosition(){
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        // Randomize food position
        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider) {
        
        if (otherCollider.tag == "Player") {
            RandomizePosition();

        }
    } 



}
