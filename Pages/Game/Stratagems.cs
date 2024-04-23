namespace StratagemsGame;

public class CodeCategory 
{
    public string Name {get; set;} = string.Empty;
    public List<CodeSequence>? Sequences { get; set; } 
}

public class CodeSequence
{
    public string Name { get; set; } = string.Empty;
    public List<int>? Keys { get; set; }
}

public class Stratagems
{
    public List<CodeCategory> getCodeList(){
        return codeList;
    }
   public List<CodeCategory> codeList = new List<CodeCategory>
    {
        new CodeCategory
        {
            Name = "General",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Reinforcement",
                    Keys = new List<int> {38, 40, 39, 37, 38}
                },
                new CodeSequence
                {
                    Name = "Resupply",
                    Keys = new List<int> {40, 40, 38, 39}
                },
                new CodeSequence
                {
                    Name = "SOS",
                    Keys = new List<int> {38, 40, 39, 38}
                },
                new CodeSequence
                {
                    Name = "SEAF Artillery",
                    Keys = new List<int> {39, 38, 38, 40}
                },
                new CodeSequence
                {
                    Name ="Hellbomb",
                    Keys = new List<int> {40, 38, 37, 40, 38, 39, 40, 38}
                },
                new CodeSequence
                {
                    Name ="Super Earth Flag",
                    Keys = new List<int> {40, 38, 40, 38}
                }
            }
        },
        new CodeCategory
        {
            Name = "Patriotic Administration Center",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Machine Gun",
                    Keys = new List<int> {40, 37, 40, 38, 39}
                },
                new CodeSequence
                {
                    Name = "Anti-Material",
                    Keys = new List<int> {40, 37, 39, 38, 39}
                },
                new CodeSequence
                {
                    Name = "Stalward",
                    Keys = new List<int> {40, 37, 40, 38, 38, 37}
                },
                new CodeSequence
                {
                    Name = "Expendable Anti-Tank",
                    Keys = new List<int> {40, 40, 37, 38, 39}
                },
                new CodeSequence
                {
                    Name = "Recoiless Rifle",
                    Keys = new List<int> {40, 37, 39, 39, 37}
                },
                new CodeSequence
                {
                    Name = "Flamethrower",
                    Keys = new List<int> {40, 37, 38, 40, 38}
                },
                new CodeSequence
                {
                    Name = "Auto-Cannon",
                    Keys = new List<int> {40, 37, 40, 38, 38, 39}
                },
                new CodeSequence
                {
                    Name = "Railgun",
                    Keys = new List<int> {40, 39, 40, 38, 37, 39}
                },
                new CodeSequence
                {
                    Name = "Spear",
                    Keys = new List<int> {40, 40, 38, 40, 40}
                }
            }
        },
        new CodeCategory
        {

            Name = "Orbital Cannons",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Orbital Gatling Barrage",
                    Keys = new List<int> {39, 40, 37, 38, 38}
                },
                new CodeSequence
                {
                    Name = "Orbital Airburst Strike",
                    Keys = new List<int> {39, 39, 39}
                },
                new CodeSequence
                {
                    Name = "Orbital 120MM HE Barrage",
                    Keys = new List<int> {39, 39, 40, 37, 39, 40}
                },
                new CodeSequence
                {
                    Name = "Orbital 380MM HE Barrage",
                    Keys = new List<int> {39, 40, 38, 38, 37, 40, 40}
                },
                new CodeSequence
                {
                    Name = "Orbital Walking Barrage",
                    Keys = new List<int> {39, 40, 39, 40, 39, 40}
                },
                new CodeSequence
                {
                    Name = "Orital Laser",
                    Keys = new List<int> {39, 40, 38, 39, 40}
                },
                new CodeSequence
                {
                    Name = "Orbital Railgun Strike",
                    Keys = new List<int> {39, 38, 40, 40, 39}
                }
            }
            
        },
        new CodeCategory
        {
            Name = "Bridge",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Orbital Precision Strike",
                    Keys = new List<int> {39, 39, 38}
                },
                new CodeSequence
                {
                    Name = "Orbital Gas Strike",
                    Keys = new List<int> {39, 39, 40, 39}
                },
                new CodeSequence
                {
                    Name ="Orbital EMS Strike",
                    Keys = new List<int> {39, 39, 37, 40}
                },
                new CodeSequence
                {
                    Name = "Orbital Smoke Strike",
                    Keys = new List<int> {39, 39, 40, 38}
                },
                new CodeSequence
                {
                    Name = "HMG Placement",
                    Keys = new List<int> {40, 38, 37, 39, 39, 37}
                },
                new CodeSequence
                {
                    Name = "Shield Generator",
                    Keys = new List<int> {40, 40, 37, 39, 37, 39}
                },
                new CodeSequence
                {
                    Name = "Tesla Tower",
                    Keys = new List<int> { 40, 38, 39, 38, 37, 39, 39, 40, 37, 38, 37}
                }
            }
        },
        new CodeCategory
        {
            Name ="Hangar",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Eagle Straffing Run",
                    Keys = new List<int> { 38, 39, 39}
                },
                new CodeSequence
                {
                    Name ="Eagle Airstrike",
                    Keys = new List<int> {38, 39, 40, 39}
                },
                new CodeSequence
                {
                    Name = "Eagle Cluster Bomb",
                    Keys = new List<int> {38, 39, 40, 40, 39}
                },
                new CodeSequence
                {
                    Name = "Eagle Napalm Strike",
                    Keys = new List<int> {38, 39, 40, 37}
                },
                new CodeSequence
                {
                    Name = "Jump Pack",
                    Keys = new List<int> {40, 38, 38, 40, 38}
                },
                new CodeSequence
                {
                    Name = "Eagle Smoke Strike",
                    Keys = new List<int> { 38, 39, 40, 38}
                },
                new CodeSequence
                {
                    Name = "Eagle 110MM Rocket Pods",
                    Keys = new List<int> { 38, 39, 38, 37}
                },
                new CodeSequence
                {
                    Name = "Eagle 500KG Bomb",
                    Keys = new List<int> {38, 39, 40, 40, 40} 
                },
                new CodeSequence
                {
                    Name = "Eagle Rearm",
                    Keys = new List<int> {38, 38, 37, 38, 39}
                }
            }
        },
        new CodeCategory
        {
            Name = "Engineering Bay",
            Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name = "Anti-Personnel Minefield",
                    Keys = new List<int> {40, 37, 38, 39}
                },
                new CodeSequence
                {
                    Name = "Supply Pack",
                    Keys = new List<int> {40, 37, 40, 38, 38, 40}
                },
                new CodeSequence
                {
                    Name = "Grenade Launcher",
                    Keys = new List<int> {40, 37, 38, 37, 40}
                },
                new CodeSequence
                {
                    Name = "Laser Canon",
                    Keys = new List<int> {40, 37, 40, 38, 37}
                },
                new CodeSequence
                {
                    Name = "Incendiary Mines",
                    Keys = new List<int> {40, 37, 37, 40}
                },
                new CodeSequence
                {
                    Name = "Guard Dog Rover",
                    Keys = new List<int> {38, 40, 37, 38, 39, 39}
                },
                new CodeSequence
                {
                    Name = "Ballistic Shield",
                    Keys =new List<int> {40, 37, 40, 40, 38, 37}
                },
                new CodeSequence
                {
                    Name = "Arc Thrower",
                    Keys = new List<int> {40, 39, 40, 38, 37, 37}
                },
                new CodeSequence
                {
                    Name = "Shield Generator Pack",
                    Keys = new List<int> {40, 38, 37, 39, 37, 39}
                }
            }
        },
        new CodeCategory
        {
            Name = "Robotic Workshop",
        Sequences = new List<CodeSequence>
            {
                new CodeSequence
                {
                    Name ="Machine Gun Sentry",
                    Keys = new List<int> {40, 38, 39, 39, 38}
                },
                new CodeSequence
                {
                    Name = "Gatling Sentry",
                    Keys = new List<int> {40, 38, 39, 37}
                },
                new CodeSequence
                {
                    Name = "Mortar Sentry",
                    Keys = new List<int> {40, 38, 39, 39, 40}
                },
                new CodeSequence
                {
                    Name = "Guard Dog",
                    Keys =new List<int> {40, 38, 39, 38, 39, 40}
                },
                new CodeSequence
                {
                    Name = "Autocanon Sentry",
                    Keys = new List<int> {40, 38, 39, 38, 37, 38}
                },
                new CodeSequence
                {
                    Name = "Rocket Sentry",
                    Keys = new List<int> { 40, 38, 39, 39, 37}
                },
                new CodeSequence
                {
                    Name = "EMS Mortar Sentry",
                    Keys = new List<int> {40, 38, 39, 40, 39}
                }
            }
        
        }
    };

}




