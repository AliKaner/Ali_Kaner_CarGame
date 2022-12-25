
using Game.MapSystem.Base;

namespace Game.MapSystem.Components
{
    public class Wall : MapPartBase
    {
        public override MapPartType mapPartType => MapPartType.WALL;

        internal override void Initialize()
        {}
    }
}
