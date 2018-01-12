using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User
{
    private int id;
    private string name;
    private float connected;
    private User[] connectors;
    private Post[] posts;
    private Image profileImage;
}