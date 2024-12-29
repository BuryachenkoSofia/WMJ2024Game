using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{
    public GameObject levelMenu, pauseMenu;
    public void Awake()
    {
        if (!PlayerPrefs.HasKey("difficultyLevel"))
        {
            PlayerPrefs.SetInt("difficultyLevel", 0);
        }
    }
    void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                PauseButton();
            }
        }
    }
    public void StartGame(int difficultyLevel)
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("difficultyLevel", difficultyLevel);
        if (difficultyLevel == 0)
        {
            SceneManager.LoadScene("Tutorial");
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
    public void StartButton()
    {
        levelMenu.SetActive(true);
    }
    public void ExitLevelMenu()
    {
        levelMenu.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void PauseButton()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
}