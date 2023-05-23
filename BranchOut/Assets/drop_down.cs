   using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class drop_down : MonoBehaviour
{
    public Dropdown dropdown;

    public void LoadLevel(int levelIndex)
    {
        switch (levelIndex)
        {
            case 0:
                Debug.Log("Please choose a level.");
                break;
            case 1:
                SceneManager.LoadScene("Level_1");
                break;
            case 2:
                SceneManager.LoadScene("Level_2");
                break;
            default:
                Debug.Log("Invalid level index.");
                break;
        }
    }
}
