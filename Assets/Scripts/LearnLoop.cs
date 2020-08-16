using UnityEngine;

public class LearnLoop : MonoBehaviour
{

    public Transform cude;
    private int i = 1;
    private void Start()
    {
        while (i < 6)
        {
            print("我是迴圈" +i);
            i++;
        }

        for (int i = 1; i < 6; i++)
        {
            print("我是迴圈FOR" +i);
        }

        for (int i = 0; i < 10; i++)
        {
            Vector3 pos = new Vector3(i, 0, 0);
            Instantiate(cude, pos, Quaternion.identity);
        }
    }
}
