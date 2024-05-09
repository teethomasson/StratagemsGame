using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

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
    public string ImagePath{ get; set; } = string.Empty;
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
                    Name = "Reinforce",
                    Keys = new List<int> {38, 40, 39, 37, 38},
                    ImagePath = @"/img/icons/general stratagems/Reinforce.svg"
                },
                new CodeSequence
                {
                    Name = "Resupply",
                    Keys = new List<int> {40, 40, 38, 39},
                    ImagePath = @"/img/icons/general stratagems/Resupply.svg"
                },
                new CodeSequence
                {
                    Name = "SOS Beacon",
                    Keys = new List<int> {38, 40, 39, 38},
                    ImagePath = @"/img/icons/general stratagems/SOS Beacon.svg"
                },
                new CodeSequence
                {
                    Name = "SEAF Artillery",
                    Keys = new List<int> {39, 38, 38, 40},
                    ImagePath = @"/img/icons/general stratagems/SEAF Artillery.svg"
                },
                new CodeSequence
                {
                    Name ="Hellbomb",
                    Keys = new List<int> {40, 38, 37, 40, 38, 39, 40, 38},
                    ImagePath = @"/img/icons/general stratagems/Hellbomb.svg"
                },
                new CodeSequence
                {
                    Name ="Super Earth Flag",
                    Keys = new List<int> {40, 38, 40, 38},
                    ImagePath = @"/img/icons/general stratagems/Super Earth Flag.svg"
                },
                new CodeSequence
                {
                    Name = "Upload Data",
                    Keys = new List<int> {37, 38, 39, 39, 39},
                    ImagePath = @"/img/icons/general stratagems/Upload Data.svg"
                },
                new CodeSequence
                {
                    Name = "Global Illumination Flare",
                    Keys = new List<int> {38, 38, 37, 37},
                    ImagePath = @"/img/icons/general stratagems/Orbital Illumination Flare.svg"
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
                    Name = "MG-43 Machine Gun",
                    Keys = new List<int> {40, 37, 40, 38, 39},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Machine Gun.svg"
                },
                new CodeSequence
                {
                    Name = "APW-1 Anti-Materiel Rifle",
                    Keys = new List<int> {40, 37, 39, 38, 39},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Anti-Materiel Rifle.svg"
                },
                new CodeSequence
                {
                    Name = "M-105 Stalwart",
                    Keys = new List<int> {40, 37, 40, 38, 38, 37},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Stalwart.svg"
                },
                new CodeSequence
                {
                    Name = "EAT-17 Expendable Anti-tank",
                    Keys = new List<int> {40, 40, 37, 38, 39},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Expendable Anti-Tank.svg"
                },
                new CodeSequence
                {
                    Name = "GR-8 Recoilless Rifle",
                    Keys = new List<int> {40, 37, 39, 39, 37},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Recoilless Rifle.svg"
                },
                new CodeSequence
                {
                    Name = "FLAM-40 Flamethrower",
                    Keys = new List<int> {40, 37, 38, 40, 38},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Flamethrower.svg"
                },
                new CodeSequence
                {
                    Name = "AC-8 Autocannon",
                    Keys = new List<int> {40, 37, 40, 38, 38, 39},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Autocannon.svg"
                },
                new CodeSequence
                {
                    Name = "RS-422 Railgun",
                    Keys = new List<int> {40, 39, 40, 38, 37, 39},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Railgun.svg"
                },
                new CodeSequence
                {
                    Name = "FAF-14 SPEAR Launcher",
                    Keys = new List<int> {40, 40, 38, 40, 40},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Spear.svg"
                },
                new CodeSequence
                {
                    Name = "MG-206 Heavy Machine Gun",
                    Keys = new List<int> {40, 37, 39, 40, 40},
                    ImagePath = @"/img/icons/Patriotic Administration Center/Heavy Machine Gun.svg"
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
                    Keys = new List<int> {39, 40, 37, 38, 38},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital Gatling Barrage.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital Airburst Strike",
                    Keys = new List<int> {39, 39, 39},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital Airburst Strike.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital 120MM HE Barrage",
                    Keys = new List<int> {39, 39, 40, 37, 39, 40},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital 120MM HE Barrage.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital 380MM HE Barrage",
                    Keys = new List<int> {39, 40, 38, 38, 37, 40, 40},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital 380MM HE Barrage.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital Walking Barrage",
                    Keys = new List<int> {39, 40, 39, 40, 39, 40},
                    ImagePath= @"/img/icons/Orbital Cannons/Orbital Walking Barrage.svg"
                },
                new CodeSequence
                {
                    Name = "Orital Laser",
                    Keys = new List<int> {39, 40, 38, 39, 40},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital Laser.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital Railcannon Strike",
                    Keys = new List<int> {39, 38, 40, 40, 39},
                    ImagePath = @"/img/icons/Orbital Cannons/Orbital Railcannon Strike.svg"
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
                    Keys = new List<int> {39, 39, 38},
                    ImagePath = @"/img/icons/Bridge/Orbital Precision Strike.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital Gas Strike",
                    Keys = new List<int> {39, 39, 40, 39},
                    ImagePath = @"/img/icons/Bridge/Orbital Gas Strike.svg"
                },
                new CodeSequence
                {
                    Name ="Orbital EMS Strike",
                    Keys = new List<int> {39, 39, 37, 40},
                    ImagePath = @"/img/icons/Bridge/Orbital EMS Strike.svg"
                },
                new CodeSequence
                {
                    Name = "Orbital Smoke Strike",
                    Keys = new List<int> {39, 39, 40, 38},
                    ImagePath = @"/img/icons/Bridge/Orbital Smoke Strike.svg"
                },
                new CodeSequence
                {
                    Name = "HMG Emplacement",
                    Keys = new List<int> {40, 38, 37, 39, 39, 37},
                    ImagePath = @"/img/icons/Bridge/HMG Emplacement.svg"
                },
                new CodeSequence
                {
                    Name = "Shield Generator",
                    Keys = new List<int> {40, 40, 37, 39, 37, 39},
                    ImagePath = @"/img/icons/Bridge/Shield Generator Relay.svg"
                },
                new CodeSequence
                {
                    Name = "Tesla Tower",
                    Keys = new List<int> { 40, 38, 39, 38, 37, 39, 39, 40, 37, 38, 37},
                    ImagePath = @"/img/icons/Bridge/Tesla Tower.svg"
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
                    Keys = new List<int> { 38, 39, 39},
                    ImagePath = @"/img/icons/Hangar/Eagle Strafing Run.svg"
                },
                new CodeSequence
                {
                    Name ="Eagle Airstrike",
                    Keys = new List<int> {38, 39, 40, 39},
                    ImagePath = @"/img/icons/Hangar/Eagle Airstrike.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle Cluster Bomb",
                    Keys = new List<int> {38, 39, 40, 40, 39},
                    ImagePath = @"/img/icons/Hangar/Eagle Cluster Bomb.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle Napalm Airstrike",
                    Keys = new List<int> {38, 39, 40, 37},
                    ImagePath = @"/img/icons/Hangar/Eagle Napalm Airstrike.svg"
                },
                new CodeSequence
                {
                    Name = "Jump Pack",
                    Keys = new List<int> {40, 38, 38, 40, 38},
                    ImagePath = @"/img/icons/Hangar/Jump Pack.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle Smoke Strike",
                    Keys = new List<int> { 38, 39, 40, 38},
                    ImagePath = @"/img/icons/Hangar/Eagle Smoke Strike.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle 110MM Rocket Pods",
                    Keys = new List<int> { 38, 39, 38, 37},
                    ImagePath = @"/img/icons/Hangar/Eagle 110MM Rocket Pods.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle 500KG Bomb",
                    Keys = new List<int> {38, 39, 40, 40, 40},
                    ImagePath = @"/img/icons/Hangar/Eagle 500KG Bomb.svg"
                },
                new CodeSequence
                {
                    Name = "Eagle Rearm",
                    Keys = new List<int> {38, 38, 37, 38, 39},
                    ImagePath = @"/img/icons/Hangar/Eagle Rearm.svg"
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
                    Keys = new List<int> {40, 37, 38, 39},
                    ImagePath = @"/img/icons/Engineering Bay/Anti-Personnel Minefield.svg"
                },
                new CodeSequence
                {
                    Name = "Supply Pack",
                    Keys = new List<int> {40, 37, 40, 38, 38, 40},
                    ImagePath = @"/img/icons/Engineering Bay/Supply Pack.svg"
                },
                new CodeSequence
                {
                    Name = "Grenade Launcher",
                    Keys = new List<int> {40, 37, 38, 37, 40},
                    ImagePath = @"/img/icons/Engineering Bay/Grenade Launcher.svg"
                },
                new CodeSequence
                {
                    Name = "Laser Cannon",
                    Keys = new List<int> {40, 37, 40, 38, 37},
                    ImagePath = @"/img/icons/Engineering Bay/Laser Cannon.svg"
                },
                new CodeSequence
                {
                    Name = "Incendiary Mines",
                    Keys = new List<int> {40, 37, 37, 40},
                    ImagePath = @"/img/icons/Engineering Bay/Incendiary Mines.svg"
                },
                new CodeSequence
                {
                    Name = "Guard Dog Rover",
                    Keys = new List<int> {38, 40, 37, 38, 39, 39},
                    ImagePath = @"/img/icons/Engineering Bay/Guard Dog Rover.svg"
                },
                new CodeSequence
                {
                    Name = "Ballistic Shield",
                    Keys =new List<int> {40, 37, 40, 40, 38, 37},
                    ImagePath = @"/img/icons/Engineering Bay/Ballistic Shield Backpack.svg"
                },
                new CodeSequence
                {
                    Name = "Arc Thrower",
                    Keys = new List<int> {40, 39, 40, 38, 37, 37},
                    ImagePath = @"/img/icons/Engineering Bay/Arc Thrower.svg"
                },
                new CodeSequence
                {
                    Name = "Shield Generator Pack",
                    Keys = new List<int> {40, 38, 37, 39, 37, 39},
                    ImagePath = @"/img/icons/Engineering Bay/Shield Generator Pack.svg"
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
                    Keys = new List<int> {40, 38, 39, 39, 38},
                    ImagePath = @"/img/icons/Robotics Workshop/Machine Gun Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "Gatling Sentry",
                    Keys = new List<int> {40, 38, 39, 37},
                    ImagePath = @"/img/icons/Robotics Workshop/Gatling Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "Mortar Sentry",
                    Keys = new List<int> {40, 38, 39, 39, 40},
                    ImagePath = @"/img/icons/Robotics Workshop/Mortar Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "Guard Dog",
                    Keys =new List<int> {40, 38, 39, 38, 39, 40},
                    ImagePath = @"/img/icons/Robotics Workshop/Guard Dog.svg"
                },
                new CodeSequence
                {
                    Name = "Autocannon Sentry",
                    Keys = new List<int> {40, 38, 39, 38, 37, 38},
                    ImagePath = @"/img/icons/Robotics Workshop/Autocannon Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "Rocket Sentry",
                    Keys = new List<int> { 40, 38, 39, 39, 37},
                    ImagePath = @"/img/icons/Robotics Workshop/Rocket Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "EMS Mortar Sentry",
                    Keys = new List<int> {40, 38, 39, 40, 39},
                    ImagePath = @"/img/icons/Robotics Workshop/EMS Mortar Sentry.svg"
                },
                new CodeSequence
                {
                    Name = "Patriot EXOSuit",
                    Keys = new List<int> {37, 40, 38, 39, 37, 40, 40},
                    ImagePath = @"/img/icons/Robotics Workshop/Patriot Exosuit.svg"
                }
            }
        
        }
    };

}




