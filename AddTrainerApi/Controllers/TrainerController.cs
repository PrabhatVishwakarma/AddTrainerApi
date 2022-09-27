using AddTrainerApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private static List<Trainer> Trainers = new List<Trainer>
            {
                new Trainer {
                    TrainerId = 1,
                    TrainerName = "Iron Man",
                    TrainerEmail = "fefrrgIronMan@gmail.com",
                    TrainerPhone = "1234567890",
                    SkillCode = 123,
                },
                new Trainer {
                    TrainerId = 2,
                    TrainerName = "Mihir Khendelwal",
                    TrainerEmail = "frfrvrv@gmail.com",
                    TrainerPhone = "1234567890",
                    SkillCode = 123,
                },
                new Trainer {
                    TrainerId = 3,
                    TrainerName = "Prabhat Vishwakarma",
                    TrainerEmail = "Prabhat Vishwakarma@gmail.com",
                    TrainerPhone = "1234567890",
                    SkillCode = 123,
                },
                new Trainer {
                    TrainerId = 4,
                    TrainerName = "Omkar Agrwal",
                    TrainerEmail = "uyuugu@gmail.com",
                    TrainerPhone = "1234567890",
                    SkillCode = 123,
                }
            };
        private readonly DataContext _context;

        public TrainerController(DataContext Context)
        {
            _context = Context;
        }
        [HttpGet("ShowAvailableTrainer")]
        public async Task<ActionResult<List<Trainer>>> Get()
        {

            return Ok(await _context.trainers.ToListAsync());
        }

        [HttpGet("SearchById")]
        public async Task<ActionResult<Trainer>> Get(int SearchById)
        {
            var Train = await _context.trainers.FindAsync(SearchById);
            if (Train == null)
                return BadRequest("Trainer Not Found");
            return Ok(Train);
        }


        [HttpPost("RegisterTrainer")]
        public async Task<ActionResult<List<Trainer>>> AddTrainer(Trainer train)
        {
            _context.trainers.Add(train);
            await _context.SaveChangesAsync();
            return Ok(await _context.trainers.ToListAsync());
        }

        [HttpPut("UpdateTrainer")]
        public async Task<ActionResult<Trainer>> UpdateHero(Trainer request)
        {
            var dbTrain = await _context.trainers.FindAsync(request.TrainerId);
            if (dbTrain == null)
                return BadRequest("Triner Not Found");

            dbTrain.TrainerName = request.TrainerName;
            dbTrain.TrainerEmail = request.TrainerEmail;
            dbTrain.TrainerPhone = request.TrainerPhone;
            dbTrain.SkillCode = request.SkillCode;

            await _context.SaveChangesAsync();

            return Ok(await _context.trainers.ToListAsync());
        }
        [HttpDelete("DeleteTrainerById")]
        public async Task<ActionResult<List<Trainer>>> DeleteTrainer(int DeleteTrainerById)
        {
            var dbTrain = await _context.trainers.FindAsync(DeleteTrainerById);
            if (dbTrain == null)
                return BadRequest("Trainer Not Found");
            _context.trainers.Remove(dbTrain);

            await _context.SaveChangesAsync();  
            return Ok(await _context.trainers.ToListAsync());
        }
    }}