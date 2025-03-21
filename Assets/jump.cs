using UnityEngine;

public class jump : MonoBehaviour
{

    public Rigidbody2D myRidgedbody;
    public float FlapStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) == true)
       {
        myRidgedbody.linearVelocity = Vector2.up * FlapStrength;
       }
        
        
    }
}
