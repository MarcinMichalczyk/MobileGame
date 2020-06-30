using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public Text pointText;
    private int points = 0;
    // Start is called before the first frame update
    void Update()
    {
        pointText.text = "Score: " + points.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            points += 1;
            Destroy(other.gameObject);
        }
    }

    public void RestatrGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}