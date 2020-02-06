using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    public void OnStart() {
        SceneManager.LoadScene("SampleScene");
    }
}