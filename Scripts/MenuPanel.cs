using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPanel : MonoBehaviour
{
    [SerializeField] private int _gameSceneNum = 0;


    public void ContinueGame()
    {
        SceneManager.LoadScene(_gameSceneNum);
    }
}
