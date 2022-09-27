using System.ComponentModel.DataAnnotations;

namespace AddTrainerApi
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }

        [EmailAddress]
        public string TrainerEmail { get; set; }

        [Phone]
        public string TrainerPhone { get; set; }

        public int SkillCode { get; set; }
    }
}
