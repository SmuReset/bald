using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Transform target;
    public float speed;
    public GameObject PauseUI;
    public GameObject Music;

    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(target.position.x > transform.position.x)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
            transform.position = new Vector3(transform.position.x, 10.8f, -10f);
        }
        if (target.position.x < transform.position.x)
        {

            if (target.position.x - transform.position.x < -45)
            {
                Debug.Log("destroy");
                Destroy(Music);
                PauseUI.SetActive(true);
                Time.timeScale = 0;
            }
        }
        if (target.position.y < transform.position.y)
        {

            if (target.position.y - transform.position.y < -40)
            {
                Debug.Log("destroy");
                Destroy(Music);
                PauseUI.SetActive(true);
                Time.timeScale = 0;
            }
        }



    }
}
