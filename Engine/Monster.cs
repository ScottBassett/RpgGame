﻿using System.Collections.Generic;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int currentHitPoints, int maximumHitPoints, int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardGold)
            : base(currentHitPoints, maximumHitPoints)
        {
            Id = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();
        }
    }
}
