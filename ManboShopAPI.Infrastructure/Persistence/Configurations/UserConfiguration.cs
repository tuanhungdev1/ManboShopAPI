using Bogus;
using ManboShopAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			var passwordHasher = new PasswordHasher<User>();

			var faker = new Faker<User>("en")
				.RuleFor(u => u.Id, f => f.IndexFaker + 1)
				.RuleFor(u => u.FirstName, f => f.Name.FirstName())
				.RuleFor(u => u.LastName, f => f.Name.LastName())
				.RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
				.RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName.ToUpper())
				.RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
				.RuleFor(u => u.NormalizedEmail, (f, u) => u.Email.ToUpper())
				.RuleFor(u => u.Address, f => f.Address.FullAddress())
				.RuleFor(u => u.ProfilePictureUrl, f => f.Internet.Avatar())
				.RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("###-###-####"))
				.RuleFor(u => u.CreatedAt, f => DateTime.UtcNow.AddDays(-f.Random.Int(0, 365)))
				.RuleFor(u => u.EmailConfirmed, true)
				.RuleFor(u => u.PhoneNumberConfirmed, true)
				.RuleFor(u => u.RefreshToken, (string?)null)
				.RuleFor(u => u.RefreshTokenExpiryTime, (DateTime?)null)
				.RuleFor(u => u.UpdatedAt, (DateTime?)null);

			
			var users = faker.Generate(40);
			users.ForEach(user =>
			{
				user.PasswordHash = passwordHasher.HashPassword(user, "Hung2742003@");
			});

			
			builder.HasData(users);
		}
	}
}