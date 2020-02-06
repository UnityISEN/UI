using UnityEngine;

[CreateAssetMenu(fileName = "NewSword", menuName = "Sword")]
public class SwordData : ScriptableObject {
    [SerializeField] private float weight;
    public float Weight => weight;
    [SerializeField] private Color color;
    [SerializeField] private float damage;
}