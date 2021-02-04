using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TestUnityEvents : MonoBehaviour
{
    public void TestMethod1(string message)
    {
        Debug.Log(message);
    }

    public void TestMethod2(int[] numbers)
    {
        var nums = 0;
        foreach (var num in numbers)
        {
            nums += num;
        }

        Debug.Log(nums);
    }
}
