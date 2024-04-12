using ICTPossibilityDomainCore.Model;
using Microsoft.EntityFrameworkCore;

namespace ICTPossibilityDALCore;

public static class StaticMethods
{
    public static void OnModelCreatingICTPossibility(this ModelBuilder modelBuilder)
    {
        if (modelBuilder != null)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(News).Assembly);
        }
        else
        {
            throw new ArgumentNullException(nameof(modelBuilder));
        }

    }
}