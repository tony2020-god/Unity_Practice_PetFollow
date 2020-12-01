using UnityEngine;

public class Pet : MonoBehaviour
{
    [Header("目標")]
    public Transform target;
    [Header("追蹤速度"), Range(0, 100)]
    public float speed = 1.5f;
 

    private void Track()
    {
        Vector3 posA = transform.position;    //取得攝像機座標
        Vector3 posB = target.position;       //取得目標座標
        
        //一禎的時間 Time.deltaTime
        posA = Vector3.Lerp(posA, posB, speed * Time.deltaTime);//插值

        transform.position = posA;            //攝影機座標 = A點
    }
    private void LateUpdate()
    {
        Track();
    }
}
