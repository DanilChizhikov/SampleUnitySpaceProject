namespace Data.Script.Core.Scenes
{
    public interface ISceneBuilder
    {
        bool IsReady { get; set; }

        void BuildScenes(ScenesBuilderDataPath builderDataPath);
        void DestroyBuilder();
    }
}
