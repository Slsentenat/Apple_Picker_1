using JetBrains.Annotations;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("inscribed")]
    public GameObject basketprefab;
    public int numbaskets = 3;
    public float basketbottomY = -14f;
    public float basketspacingY = 2f;

    void Start() {
        for (int i = 0; i < numbaskets; i++) {
            GameObject tbasketsGO = Instantiate<GameObject>(basketprefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketbottomY + (basketspacingY * i);
            tbasketsGO.transform.position = pos;
        }
    }
        public void AppleMissed() {
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tempGO in appleArray) {
            Destroy(tempGO);
        }
    }
}