using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class TextToSpeech
{
	public static void SpeakText(string s)
	{
		string file = "/Users/josephditton/Desktop/text.txt";
		File.WriteAllText(file, s);
		Process p = new Process();
		p.StartInfo.UseShellExecute = false;
		p.StartInfo.RedirectStandardInput = true;
		p.StartInfo.RedirectStandardOutput = true;
		p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
		p.StartInfo.FileName ="open";
		p.StartInfo.Arguments = "Talk.command";
		p.StartInfo.WorkingDirectory="/Users/josephditton/Desktop";
		p.StartInfo.CreateNoWindow = false;
		p.Start();
	}
}
