using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataController
{
	private string gemeDataFileName = "data.json";

	private void LoadGameData()
	{
		string filePath = Path.Combine (Application.dataPath, "/Connect/Data");
		
		if (File.Exists(filePath))
		{
			string dataAsJson = File.ReadAllText(filePath);
		}
	}
	
}
