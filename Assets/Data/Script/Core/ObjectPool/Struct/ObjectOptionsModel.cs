using UnityEngine;

namespace Data.Script.Core
{
    public struct ObjectOptionsModel
    {
        private Vector3 position;
        private Quaternion rotation;
        private Vector3 scale;

        public Vector3 Position { get => position; }
        public Quaternion Rotation { get => rotation; }
        public Vector3 Scale { get => scale; }

        public ObjectOptionsModel(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }
    }
}
