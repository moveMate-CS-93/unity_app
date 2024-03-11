using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import the Unity UI namespace

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate = 5f; // Adjust this value to control the spawn rate

    bool gameStarted = false;

    public GameObject tapText;
    public Text scoreText; // Change TextMeshProUGUI to Text

    int score = 0;
    FirestoreManager firestoreManager;

     void Start()
    {
        firestoreManager = new FirestoreManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPos, Quaternion.identity);

        score++;

        

          // Update the user's score in the database
        // User currentUser = AuthManager.CurrentUser; // Get the current user
        // if (currentUser != null)
        // {
        //     currentUser.Score = score;
        //     firestoreManager.StoreUserData(currentUser);
        // }
         // Update the score in the UI
        scoreText.text = score.ToString();

        // Update the user's score in the AuthManager
        AuthManager.CurrentUser.Score = score;
    }
}
