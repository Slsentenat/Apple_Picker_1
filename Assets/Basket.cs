using UnityEngine;

public class Basket : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        Vector3 mousepos2D = Input.mousePosition;
        mousepos2D.z = -Camera.main.transform.position.z;
        Vector3 mousepos3D = Camera.main.ScreenToWorldPoint(mousepos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousepos3D.x;
        this.transform.position = pos;
    }
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidewith = coll.gameObject;
        if (collidewith.CompareTag("Apple"))
        {
            Destroy(collidewith);
        }
    }
}
