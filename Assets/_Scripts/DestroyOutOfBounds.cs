using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{

    public enum level { Game };

    private float topBound = 30f;

    private float lowerBound = -10f;
    
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }
        
        if (this.transform.position.z < lowerBound)
        {
            Debug.Log("GAME OVER!!!!");
            Destroy(this.gameObject);
            GameOver();           
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("End");
    }
}
