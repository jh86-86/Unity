using System.Threading.Tasks;
using UnityEngine;

public class InfinityLoopmovement : MonoBehaviour
{
    public float speed = 1f;

    public float countDown = 2f;

    public float reset = 1f;

    public int numberOfTimes = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        //Debug.Log(countDown);

        reset -= Time.deltaTime;

        //if(countDown<= 0.0)
        //{
        //    speed = 0.0f;
        //}     moves the box to the one side




        if (countDown > 2.0)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (countDown <= 2.0 && countDown>0)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        else if (countDown < 0)
        {
            countDown = 4;
        }
        }
        
   



    }

       

     
      
    



//using System.Threading.Tasks;

//var task = Task.Run(() => SomeMethod(input));
//if (task.Wait(TimeSpan.FromSeconds(10)))
//    return task.Result;
//else
//    throw new Exception("Timed out");