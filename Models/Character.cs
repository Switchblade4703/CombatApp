using System.ComponentModel.DataAnnotations;

namespace CombatApp.Models
{
    public class Character
    {
        [Required]
        public int HP { get; set; } = 1;
        [Required]
        public string Name { get; set; } = "Default";
        [Required]
        public int Attack { get; set; } = 1;
        [Required]
        public int Defense { get; set; } = 1;
        [Required]
        public int SkillPoints { get; set; } = 0;
        [Required]
        public int Magic { get; set; } = 1;
        [Required]
        public int Level { get; set; } = 1;

        public int Combat(Character Enemy)
        {
            while (this.HP > 0 && Enemy.HP > 0)
            {
                //combatloop
                this.HP -= Enemy.Attack;
                Enemy.HP -= this.Attack;
            }

            if(Enemy.HP <= 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
