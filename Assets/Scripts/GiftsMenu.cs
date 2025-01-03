using UnityEngine;
using UnityEngine.UI;
public class GiftsMenu : MonoBehaviour
{
    public GameObject[] gifts = new GameObject[6];
    public GameObject[] levelGifts = new GameObject[6];
    public Text allGiftsText;
    void Start()
    {
        Check();
    }
    public void Check(){
        if (!PlayerPrefs.HasKey("completedLevel0"))
        {
            PlayerPrefs.SetInt("completedLevel0", 0);
        }
        if (!PlayerPrefs.HasKey("completedLevel1"))
        {
            PlayerPrefs.SetInt("completedLevel1", 0);
        }
        if (!PlayerPrefs.HasKey("completedLevel2"))
        {
            PlayerPrefs.SetInt("completedLevel2", 0);
        }
        if (!PlayerPrefs.HasKey("completedLevel3"))
        {
            PlayerPrefs.SetInt("completedLevel3", 0);
        }
        if (!PlayerPrefs.HasKey("completedLevel4"))
        {
            PlayerPrefs.SetInt("completedLevel4", 0);
        }
        if (!PlayerPrefs.HasKey("completedLevel5"))
        {
            PlayerPrefs.SetInt("completedLevel5", 0);
        }
        if (!PlayerPrefs.HasKey("completedAllLevel"))
        {
            PlayerPrefs.SetInt("completedAllLevel", 0);
        }

        if (PlayerPrefs.GetInt("completedLevel0") == 1)
        {
            gifts[0].SetActive(true);
            levelGifts[0].SetActive(false);
        }
        else
        {
            gifts[0].SetActive(false);
            levelGifts[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("completedLevel1") == 1)
        {
            gifts[1].SetActive(true);
            levelGifts[1].SetActive(false);
        }
        else
        {
            gifts[1].SetActive(false);
            levelGifts[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("completedLevel2") == 1)
        {
            gifts[2].SetActive(true);
            levelGifts[2].SetActive(false);
        }
        else
        {
            gifts[2].SetActive(false);
            levelGifts[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("completedLevel3") == 1)
        {
            gifts[3].SetActive(true);
            levelGifts[3].SetActive(false);
        }
        else
        {
            gifts[3].SetActive(false);
            levelGifts[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("completedLevel4") == 1)
        {
            gifts[4].SetActive(true);
            levelGifts[4].SetActive(false);
        }
        else
        {
            gifts[4].SetActive(false);
            levelGifts[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("completedLevel5") == 1)
        {
            gifts[5].SetActive(true);
            levelGifts[5].SetActive(false);
        }
        else
        {
            gifts[5].SetActive(false);
            levelGifts[5].SetActive(true);
        }
        if(PlayerPrefs.GetInt("completedLevel0") == 1 && PlayerPrefs.GetInt("completedLevel1") == 1 && PlayerPrefs.GetInt("completedLevel2") == 1 && PlayerPrefs.GetInt("completedLevel3") == 1 && PlayerPrefs.GetInt("completedLevel4") == 1 && PlayerPrefs.GetInt("completedLevel5") == 1)
        {
            PlayerPrefs.SetInt("completedAllLevel", 1);
        }
        else
        {
            PlayerPrefs.SetInt("completedAllLevel", 0);
        }

        if (PlayerPrefs.GetInt("completedAllLevel") == 1)
        {
            allGiftsText.text="You have completed all difficulty levels! Congratulations!";
        }
        else
        {
            allGiftsText.text="Complete all difficulty levels to get all gifts";
        }
    }
}