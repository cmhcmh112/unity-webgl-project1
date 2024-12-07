using System.Linq;
using UnityEditor;

public class Builder
{
    public static void BuildWebGL()
    {
        // WebGL ���� ���
        string buildPath = "builds/WebGL";

        // ���忡 ������ �� ��� ����
        string[] scenePaths = GetEnabledScenes();

        // ���� �ɼ� ����
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenePaths,
            locationPathName = buildPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        // ���� ����
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        UnityEngine.Debug.Log($"WebGL ���� �Ϸ�: {buildPath}");
    }

    private static string[] GetEnabledScenes()
    {
        // Ȱ��ȭ�� ���� ��θ� ����
        return System.Array.FindAll(EditorBuildSettings.scenes, scene => scene.enabled)
                           .Select(scene => scene.path)
                           .ToArray();
    }
}
