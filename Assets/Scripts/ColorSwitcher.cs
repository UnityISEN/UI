using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorSwitcher : MonoBehaviour {
    [UsedImplicitly]
    public void OnClick() {
        SceneManager.LoadScene("SampleScene");
    }
}