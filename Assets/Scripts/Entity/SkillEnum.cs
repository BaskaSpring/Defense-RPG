using System;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

[JsonConverter(typeof(StringEnumConverter))]
public enum SkillEnum { 
    Protect,
    Heal,
    Shield,
    Fireball,
    Firestorm,
    FireWall,
    FireShield,
    Iceball,
    Icestorm,
    IceWall,
    IceShield,
    Lightningball,
    Lightningstorm,
    LightningWall,
    LightningShield,
    Earthball,
    Earthstorm,
    EarthWall,
    EarthShield,
    Windball,
    Windstorm,
    WindWall,
    WindShield,
    Waterball,
    Waterstorm,
    WaterWall,
    WaterShield,
    Poisonball,
    Poisonstorm
};
