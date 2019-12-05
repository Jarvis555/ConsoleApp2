using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class NBAPlayer
    {
        private string name;
        private string team;
        private float gamesPlayed;
        private float minutes;
        private float fieldGoalsMade;
        private float fieldGoalsAttempted;
        private float threePtsMade;
        private float threePointsAttempted;
        private float freeThrowsMade;
        private float freeThrowAttemped;
        private float turnovers;
        private float personalFouls;
        private float offensiveRebounds;
        private float defensiveRebounds;
        private float rebounds;
        private float assists;
        private float steals;
        private float blocks;
        private float points;

        public string Name { get => name; set => name = value; }
        public string Team  { get => team; set => team = value; }
        public float GamesPlayed  { get => gamesPlayed; set => gamesPlayed= value; }
        public float Minutes  { get => minutes; set => minutes= value; }
        public float FieldGoalsMade  { get => fieldGoalsMade; set => fieldGoalsMade = value; }
        public float FieldGoalsAttempted  { get => fieldGoalsAttempted; set => fieldGoalsAttempted = value; }
        public float ThreePtsMade  { get => threePtsMade; set => threePtsMade = value; }
        public float ThreePointsAttempted  { get => threePointsAttempted; set => threePointsAttempted = value; }
        public float FreeThrowsMade  { get => freeThrowsMade; set => freeThrowsMade = value; }
        public float FreeThrowAttemped  { get => freeThrowAttemped; set => freeThrowAttemped = value; }
        public float Turnovers  { get => turnovers; set => turnovers = value; }
        public float PersonalFouls  { get => personalFouls; set => personalFouls = value; }
        public float OffensiveRebounds  { get => offensiveRebounds; set => offensiveRebounds = value; }
        public float DefensiveRebounds  { get => defensiveRebounds; set => defensiveRebounds = value; }
        public float Rebounds  { get => rebounds; set => rebounds = value; }
        public float Assists  { get => assists; set => assists = value; }
        public float Steals  { get => steals; set => steals = value; }
        public float Blocks  { get => blocks; set => blocks = value; }
        public float Points  { get => points; set => points = value; }

        public NBAPlayer(string name, string team, float gamesPlayed, float minutes, 
                        float fieldGoalsMade, float fieldGoalsAttempted, float threePtsMade, 
                        float threePointsAttempted, float freeThrowsMade, float freeThrowAttemped, 
                        float turnovers, float personalFouls, float offensiveRebounds, float defensiveRebounds, 
                        float rebounds, float assists, float steals, float blocks, float points)
        {
            this.Name = name;
            this.team = team;
            this.gamesPlayed = gamesPlayed;
            this.minutes = minutes;
            this.fieldGoalsMade = fieldGoalsMade;
            this.fieldGoalsAttempted = fieldGoalsAttempted;
            this.threePtsMade = threePtsMade;
            this.threePointsAttempted = threePointsAttempted;
            this.freeThrowsMade = freeThrowsMade;
            this.freeThrowAttemped = freeThrowAttemped;
            this.turnovers = turnovers;
            this.personalFouls = personalFouls;
            this.offensiveRebounds = offensiveRebounds;
            this.defensiveRebounds = defensiveRebounds;
            this.rebounds = rebounds;
            this.assists = assists;
            this.steals = steals;
            this.blocks = blocks;
            this.points = points;
        }
    }
}
