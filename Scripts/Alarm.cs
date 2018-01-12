using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public enum AlarmType {post, information}
public class Alarm
{

    public AlarmType type;
    public string text;

    public Alarm(AlarmType type, string text)
    {
        this.type = type;
        this.text = text;
    }
    
    public string GetText()
    {
        return text;
    }
}
