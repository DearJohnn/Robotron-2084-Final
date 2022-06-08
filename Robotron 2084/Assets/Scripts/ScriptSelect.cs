using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSelect : MonoBehaviour
{
    float changeTimer;//�趨һ����ʱ����ÿ��һ��ʱ�䣬�����˻�һ�������˶�
    public float changeTime = 10f;//��ʱ������
    private bool status = true;
    // Start is called before the first frame update
    void Start()
    {
        change();
    }

    // Update is called once per frame
    void Update()
    {
        changeTimer -= Time.deltaTime;//��ʱ��ÿһ֡����С
        if (changeTimer < 0)
        {
            change();
            changeTimer = changeTime;//�ı䷽����ʱ�����³�ʼ��
        }
    }

    public void change()
    {
        if (status == true)
        {
            GameObject.Find("Robot/Robot").GetComponent<AIPath>().enabled = true;
            GameObject.Find("Robot/Robot").GetComponent<RobotControl>().enabled = false;
            status = false;
            return;
        }
        if (status == false)
        {
            GameObject.Find("Robot/Robot").GetComponent<AIPath>().enabled = false;
            GameObject.Find("Robot/Robot").GetComponent<RobotControl>().enabled = true;
            status = true;
            return;
        }
    }
}
