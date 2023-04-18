
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelChange : MonoBehaviour
{
    public void loadlevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}