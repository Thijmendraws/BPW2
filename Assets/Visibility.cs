using UnityEngine;
using UnityEngine.SceneManagement;

public class Visibility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Make sure the object persists between scene changes
        DontDestroyOnLoad(gameObject);
        
        // Check the current scene and adjust visibility accordingly
        UpdateVisibility();
    }

    // Update is called when a scene is loaded
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        UpdateVisibility();
    }

    // Update visibility based on the active scene
    void UpdateVisibility()
    {
        // Check the name of the currently active scene
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Determine visibility based on the scene name
        if (currentSceneName == "Day")
        {
            gameObject.SetActive(false); // Object is invisible in the "Day" scene
        }
        else if (currentSceneName == "Night")
        {
            gameObject.SetActive(true); // Object is visible in the "Night" scene
        }
    }
}