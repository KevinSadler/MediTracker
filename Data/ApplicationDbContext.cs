using System;
using System.Collections.Generic;
using System.Text;
using MediTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<EntrySymptom> EntrySymptoms { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>()
                .Property(n => n.Date)
                .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admina",
                LastName = "Straytor",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            ApplicationUser anotherUser = new ApplicationUser
            {
                FirstName = "Tony",
                LastName = "Montana",
                UserName = "tony@montana.com",
                NormalizedUserName = "TONY@MONTANA.COM",
                Email = "tony@montana.com",
                NormalizedEmail = "TONY@MONTANA.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794123",
                Id = "00000000-ffff-ffff-ffff-fffffffff123"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            var anotherPasswordHash = new PasswordHasher<ApplicationUser>();
            anotherUser.PasswordHash = passwordHash.HashPassword(anotherUser, "Tony8*");
            modelBuilder.Entity<ApplicationUser>().HasData(anotherUser);

            modelBuilder.Entity<Entry>().HasData(
           new Entry()
           {
               EntryId = 1,
               Notes = "This is entry #1",
               UserId = user.Id
           },
           new Entry()
           {
               EntryId = 2,
               Notes = "This is entry #2",
               UserId = anotherUser.Id
           }
       );
            modelBuilder.Entity<Symptom>().HasData(
          new Symptom()
          {
              SymptomId = 1,
              Title = "Headache",
              UserId = user.Id
          },
          new Symptom()
          {
              SymptomId = 2,
              Title = "Dizziness",
              UserId = user.Id
          },
         new Symptom()
         {
             SymptomId = 3,
             Title = "Blurry Vision",
             UserId = anotherUser.Id
         },
         new Symptom()
         {
             SymptomId = 4,
             Title = "Heart Palpatations",
             UserId = anotherUser.Id
         }
       );

            modelBuilder.Entity<Appointment>().HasData(
          new Appointment()
          {
              AppointmentId = 1,
              Location = "St Thomas Medical Partners",
              ReasonForVisit = "Headaches and Dizziness",
              UserId = user.Id
          },
          new Appointment()
          {
              AppointmentId = 2,
              Location = "Miami-Dade County ENT",
              ReasonForVisit = "Frequent Nosebleeds",
              UserId = anotherUser.Id
          }
      );

            modelBuilder.Entity<Note>().HasData(
         new Note()
         {
             NoteId = 1,
             AppointmentId = 1,
             Content = "Getting CT scan done tommorrow. Also found I have high blood pressure",
             Date = new DateTime()
         },
         new Note()
         {
             NoteId = 2,
             AppointmentId = 2,
             Content = "Those docters didn't know nothing, those cacaroaches",
         }
     ); ;
            modelBuilder.Entity<EntrySymptom>().HasData(
       new EntrySymptom()
       {
           Id = 1,
           EntryId = 1,
           SymptomId = 1
       },
       new EntrySymptom()
       {
           Id = 2,
           EntryId = 1,
           SymptomId = 2
       },
       new EntrySymptom()
       {
           Id = 3,
           EntryId = 2,
           SymptomId = 3
       },
       new EntrySymptom()
       {
           Id = 4,
           EntryId = 2,
           SymptomId = 4
       }
   );
            modelBuilder.Entity<Medication>().HasData(
        new Medication()
        {
            MedicationId = 1,
            Name = "Protonix",
            Description = "Proton pump inhibitor. Used for heartburn and indegestion.",
            Dosage = "40mg orally once a day",
            UserId = user.Id
        },
        new Medication()
        {
            MedicationId = 2,
            Name = "Ziac",
            Description = "Diuretic and beta-blocker for blood pressure",
            Dosage = "1 tablet twice a day",
            UserId = anotherUser.Id
        }
    );
        }
    }
};
