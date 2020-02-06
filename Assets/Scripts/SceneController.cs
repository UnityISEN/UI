using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    [SerializeField] private UnityEvent onStartEvent = default;

    public void OnStart() {
        onStartEvent.Invoke();
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuit() {
        Application.Quit();
    }
}