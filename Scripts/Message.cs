using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Message
{
    private int texterId;
    private string text;
    private Time sendedAt;

    public int GetTexterId()
    {
        return texterId;
    }
    
    public string GetText()
    {
        return text;
    }
    public Time SendedAt()
    {
        return sendedAt;
    }
    
}