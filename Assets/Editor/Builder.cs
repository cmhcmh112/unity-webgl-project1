using System.Linq;
using UnityEditor;

public class Builder
{
    public static void BuildWebGL()
    {
        // WebGL 빌드 경로
        string buildPath = "builds/WebGL";

        // 빌드에 포함할 씬 경로 추출
        string[] scenePaths = GetEnabledScenes();

        // 빌드 옵션 설정
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenePaths,
            locationPathName = buildPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        // 빌드 실행
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        UnityEngine.Debug.Log($"WebGL 빌드 완료: {buildPath}");
    }

    private static string[] GetEnabledScenes()
    {
        // 활성화된 씬의 경로만 추출
        return System.Array.FindAll(EditorBuildSettings.scenes, scene => scene.enabled)
                           .Select(scene => scene.path)
                           .ToArray();
    }
}
