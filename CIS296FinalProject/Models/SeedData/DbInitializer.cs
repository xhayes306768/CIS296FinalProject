using CIS296FinalProject.Data;
using CIS296FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

public static class DbInitializer
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = serviceProvider.GetRequiredService<MusicContext>())
        {
            // Check if the database already contains data
            if (context.Albums.Any())
            {
                return;   // Database has been seeded
            }

            // Add dummy data
            context.Albums.AddRange(
                new Album { Title = "Dummy Album 1", Artist = "Dummy Artist 1", ReleaseDate = DateTime.Now },
                new Album { Title = "Dummy Album 2", Artist = "Dummy Artist 2", ReleaseDate = DateTime.Now }
                // Add more dummy albums as needed
            );

            // Save changes to the database
            context.SaveChanges();
        }
    }
}
