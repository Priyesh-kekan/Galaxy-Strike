using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX;
    private GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType <GameSceneManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hit" +  other.gameObject.name);
        //Debug.Log($"Hit {other.gameObject.name}");
        Instantiate(explosionVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gameSceneManager.ReloadScene();
    }
}
