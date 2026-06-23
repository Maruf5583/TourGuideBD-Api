using Microsoft.EntityFrameworkCore;
using TourGuideBD.Domain.Entities.Trip;

namespace TourGuideBD.Infrastructure.Persistence.Seed;

public static class BusStandSeedData
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<BusStand>().HasData(GetBusStands());
    }

    private static List<BusStand> GetBusStands()
    {
        return new List<BusStand>
        {
            // Dhaka Division
            new() { Id = 1,  Name = "Saidabad Bus Terminal",   NameBn = "সায়েদাবাদ বাস টার্মিনাল",  DistrictId = 1,  Latitude = 23.7191, Longitude = 90.4283, IsMainStand = true },
            new() { Id = 2,  Name = "Mohakhali Bus Terminal",  NameBn = "মহাখালী বাস টার্মিনাল",    DistrictId = 1,  Latitude = 23.7808, Longitude = 90.4035, IsMainStand = true },
            new() { Id = 3,  Name = "Gabtoli Bus Terminal",    NameBn = "গাবতলী বাস টার্মিনাল",     DistrictId = 1,  Latitude = 23.7737, Longitude = 90.3481, IsMainStand = true },
            new() { Id = 4,  Name = "Mymensingh Bus Terminal", NameBn = "ময়মনসিংহ বাস টার্মিনাল",  DistrictId = 51, Latitude = 24.7471, Longitude = 90.4203, IsMainStand = true },
            new() { Id = 5,  Name = "Tangail Bus Terminal",    NameBn = "টাঙ্গাইল বাস টার্মিনাল",   DistrictId = 13, Latitude = 24.2513, Longitude = 89.9167, IsMainStand = true },
            new() { Id = 6,  Name = "Gazipur Bus Terminal",    NameBn = "গাজীপুর বাস টার্মিনাল",    DistrictId = 3,  Latitude = 23.9999, Longitude = 90.4203, IsMainStand = true },
            new() { Id = 7,  Name = "Narayanganj Bus Terminal",NameBn = "নারায়ণগঞ্জ বাস টার্মিনাল", DistrictId = 9,  Latitude = 23.6238, Longitude = 90.4987, IsMainStand = true },

            // Chattogram Division
            new() { Id = 8,  Name = "Chattogram Bus Terminal", NameBn = "চট্টগ্রাম বাস টার্মিনাল",  DistrictId = 17, Latitude = 22.3569, Longitude = 91.7832, IsMainStand = true },
            new() { Id = 9,  Name = "Cox's Bazar Bus Terminal",NameBn = "কক্সবাজার বাস টার্মিনাল",  DistrictId = 19, Latitude = 21.4272, Longitude = 92.0058, IsMainStand = true },
            new() { Id = 10, Name = "Bandarban Bus Terminal",  NameBn = "বান্দরবান বাস টার্মিনাল",   DistrictId = 14, Latitude = 22.1953, Longitude = 92.2184, IsMainStand = true },
            new() { Id = 11, Name = "Rangamati Bus Terminal",  NameBn = "রাঙ্গামাটি বাস টার্মিনাল",  DistrictId = 24, Latitude = 22.6452, Longitude = 92.1703, IsMainStand = true },
            new() { Id = 12, Name = "Khagrachhari Bus Terminal",NameBn = "খাগড়াছড়ি বাস টার্মিনাল", DistrictId = 21, Latitude = 23.1193, Longitude = 91.9847, IsMainStand = true },
            new() { Id = 13, Name = "Cumilla Bus Terminal",    NameBn = "কুমিল্লা বাস টার্মিনাল",    DistrictId = 18, Latitude = 23.4607, Longitude = 91.1809, IsMainStand = true },
            new() { Id = 14, Name = "Brahmanbaria Bus Terminal",NameBn = "ব্রাহ্মণবাড়িয়া বাস টার্মিনাল", DistrictId = 15, Latitude = 23.9608, Longitude = 91.1115, IsMainStand = true },
            new() { Id = 15, Name = "Noakhali Bus Terminal",   NameBn = "নোয়াখালী বাস টার্মিনাল",   DistrictId = 23, Latitude = 22.8696, Longitude = 91.0996, IsMainStand = true },
            new() { Id = 16, Name = "Feni Bus Terminal",       NameBn = "ফেনী বাস টার্মিনাল",        DistrictId = 20, Latitude = 23.0235, Longitude = 91.3960, IsMainStand = true },

            // Sylhet Division
            new() { Id = 17, Name = "Sylhet Bus Terminal",     NameBn = "সিলেট বাস টার্মিনাল",       DistrictId = 46, Latitude = 24.8949, Longitude = 91.8687, IsMainStand = true },
            new() { Id = 18, Name = "Moulvibazar Bus Terminal",NameBn = "মৌলভীবাজার বাস টার্মিনাল",  DistrictId = 45, Latitude = 24.4826, Longitude = 91.7774, IsMainStand = true },
            new() { Id = 19, Name = "Habiganj Bus Terminal",   NameBn = "হবিগঞ্জ বাস টার্মিনাল",     DistrictId = 44, Latitude = 24.3745, Longitude = 91.4158, IsMainStand = true },
            new() { Id = 20, Name = "Sunamganj Bus Terminal",  NameBn = "সুনামগঞ্জ বাস টার্মিনাল",   DistrictId = 47, Latitude = 24.8807, Longitude = 91.3962, IsMainStand = true },

            // Rajshahi Division
            new() { Id = 21, Name = "Rajshahi Bus Terminal",   NameBn = "রাজশাহী বাস টার্মিনাল",     DistrictId = 31, Latitude = 24.3636, Longitude = 88.6241, IsMainStand = true },
            new() { Id = 22, Name = "Bogura Bus Terminal",     NameBn = "বগুড়া বাস টার্মিনাল",       DistrictId = 25, Latitude = 24.8465, Longitude = 89.3773, IsMainStand = true },
            new() { Id = 23, Name = "Pabna Bus Terminal",      NameBn = "পাবনা বাস টার্মিনাল",        DistrictId = 29, Latitude = 24.0064, Longitude = 89.2372, IsMainStand = true },
            new() { Id = 24, Name = "Sirajganj Bus Terminal",  NameBn = "সিরাজগঞ্জ বাস টার্মিনাল",   DistrictId = 32, Latitude = 24.4543, Longitude = 89.7006, IsMainStand = true },
            new() { Id = 25, Name = "Naogaon Bus Terminal",    NameBn = "নওগাঁ বাস টার্মিনাল",        DistrictId = 27, Latitude = 24.8044, Longitude = 88.9356, IsMainStand = true },

            // Khulna Division
            new() { Id = 26, Name = "Khulna Bus Terminal",     NameBn = "খুলনা বাস টার্মিনাল",        DistrictId = 35, Latitude = 22.8456, Longitude = 89.5403, IsMainStand = true },
            new() { Id = 27, Name = "Jashore Bus Terminal",    NameBn = "যশোর বাস টার্মিনাল",          DistrictId = 33, Latitude = 23.1664, Longitude = 89.2080, IsMainStand = true },
            new() { Id = 28, Name = "Bagerhat Bus Terminal",   NameBn = "বাগেরহাট বাস টার্মিনাল",     DistrictId = 33, Latitude = 22.6602, Longitude = 89.7854, IsMainStand = true },
            new() { Id = 29, Name = "Satkhira Bus Terminal",   NameBn = "সাতক্ষীরা বাস টার্মিনাল",    DistrictId = 41, Latitude = 22.7185, Longitude = 89.0705, IsMainStand = true },
            new() { Id = 30, Name = "Kushtia Bus Terminal",    NameBn = "কুষ্টিয়া বাস টার্মিনাল",     DistrictId = 37, Latitude = 23.9012, Longitude = 89.1202, IsMainStand = true },

            // Barishal Division
            new() { Id = 31, Name = "Barishal Bus Terminal",   NameBn = "বরিশাল বাস টার্মিনাল",       DistrictId = 42, Latitude = 22.7010, Longitude = 90.3535, IsMainStand = true },
            new() { Id = 32, Name = "Patuakhali Bus Terminal", NameBn = "পটুয়াখালী বাস টার্মিনাল",    DistrictId = 44, Latitude = 22.3596, Longitude = 90.3298, IsMainStand = true },
            new() { Id = 33, Name = "Bhola Bus Terminal",      NameBn = "ভোলা বাস টার্মিনাল",          DistrictId = 43, Latitude = 22.6858, Longitude = 90.6482, IsMainStand = true },

            // Rangpur Division
            new() { Id = 34, Name = "Rangpur Bus Terminal",    NameBn = "রংপুর বাস টার্মিনাল",         DistrictId = 61, Latitude = 25.7439, Longitude = 89.2752, IsMainStand = true },
            new() { Id = 35, Name = "Dinajpur Bus Terminal",   NameBn = "দিনাজপুর বাস টার্মিনাল",      DistrictId = 56, Latitude = 25.6279, Longitude = 88.6338, IsMainStand = true },
            new() { Id = 36, Name = "Gaibandha Bus Terminal",  NameBn = "গাইবান্ধা বাস টার্মিনাল",     DistrictId = 57, Latitude = 25.3288, Longitude = 89.5288, IsMainStand = true },
            new() { Id = 37, Name = "Kurigram Bus Terminal",   NameBn = "কুড়িগ্রাম বাস টার্মিনাল",    DistrictId = 58, Latitude = 25.8074, Longitude = 89.6360, IsMainStand = true },
            new() { Id = 38, Name = "Nilphamari Bus Terminal", NameBn = "নীলফামারী বাস টার্মিনাল",     DistrictId = 59, Latitude = 25.9318, Longitude = 88.8560, IsMainStand = true },
            new() { Id = 39, Name = "Panchagarh Bus Terminal", NameBn = "পঞ্চগড় বাস টার্মিনাল",        DistrictId = 60, Latitude = 26.3411, Longitude = 88.5541, IsMainStand = true },

            // Mymensingh Division
            new() { Id = 40, Name = "Jamalpur Bus Terminal",   NameBn = "জামালপুর বাস টার্মিনাল",      DistrictId = 49, Latitude = 24.9375, Longitude = 89.9370, IsMainStand = true },
            new() { Id = 41, Name = "Netrokona Bus Terminal",  NameBn = "নেত্রকোণা বাস টার্মিনাল",     DistrictId = 52, Latitude = 24.8696, Longitude = 90.7270, IsMainStand = true },
            new() { Id = 42, Name = "Sherpur Bus Terminal",    NameBn = "শেরপুর বাস টার্মিনাল",         DistrictId = 53, Latitude = 25.0204, Longitude = 90.0152, IsMainStand = true },
        };
    }
}