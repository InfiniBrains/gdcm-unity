using System.Linq;
using System.Text;
using UnityEngine;

public class gdcmExample : MonoBehaviour {

    private static StringBuilder console = new StringBuilder();
	// Use this for initialization
	void Start () {
		Log(string.Format("Plugin Version: {0} build {1}", gdcm.Version, gdcm.BuildNumber));

		Log(string.Format("GetTwo() returned: {0}", gdcm.GetTwo()));

		Log(string.Format("PassCallback() returned: {0}", gdcm.PassCallback(gdcm.Callback)));

        int[] array = { 0, 0, 0, 0, 0 };
        gdcm.FillWithOnes(array, array.Length);
        Log(string.Format("The content of array is: {0}", "[" + string.Join(",", array.Select(i => i.ToString()).ToArray()) + "]"));
   
		if (Application.platform == RuntimePlatform.WebGLPlayer) {
            Log(string.Format("Prompt() returned: {0}", gdcm.Prompt("Please enter your name", "Harry Potter")));

            Log(string.Format("Confirm() returned: {0}", gdcm.Confirm("Are you sure?")));
		}
	}
		
	public static void Log(string obj)
    {
        Debug.Log(obj);
        console.Append(obj + "\n");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), console.ToString());
    }
}
