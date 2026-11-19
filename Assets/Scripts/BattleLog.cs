using UnityEngine;
using System.Collections.Generic;
public class BattleLog : MonoBehaviour
{

    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        List<int> criticals = new List<int>();

        int total = 0;
        int MaxDamge = 0;
        int maxindex = -1;

        int steak = 0;
        int maxsteak = 0;

        for (int i = 0; i < damages.Length; i++)
        {
            int d = damages[i];
            total += d;

            if (d >= criticalLine)
            {
                criticals.Add(i);
                steak++;
                if (steak >= maxsteak) maxsteak = steak;
            }
            else
            {
                steak = 0;
            }

            if (steak == -1 || d > MaxDamge)
            {
                MaxDamge = d;
                maxindex = i;
            }
        }
    }
}





