using Microsoft.EntityFrameworkCore;
using TourGuideBD.Domain.Entities.Trip;

namespace TourGuideBD.Infrastructure.Persistence.Seed;

public static class DistrictBusRouteSeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<DistrictBusRoute>().HasData(GetRoutes());
    }

    private static List<DistrictBusRoute> GetRoutes()
    {
        return new List<DistrictBusRoute>
        {
            // Dhaka (1) → other districts
            new() { Id = 1,  FromDistrictId = 1,  ToDistrictId = 17, BusCost = 800,  BusTimeMinutes = 360 }, // Dhaka→Ctg
            new() { Id = 2,  FromDistrictId = 1,  ToDistrictId = 19, BusCost = 1050, BusTimeMinutes = 480 }, // Dhaka→Cox
            new() { Id = 3,  FromDistrictId = 1,  ToDistrictId = 46, BusCost = 500,  BusTimeMinutes = 300 }, // Dhaka→Sylhet
            new() { Id = 4,  FromDistrictId = 1,  ToDistrictId = 51, BusCost = 150,  BusTimeMinutes = 120 }, // Dhaka→Mymensingh
            new() { Id = 5,  FromDistrictId = 1,  ToDistrictId = 31, BusCost = 450,  BusTimeMinutes = 240 }, // Dhaka→Rajshahi
            new() { Id = 6,  FromDistrictId = 1,  ToDistrictId = 35, BusCost = 400,  BusTimeMinutes = 300 }, // Dhaka→Khulna
            new() { Id = 7,  FromDistrictId = 1,  ToDistrictId = 42, BusCost = 350,  BusTimeMinutes = 240 }, // Dhaka→Barishal
            new() { Id = 8,  FromDistrictId = 1,  ToDistrictId = 61, BusCost = 600,  BusTimeMinutes = 360 }, // Dhaka→Rangpur
            new() { Id = 9,  FromDistrictId = 1,  ToDistrictId = 25, BusCost = 400,  BusTimeMinutes = 240 }, // Dhaka→Bogura
            new() { Id = 10, FromDistrictId = 1,  ToDistrictId = 13, BusCost = 150,  BusTimeMinutes = 120 }, // Dhaka→Tangail
            new() { Id = 11, FromDistrictId = 1,  ToDistrictId = 18, BusCost = 350,  BusTimeMinutes = 180 }, // Dhaka→Cumilla
            new() { Id = 12, FromDistrictId = 1,  ToDistrictId = 33, BusCost = 500,  BusTimeMinutes = 360 }, // Dhaka→Jashore
            new() { Id = 13, FromDistrictId = 1,  ToDistrictId = 56, BusCost = 700,  BusTimeMinutes = 420 }, // Dhaka→Dinajpur

            // Chattogram (17) → other districts
            new() { Id = 14, FromDistrictId = 17, ToDistrictId = 19, BusCost = 200,  BusTimeMinutes = 120 }, // Ctg→Cox
            new() { Id = 15, FromDistrictId = 17, ToDistrictId = 14, BusCost = 250,  BusTimeMinutes = 150 }, // Ctg→Bandarban
            new() { Id = 16, FromDistrictId = 17, ToDistrictId = 24, BusCost = 200,  BusTimeMinutes = 120 }, // Ctg→Rangamati
            new() { Id = 17, FromDistrictId = 17, ToDistrictId = 21, BusCost = 150,  BusTimeMinutes = 90  }, // Ctg→Khagrachhari
            new() { Id = 18, FromDistrictId = 17, ToDistrictId = 18, BusCost = 200,  BusTimeMinutes = 120 }, // Ctg→Cumilla
            new() { Id = 19, FromDistrictId = 17, ToDistrictId = 46, BusCost = 400,  BusTimeMinutes = 240 }, // Ctg→Sylhet

            // Sylhet (46) → other districts
            new() { Id = 20, FromDistrictId = 46, ToDistrictId = 51, BusCost = 600,  BusTimeMinutes = 300 }, // Sylhet→Mymensingh
            new() { Id = 21, FromDistrictId = 46, ToDistrictId = 45, BusCost = 100,  BusTimeMinutes = 60  }, // Sylhet→Moulvibazar
            new() { Id = 22, FromDistrictId = 46, ToDistrictId = 44, BusCost = 150,  BusTimeMinutes = 90  }, // Sylhet→Habiganj
            new() { Id = 23, FromDistrictId = 46, ToDistrictId = 47, BusCost = 100,  BusTimeMinutes = 60  }, // Sylhet→Sunamganj

            // Mymensingh (51) → other districts
            new() { Id = 24, FromDistrictId = 51, ToDistrictId = 46, BusCost = 600,  BusTimeMinutes = 300 }, // Mymensingh→Sylhet
            new() { Id = 25, FromDistrictId = 51, ToDistrictId = 49, BusCost = 100,  BusTimeMinutes = 60  }, // Mymensingh→Jamalpur

            // Rajshahi (31) → other districts
            new() { Id = 26, FromDistrictId = 31, ToDistrictId = 25, BusCost = 150,  BusTimeMinutes = 90  }, // Rajshahi→Bogura
            new() { Id = 27, FromDistrictId = 31, ToDistrictId = 35, BusCost = 300,  BusTimeMinutes = 180 }, // Rajshahi→Khulna
            new() { Id = 28, FromDistrictId = 31, ToDistrictId = 29, BusCost = 100,  BusTimeMinutes = 60  }, // Rajshahi→Pabna

            // Khulna (35) → other districts
            new() { Id = 29, FromDistrictId = 35, ToDistrictId = 42, BusCost = 200,  BusTimeMinutes = 120 }, // Khulna→Barishal
            new() { Id = 30, FromDistrictId = 35, ToDistrictId = 33, BusCost = 100,  BusTimeMinutes = 60  }, // Khulna→Jashore
            new() { Id = 31, FromDistrictId = 35, ToDistrictId = 41, BusCost = 150,  BusTimeMinutes = 90  }, // Khulna→Satkhira

            // Rangpur (61) → other districts
            new() { Id = 32, FromDistrictId = 61, ToDistrictId = 56, BusCost = 150,  BusTimeMinutes = 90  }, // Rangpur→Dinajpur
            new() { Id = 33, FromDistrictId = 61, ToDistrictId = 25, BusCost = 200,  BusTimeMinutes = 120 }, // Rangpur→Bogura
            new() { Id = 34, FromDistrictId = 61, ToDistrictId = 57, BusCost = 100,  BusTimeMinutes = 60  }, // Rangpur→Gaibandha

            // Bogura (25) → other districts
            new() { Id = 35, FromDistrictId = 25, ToDistrictId = 32, BusCost = 100,  BusTimeMinutes = 60  }, // Bogura→Sirajganj
            new() { Id = 36, FromDistrictId = 25, ToDistrictId = 13, BusCost = 200,  BusTimeMinutes = 120 }, // Bogura→Tangail
        };
    }
}