using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0, 300);
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("space")) 
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);

        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.x > Screen.height || screenPosition.x <0)
        {
            Die();
        }
    }
    void OnCollision (Collision2D coll)
    {
        if(coll.gameObject.tag == "Obstacle")
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Game Over");
        StartCoroutine(DisplayGameOver());
    }
    IEnumerator DisplayGameOver()
    {
        yield return new WaitForSeconds(0.25f);
        gameOverScreen.SetActive(true);
    }
}
