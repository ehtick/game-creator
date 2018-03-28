﻿using GameCreator.Engine.Api;
using GameCreator.Resources.Api;

namespace GameCreator.Engine
{
    public class GameSound : INamedResource
    {
        public GameContext Context { get; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ISoundEffect Effect { get; }
        
        public GameSound(GameContext context, ISoundEffect effect)
        {
            Context = context;
            Effect = effect;
        }
    }
}