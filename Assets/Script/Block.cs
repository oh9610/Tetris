using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public bool c_d = true;
    //��������� �ƴ��� ����; create_delete

    public bool b_c = true;
    //block_control ���� ����

    public GameObject block;


    void Start()
    {
    }

    void Update()
    {
        if(c_d == true)
        {
            if (b_c == true)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    StartCoroutine(time_control());
                    move_R();
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    StartCoroutine(time_control());
                    move_L();
                }
            }
        }
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            c_d = false;
        }
    }



    void move_R()
    {
        block.transform.position = new Vector2(block.transform.position.x + 0.5f, block.transform.position.y);
    }
    void move_L()
    {
        block.transform.position = new Vector2(block.transform.position.x - 0.5f, block.transform.position.y);
    }



    IEnumerator time_control()
    {
        b_c = false;
        yield return new WaitForSeconds(0.1f);
        b_c = true;
    }
}

