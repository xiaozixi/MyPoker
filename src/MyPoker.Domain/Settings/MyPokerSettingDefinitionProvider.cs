﻿using Volo.Abp.Settings;

namespace MyPoker.Settings;

public class MyPokerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyPokerSettings.MySetting1));
    }
}
