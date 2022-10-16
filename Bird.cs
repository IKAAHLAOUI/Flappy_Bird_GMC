
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
   public int JumpForce = 30;
    public int speed = 30;
    public GameObject Button,restart;
   
    
    // Start is called before the first frame update
    void Start()
    {
         Time.timeScale = 0;
        restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
          
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0) * speed * Time.deltaTime;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
          
        }
            
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Obstacle")
        { 
            GetComponent<Animator>().SetBool("DIE", true);
            JumpForce = 0;
            restart.SetActive(true);
            gameObject.tag = "Untagged";
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }
    


    public void makeFlyTrue()
    {
        Time.timeScale = 1;
        Button.SetActive(false);

        

    }
    public void res()
    {
        SceneManager.LoadScene(0);
    }

}
