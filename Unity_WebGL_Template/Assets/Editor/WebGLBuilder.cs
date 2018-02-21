using UnityEditor;

public class WebGLBuilder {
    static void build()
    {
   
        // Place all your scenes here
        string[] scenes = new string[EditorBuildSettings.scenes.Length-1];      

        for (int i = 0; i < EditorBuildSettings.scenes.Length; i++)
        {
            scenes[i] = EditorBuildSettings.scenes[i].path;
        }

        string pathToDeploy = "builds/WebGLversion/";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
}
