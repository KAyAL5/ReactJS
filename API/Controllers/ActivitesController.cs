﻿using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Presistence;
using System.Linq;

namespace API.Controllers
{
    public class ActivitesController : BaseAPIController
    {
        private readonly DataContext _context;
        public ActivitesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetAllActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}