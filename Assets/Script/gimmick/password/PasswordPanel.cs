using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PasswordPanel : MonoBehaviour
{
    //正解と一致しているか管理
    //正解の数字
    private GameObject next_door;
    private GameObject clearText;
    public int[] correctAnswer = {3,8,1,6};
    bool namber_ON;

    [SerializeField] DialNumber[] dialNumbers = default;
    void Start()
    {
        next_door = GameObject.Find("door");
        clearText = GameObject.Find("commentPanel");

        next_door.SetActive(false);
        clearText.SetActive(false);

        namber_ON = false;
    }

    private void Update()
    {
        //Answer();
    }

    public void OnClickButton()
    {
        //ダイヤルの数値と正解の番号が一致した場合、次の扉が出る
        //for (int i = 0; i < correctAnswer.Length; i++)
        //{
            //if (dialNumbers[i].number.Equals(correctAnswer))
            if(dialNumbers[0].number == correctAnswer[0]
            && dialNumbers[1].number == correctAnswer[1]
            && dialNumbers[2].number == correctAnswer[2]
            && dialNumbers[3].number == correctAnswer[3])
            {
                //Debug.Log("くりあ");
                //namber_ON = true;
                next_door.SetActive(true);
                clearText.SetActive(true);
            }
        //}
    }
    void Answer()
    {
        if(namber_ON)
        {
            next_door.SetActive(true);
            clearText.SetActive(true);
        }
    }
}
