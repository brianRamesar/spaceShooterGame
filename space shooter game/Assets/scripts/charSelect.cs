using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class charSelect : MonoBehaviour
{
    public GameObject falconRocket;
    public GameObject guitarRocket;

    private Vector3 activeCharPos;
    private Vector3 offScreenPos;

    public int charInt = 1;

    private SpriteRenderer falconRocketRender, guitarRender;

    public void Awake()
    {
        activeCharPos = falconRocket.transform.position;
        offScreenPos = guitarRocket.transform.position;

        falconRocketRender = falconRocket.GetComponent<SpriteRenderer>();
        guitarRender = guitarRocket.GetComponent<SpriteRenderer>();

    }

    public void nextChar()
    {
        switch (charInt)
        {
            case 1:

                falconRocketRender.enabled = false;
                falconRocket.transform.position = offScreenPos;

                guitarRocket.transform.position = activeCharPos;
                guitarRender.enabled = true;

                charInt++;
                break;

            case 2:
               
                guitarRender.enabled = false;
                guitarRocket.transform.position = offScreenPos;

                falconRocket.transform.position = activeCharPos;
                falconRocketRender.enabled = true;


                charIntReset();
                break;
            default:
                charIntReset();
                break;
        }
    }

    public void prevChar()
    {
        switch (charInt)
        {
            case 1:
               
                guitarRender.enabled = false;
                guitarRocket.transform.position = offScreenPos;

                falconRocket.transform.position = activeCharPos;
                falconRocketRender.enabled = true;

                charIntReset();
                break;
            case 2:
               
                falconRocketRender.enabled = false;
                falconRocket.transform.position = offScreenPos;

                guitarRocket.transform.position = activeCharPos;
                guitarRender.enabled = true;

                charInt--;
                break;
            default:
                charIntReset();
                break;
        }
    }

    private void charIntReset()
    {
        if (charInt >=2)
        {
            charInt = 1;
        }
        else
        {
            charInt = 2;
        }
    }

    void charSpawn()
    {
        if(charInt == 1)
        {
            GetComponent<spawnPlayer>().spawnChar();
           
        }
    }

    public void changeScene()
    {
        SceneManager.LoadScene("gameScreen");
        Debug.Log("clicked");
    }

}
