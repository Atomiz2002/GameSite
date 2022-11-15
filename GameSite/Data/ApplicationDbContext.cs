﻿using GameSite.Models;
using GameSite.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameSite.Data;

public class ApplicationDbContext : IdentityDbContext<User> {

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) {}

}