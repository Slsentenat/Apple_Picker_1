using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject ApplePrefab;
    public GameObject BadApplePrefab;
    public float speed = 1f;
    public float leftandrightedge = 10f;
    public float changedirchance = 0.1f;
    public float appledropdelay = 1f;
    public float badapplechance = 0.3f;

   
    void Start()
    {
        Invoke("dropapple", 2f);
    }

    void dropapple()
    {
        if (Random.value > badapplechance)
        {
            GameObject apple = Instantiate<GameObject>(ApplePrefab);
            apple.transform.position = transform.position;
            Invoke("dropapple", appledropdelay);
        }
        else if (Random.value < badapplechance)
        {
            GameObject badapple = Instantiate<GameObject>(BadApplePrefab);
            badapple.transform.position = transform.position;
        }
  
    }

    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftandrightedge) { speed = Mathf.Abs(speed); }
        else if (pos.x > leftandrightedge)
        {
            speed = -Mathf.Abs(speed);
            // } else if ( Random.value < changedirchance ) { speed *= -1;
        }
    }
    void FixedUpdate() {
        if (Random.value < changedirchance) { speed *= -1; }
    }
}