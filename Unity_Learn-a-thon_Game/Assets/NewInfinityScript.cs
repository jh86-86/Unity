using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInfinityScript : MonoBehaviour
{
    public float speed = 3f;

    public float countDown = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        //Debug.Log(countDown);





        if (countDown > 2.0)
        {
            transform.Translate(0, -speed * Time.deltaTime, speed * Time.deltaTime);
        }
        else if (countDown <= 2.0 && countDown > 0)
        {
            transform.Translate(0, speed * Time.deltaTime, -speed * Time.deltaTime);

        }
        else if (countDown < 0)
        {
            countDown = 4;
        }
    }


}
