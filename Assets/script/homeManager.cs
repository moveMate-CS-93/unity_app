using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HomePageManager : MonoBehaviour
{
    public TextMeshProUGUI usernameText;

    // Start is called before the first frame update
    // void Start()
    // {
    //     if (AuthManager.CurrentUser != null)
    //     {
    //         usernameText.text = "Welcome, " + AuthManager.CurrentUser.Username + "!";
    //     }
    // }

// Update is called once per frame
void Update()
{
    if (AuthManager.CurrentUser != null)
    {
        usernameText.text = AuthManager.CurrentUser.Username + "!";
    }
}
}