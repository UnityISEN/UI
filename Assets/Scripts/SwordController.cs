using UnityEngine;

namespace DefaultNamespace {
    public class SwordController : MonoBehaviour {
        [SerializeField] private SwordData swordData;

        private void Awake() {
            Debug.Log(swordData.Weight);
        }
    }
}