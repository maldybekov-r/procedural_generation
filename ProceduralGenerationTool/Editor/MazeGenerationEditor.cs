using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ProceduralMazeManager))]
public class MazeGenerationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ProceduralMazeManager mazeGeneration = (ProceduralMazeManager)target;
        
        if(DrawDefaultInspector())
            if(mazeGeneration.AutoGenerated)
                mazeGeneration.OnGenerateMaze();

        if (GUILayout.Button("Generate Maze"))
            mazeGeneration.OnGenerateMaze();
        else if(GUILayout.Button("Clear Maze"))
            mazeGeneration.OnClenMaze();
    }
}
