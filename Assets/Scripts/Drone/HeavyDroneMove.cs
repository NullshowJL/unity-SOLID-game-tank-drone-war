using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyDroneMove : DroneMoveBase, IMoveY
{
    [SerializeField] private float shiftSpeed = 2f;            // 偏移速度
    [SerializeField] private float smoothing = 5f;             // Lerp 平滑系数
    [SerializeField] private float minStraightTime = 1f;
    [SerializeField] private float maxStraightTime = 3f;
    [SerializeField] private float minShiftTime = 0.3f;
    [SerializeField] private float maxShiftTime = 0.8f;

    private float _targetShiftSpeed;

    protected override void Start()
    {
        base.Start();
        StartCoroutine(ShiftRoutine());
    }

    public void MoveY(float inputValue)
    {
        float currentShift = Mathf.Lerp(horizontalOffset, _targetShiftSpeed, Time.deltaTime * smoothing);
        horizontalOffset = currentShift;

        Vector2 direction = new Vector2(horizontalOffset, inputValue).normalized;
        moveObject.transform.Translate(direction * speed * Time.deltaTime);
    }

    private float horizontalOffset;

    private IEnumerator ShiftRoutine()
    {
        while (true)
        {
            // 直飞阶段
            _targetShiftSpeed = 0f;
            yield return new WaitForSeconds(Random.Range(minStraightTime, maxStraightTime));

            // 随机向上或向下偏移
            _targetShiftSpeed = Random.value > 0.5f ? shiftSpeed : -shiftSpeed;

            // 保持偏移一段时间
            yield return new WaitForSeconds(Random.Range(minShiftTime, maxShiftTime));

            // 回到直飞
            _targetShiftSpeed = 0f;
        }
    }
}
