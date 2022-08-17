using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Collider2D PlayerCollider;
    public Rigidbody2D rb;
    public int flappstrength = 1;
    private Animator animator;
    public GameObject GameOverUI;
    private WorldControl WorldControl;
    

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.name == "PointGate")
        {
            WorldControl.AddPoint(1);
        }
        if (collider.name == "PipeBottom" || collider.name == "PipeTop")
        {
            WorldControl.GameOver();

        }
        if (collider.name == "Grid")
        {
            WorldControl.GameOver();
        }
        
    }

    



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        WorldControl = FindObjectOfType<WorldControl>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Space))
        {


            Flapp();
            

           
        }

        if (Input.GetMouseButtonDown(0))
        {


            Flapp();



        }



    }

    private void Flapp()
    {
        animator.Play("PlayerFlapping");
        

        rb.AddForce(new Vector2(0, 1 * flappstrength), ForceMode2D.Impulse);
    }

    
       
    
}
