
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacle;

    public float height;

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(obstacle,new Vector3(5,obstacle.gameObject.transform.position.y+Random.Range(-height,height),-1.5f),Quaternion.identity);
           

            time = 0;

            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }
}
