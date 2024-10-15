using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountHits : MonoBehaviour
{
    private int hits = 0;
    public ScoreManager scoreManager; // Reference to the ScoreManager

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the ScoreManager is linked
        if (scoreManager == null)
        {
            scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager == null)
            {
                Debug.LogError("ScoreManager not found in the scene. Please ensure it is added.");
            }

        }
    }

        // Update is called once per frame
        void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fairways")
        {
            // Crește numărul de lovituri
            hits++;

            // Afișează mesajul în consolă
            Debug.Log("Mingea a fost lovită de crosă! Numar de lovituri: " + hits);

            // Update the score using ScoreManager
            scoreManager.UpdateScore();
        }
    }
}
