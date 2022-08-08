using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f35 : MonoBehaviour
{
    string heroName = "alex";
    int heroPower = 80;
    string villainName = "toom";
    int villainPower = 90;
    float playerspeed = 4.5f;
    float playerspeed2 = 0f; 



    void setspeed(float speed)
    {
        playerspeed = speed; 
    }
        




    // Start is called before the first frame update
    void Start()
    {
        if(villainPower > heroPower)
        {
            print(villainPower);
        }
        else if(villainPower == heroPower)
        {
            print(villainPower + "=" + heroPower);
        }
        else
        {
            print(villainPower);
        }
        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);
        CompareSpeed();





        void CompareSpeed()
        {
            if(playerspeed > playerspeed2)
            {
                print(playerspeed);
            }
            else if (playerspeed == playerspeed2)
            {
                print(playerspeed + "=" + playerspeed2);
            }
            else
            {
                print(playerspeed);
            }
                

        }

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
