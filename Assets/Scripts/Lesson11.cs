using UnityEngine;
using System.Collections.Generic;
public class Lesson11 : MonoBehaviour
{
    public int[] MonsterHps = { 0, 35, 0, 80, 12 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ContextMenu("foreach 실습")]
    void countalive()
    {
        int CountAlive = 0;
        int hpsum = 0;
        foreach (int hp in MonsterHps)
        {
            if (hp > 0)
            {
                CountAlive++;
                hpsum += hp;
            }
        }
        Debug.Log("살아 있는 몬스터" + CountAlive + "마리");
        Debug.Log("남아 있는 채력" + hpsum);

    }







}
