﻿using Velen.Server.Models;

namespace Velen.Server.Services.Leveling;

public interface ILevelValueProvider
{
    public int GetLevel(VelenPlayer player);
    public void SetLevel(VelenPlayer player, int level);
}