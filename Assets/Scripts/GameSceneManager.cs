using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManager : MonoBehaviour
{
    [SerializeField] private int reloadTime = 5;

    public void ReloadScene()
    {
        StartCoroutine(ReloadAfterSec());
    }

    IEnumerator ReloadAfterSec()
    {
        yield return new WaitForSeconds(reloadTime);
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
