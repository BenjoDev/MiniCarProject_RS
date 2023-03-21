using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    [SerializeField]
    private Button exit_button;
    [SerializeField]
    private Button start_button;
    // Start is called before the first frame update



    void Start()
    {
        exit_button.onClick.AddListener(ExitClick);
        start_button.onClick.AddListener(StartClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitClick()
    {
        Application.Quit();
    }

    void StartClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
