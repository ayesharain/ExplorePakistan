using System;
using System.Data.Entity.Migrations;
using ExplorePakistan.Models;

namespace ExplorePakistan.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // ===== CATEGORIES =====
            context.Categories.AddOrUpdate(c => c.Name,
                new Category { Id = 1, Name = "Mountains", Icon = "🏔️" },
                new Category { Id = 2, Name = "Beaches", Icon = "🏖️" },
                new Category { Id = 3, Name = "Historical", Icon = "🏛️" },
                new Category { Id = 4, Name = "Cultural", Icon = "🎭" },
                new Category { Id = 5, Name = "Adventure", Icon = "🧗" },
                new Category { Id = 6, Name = "Religious", Icon = "🕌" }
            );

            context.SaveChanges();

            // ===== MOUNTAINS (10) =====
            context.Destinations.AddOrUpdate(d => d.Name,
                new Destination
                {
                    Name = "K2",
                    Description = "World's 2nd highest peak at 8,611m in the Karakoram Range. K2 base camp sits at 5,200m — higher than most mountain peaks in the world.",
                    Province = "Gilgit-Baltistan",
                    City = "Skardu",
                    ImageUrl = "/Content/Images/k2.jpg",
                    BestTimeToVisit = "June - August",
                    ThingsToDo = "Mountaineering, trekking, base camp visits, photography",
                    HowToReach = "Fly to Skardu from Islamabad, then jeep to base camp",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hunza Valley",
                    Description = "Scenic valley with views of Rakaposhi (7,788m) and Ultar Sar. Known for cherry blossoms in spring, ancient forts, and Attabad Lake.",
                    Province = "Gilgit-Baltistan",
                    City = "Karimabad",
                    ImageUrl = "/Content/Images/hunza.jpg",
                    BestTimeToVisit = "April - October",
                    ThingsToDo = "Eagle's Nest viewpoint, Baltit Fort, Altit Fort, Attabad Lake boating",
                    HowToReach = "15 hours from Islamabad via Karakoram Highway",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Nanga Parbat",
                    Description = "World's 9th highest peak at 8,126m, nicknamed 'Killer Mountain'. Fairy Meadows at its base offers iconic views.",
                    Province = "Gilgit-Baltistan",
                    City = "Diamer",
                    ImageUrl = "/Content/Images/nangaparbat.jpg",
                    BestTimeToVisit = "June - September",
                    ThingsToDo = "Trekking, photography, camping at Fairy Meadows",
                    HowToReach = "Jeep ride from Raikot Bridge then 3-hour hike",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Fairy Meadows",
                    Description = "One of Pakistan's most iconic viewpoints at the foot of Nanga Parbat. Lush green alpine meadows with breathtaking mountain views.",
                    Province = "Gilgit-Baltistan",
                    City = "Diamer",
                    ImageUrl = "/Content/Images/fairymeadows.jpg",
                    BestTimeToVisit = "May - September",
                    ThingsToDo = "Camping, photography, short hikes, stargazing",
                    HowToReach = "Jeep from Raikot Bridge + 3-hour trek",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Swat Valley",
                    Description = "Called the 'Switzerland of Pakistan' for its snow-capped mountains, lush valleys, and crystal rivers.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Mingora",
                    ImageUrl = "/Content/Images/swat.jpg",
                    BestTimeToVisit = "April - October",
                    ThingsToDo = "Malam Jabba skiing, Kalam valley, Mahodand Lake, Buddhist ruins",
                    HowToReach = "5 hours drive from Islamabad via Motorway",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Skardu",
                    Description = "Gateway to K2, Broad Peak, and Gasherbrum. Features stunning lakes like Satpara and Upper Kachura with turquoise waters.",
                    Province = "Gilgit-Baltistan",
                    City = "Skardu",
                    ImageUrl = "/Content/Images/skardu.jpg",
                    BestTimeToVisit = "May - September",
                    ThingsToDo = "Trekking, jeep safaris, lake visits, mountaineering",
                    HowToReach = "Flight from Islamabad or 24-hour road trip via KKH",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Naltar Valley",
                    Description = "Famous for multi-colored lakes — blue, green, and purple — surrounded by pine forests.",
                    Province = "Gilgit-Baltistan",
                    City = "Gilgit",
                    ImageUrl = "/Content/Images/naltar.jpg",
                    BestTimeToVisit = "May - September",
                    ThingsToDo = "Visit colored lakes, skiing in winter, photography",
                    HowToReach = "2 hours jeep ride from Gilgit",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Murree",
                    Description = "Pakistan's most popular hill station and closest to Islamabad. A favorite family getaway with pine forests.",
                    Province = "Punjab",
                    City = "Murree",
                    ImageUrl = "/Content/Images/murree.jpg",
                    BestTimeToVisit = "March - October",
                    ThingsToDo = "Mall Road walk, Pindi Point, chairlift, Patriata",
                    HowToReach = "2 hours from Islamabad by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Deosai Plains",
                    Description = "World's second highest plateau at 4,114m. Vast grasslands home to Himalayan brown bears.",
                    Province = "Gilgit-Baltistan",
                    City = "Skardu",
                    ImageUrl = "/Content/Images/deosai.jpg",
                    BestTimeToVisit = "July - August",
                    ThingsToDo = "Wildlife spotting, photography, camping, jeep safari",
                    HowToReach = "3-hour jeep ride from Skardu (summer only)",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Gilgit",
                    Description = "Gateway city to all of northern Pakistan. Surrounded by Rakaposhi and Nanga Parbat with ancient Buddhist rock carvings.",
                    Province = "Gilgit-Baltistan",
                    City = "Gilgit",
                    ImageUrl = "/Content/Images/gilgit.jpg",
                    BestTimeToVisit = "April - October",
                    ThingsToDo = "Kargah Buddha rock carving, Gilgit River, local bazaars",
                    HowToReach = "Flight from Islamabad or KKH drive",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 1,
                    CreatedAt = DateTime.Now
                },

                // ===== BEACHES (8) =====
                new Destination
                {
                    Name = "Gwadar Beach",
                    Description = "Rapidly developing port city on the Arabian Sea with stunning Hammerhead Peninsula. Crystal clear waters and golden sand.",
                    Province = "Balochistan",
                    City = "Gwadar",
                    ImageUrl = "/Content/Images/gwadar.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Beach walks, boat rides, Hammerhead Peninsula, seafood",
                    HowToReach = "Flight from Karachi or 8-hour drive from Quetta",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Kund Malir Beach",
                    Description = "Pakistan's most beautiful beach where golden desert dunes meet turquoise Arabian Sea. Pristine and untouched.",
                    Province = "Balochistan",
                    City = "Hingol",
                    ImageUrl = "/Content/Images/kundmalir.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Road trips, camping, photography, sunsets",
                    HowToReach = "4-hour drive from Karachi on Makran Coastal Highway",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Clifton Beach",
                    Description = "Most visited beach in Pakistan. Popular for camel rides, horse rides, street food, and vibrant sunsets.",
                    Province = "Sindh",
                    City = "Karachi",
                    ImageUrl = "/Content/Images/clifton.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Camel rides, horse rides, street food, sunset watching",
                    HowToReach = "Located within Karachi city center",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Astola Island",
                    Description = "Pakistan's largest offshore island — 6.7 sq km, completely uninhabited. Crystal-clear water and coral reefs.",
                    Province = "Balochistan",
                    City = "Pasni",
                    ImageUrl = "/Content/Images/astola.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Scuba diving, snorkeling, camping, stargazing, fishing",
                    HowToReach = "3-4 hour boat ride from Pasni",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Ormara Beach",
                    Description = "Stunning beach 240km from Karachi with Arabian Sea views and mountains. Known for sea turtle nesting.",
                    Province = "Balochistan",
                    City = "Ormara",
                    ImageUrl = "/Content/Images/ormara.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Camping, photography, road trips, seashell collecting",
                    HowToReach = "240 km from Karachi on Makran Coastal Highway",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "French Beach",
                    Description = "One of Karachi's cleanest and least crowded beaches. Clear water suitable for swimming.",
                    Province = "Sindh",
                    City = "Karachi",
                    ImageUrl = "/Content/Images/frenchbeach.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Swimming, picnics, beach camping, snorkeling",
                    HowToReach = "45 minutes from Karachi center",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hawksbay Beach",
                    Description = "Famous for green turtle nesting. Family-friendly beach with calmer waters and beautiful sunsets.",
                    Province = "Sindh",
                    City = "Karachi",
                    ImageUrl = "/Content/Images/hawksbay.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Turtle watching, beach camping, horse riding",
                    HowToReach = "40 minutes from Karachi center",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Jiwani Beach",
                    Description = "Remote pristine beach near Iranian border. Home to historic Queen Victoria Hut and endangered green turtles.",
                    Province = "Balochistan",
                    City = "Jiwani",
                    ImageUrl = "/Content/Images/jiwani.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Beach exploration, turtle conservation, mangrove forests",
                    HowToReach = "By road from Gwadar or boat",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 2,
                    CreatedAt = DateTime.Now
                },

                // ===== HISTORICAL (11) =====
                new Destination
                {
                    Name = "Lahore Fort",
                    Description = "UNESCO World Heritage Site built by Mughal emperors. Houses 21 monuments including Sheesh Mahal.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/lahorefort.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Explore Sheesh Mahal, Naulakha Pavilion, Alamgiri Gate",
                    HowToReach = "Located in Walled City, Lahore",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Badshahi Mosque",
                    Description = "Built in 1673 by Emperor Aurangzeb. One of the largest mosques in the world. Capacity 50,000+ worshippers.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/badshahi.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Explore mosque interior, courtyard, photography",
                    HowToReach = "Located in Walled City, opposite Lahore Fort",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Mohenjo-Daro",
                    Description = "UNESCO World Heritage Site — one of the world's oldest cities dating back 4,500+ years. Indus Valley Civilization.",
                    Province = "Sindh",
                    City = "Larkana",
                    ImageUrl = "/Content/Images/mohenjodaro.jpg",
                    BestTimeToVisit = "November - February",
                    ThingsToDo = "Explore ruins, visit museum, learn about Indus Valley",
                    HowToReach = "27km from Larkana, accessible by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Taxila",
                    Description = "UNESCO World Heritage Site. Greatest center of Buddhist learning in the ancient world.",
                    Province = "Punjab",
                    City = "Taxila",
                    ImageUrl = "/Content/Images/taxila.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Visit Buddhist stupas, Taxila Museum, Jaulian monastery",
                    HowToReach = "35 km from Islamabad by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Rohtas Fort",
                    Description = "UNESCO World Heritage Site by Sher Shah Suri. One of the largest forts in South Asia, walls spanning 4 km.",
                    Province = "Punjab",
                    City = "Jhelum",
                    ImageUrl = "/Content/Images/rohtas.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Explore massive walls, gates, historical architecture",
                    HowToReach = "16 km from Jhelum city",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Derawar Fort",
                    Description = "Towering 30-meter high desert fort in Cholistan. Visible from miles away in the vast desert.",
                    Province = "Punjab",
                    City = "Bahawalpur",
                    ImageUrl = "/Content/Images/derawar.jpg",
                    BestTimeToVisit = "November - February",
                    ThingsToDo = "Photography at sunrise/sunset, Cholistan jeep rally",
                    HowToReach = "48 km south of Bahawalpur into Cholistan",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Shalimar Gardens",
                    Description = "UNESCO World Heritage Site by Shah Jahan (1641). Three terraced levels with 410 fountains.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/shalimar.jpg",
                    BestTimeToVisit = "March - April",
                    ThingsToDo = "Walk through terraced gardens, see fountains, photography",
                    HowToReach = "Located in Lahore city, GT Road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Minar-e-Pakistan",
                    Description = "60-meter tall monument marking the 1940 Pakistan Resolution. Set in Iqbal Park.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/minarepakistan.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Visit monument, Iqbal Park, food street nearby",
                    HowToReach = "Located in central Lahore near Badshahi Mosque",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Harappa",
                    Description = "Ancient Indus Valley Civilization site discovered in 1920s. Museum with excavated artifacts on-site.",
                    Province = "Punjab",
                    City = "Sahiwal",
                    ImageUrl = "/Content/Images/harappa.jpg",
                    BestTimeToVisit = "November - February",
                    ThingsToDo = "Explore ruins, visit museum, archaeological tour",
                    HowToReach = "35 km from Sahiwal by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hiran Minar",
                    Description = "Built by Emperor Jahangir for his pet antelope. 30-meter minaret with lake.",
                    Province = "Punjab",
                    City = "Sheikhupura",
                    ImageUrl = "/Content/Images/hiranminar.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Climb minaret, boating in lake, photography",
                    HowToReach = "40 km from Lahore",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Mohatta Palace",
                    Description = "1927 colonial palace with pink Jodhpur stone. Now a museum with art and heritage exhibitions.",
                    Province = "Sindh",
                    City = "Karachi",
                    ImageUrl = "/Content/Images/mohatta.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Art exhibitions, heritage tours, photography",
                    HowToReach = "Located in Clifton, Karachi",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 3,
                    CreatedAt = DateTime.Now
                },

                // ===== CULTURAL (8) =====
                new Destination
                {
                    Name = "Lahore Walled City",
                    Description = "Heart of Pakistan. Vibrant street life, Food Street, Anarkali Bazaar, and Wazir Khan Mosque.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/walledcity.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Food Street, Anarkali Bazaar, Wazir Khan Mosque, crafts",
                    HowToReach = "Central Lahore, accessible by road",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Kalash Valley",
                    Description = "Home to the indigenous Kalash people with unique culture, dress, music, and festivals.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Chitral",
                    ImageUrl = "/Content/Images/kalash.jpg",
                    BestTimeToVisit = "May, August, December",
                    ThingsToDo = "Attend Kalash festivals, cultural immersion, photography",
                    HowToReach = "Fly to Chitral then drive to Kalash valleys",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Peshawar Old City",
                    Description = "One of Asia's oldest cities. Famous for Qissa Khwani Bazaar and incredible Pashtun food.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Peshawar",
                    ImageUrl = "/Content/Images/peshawar.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Qissa Khwani Bazaar, Peshawar Museum, Bala Hisar Fort",
                    HowToReach = "2 hours from Islamabad by motorway",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Multan",
                    Description = "City of Saints. Famous for Sufi shrines, blue pottery, mangoes, and Sohan Halwa.",
                    Province = "Punjab",
                    City = "Multan",
                    ImageUrl = "/Content/Images/multan.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Shah Rukn-e-Alam shrine, blue pottery, Hussain Agahi Bazaar",
                    HowToReach = "5 hours from Lahore by motorway",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Lok Virsa Museum",
                    Description = "National folk heritage museum with crafts, textiles, instruments from all provinces.",
                    Province = "Islamabad",
                    City = "Islamabad",
                    ImageUrl = "/Content/Images/lokvirsa.jpg",
                    BestTimeToVisit = "Year-round",
                    ThingsToDo = "Museum tour, traditional village, folk performances",
                    HowToReach = "Located in Islamabad near Faisal Mosque",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Wagah Border Ceremony",
                    Description = "Daily flag-lowering ceremony at India-Pakistan border. Thousands of spectators daily.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/wagah.jpg",
                    BestTimeToVisit = "Year-round (daily at sunset)",
                    ThingsToDo = "Watch ceremony, experience patriotic atmosphere",
                    HowToReach = "30 km from Lahore at India border",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Shandur Polo Festival",
                    Description = "Annual polo at 3,700m altitude. Teams from Chitral and Gilgit compete every July.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Chitral",
                    ImageUrl = "/Content/Images/shandur.jpg",
                    BestTimeToVisit = "July",
                    ThingsToDo = "Watch polo, music, dance, cultural events",
                    HowToReach = "Drive from Chitral or Gilgit to Shandur Pass",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hyderabad",
                    Description = "Rich Sindhi culture with Ajrak, Sindhi topi, glass bangles, and historic forts.",
                    Province = "Sindh",
                    City = "Hyderabad",
                    ImageUrl = "/Content/Images/hyderabad.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Pakka Qila, glass bangles bazaar, Sindhi embroidery",
                    HowToReach = "2 hours from Karachi by motorway",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 4,
                    CreatedAt = DateTime.Now
                },

                // ===== ADVENTURE (10) =====
                new Destination
                {
                    Name = "K2 Base Camp Trek",
                    Description = "One of the world's most demanding treks through Baltoro Glacier. 14-18 days, expert level.",
                    Province = "Gilgit-Baltistan",
                    City = "Skardu",
                    ImageUrl = "/Content/Images/k2basecamp.jpg",
                    BestTimeToVisit = "June - August",
                    ThingsToDo = "Trekking, mountaineering, glacier walking, photography",
                    HowToReach = "Fly to Skardu, trek from Askole village",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Karakoram Highway",
                    Description = "One of the highest paved roads in the world. 1,300 km from Islamabad to China border.",
                    Province = "Gilgit-Baltistan",
                    City = "Multiple",
                    ImageUrl = "/Content/Images/kkh.jpg",
                    BestTimeToVisit = "May - October",
                    ThingsToDo = "Road trip, motorcycle tour, jeep safari, photography",
                    HowToReach = "Starts from Islamabad, ends at China border",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Malam Jabba Ski Resort",
                    Description = "Pakistan's premier ski resort at 2,804m in Swat. Skiing, snowboarding, zip-lining.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Swat",
                    ImageUrl = "/Content/Images/malamjabba.jpg",
                    BestTimeToVisit = "December - February",
                    ThingsToDo = "Skiing, snowboarding, chairlift, zip-lining",
                    HowToReach = "Drive from Mingora, Swat Valley",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hingol National Park",
                    Description = "Pakistan's largest national park. Mud volcanoes, Princess of Hope, Sphinx rock.",
                    Province = "Balochistan",
                    City = "Lasbela",
                    ImageUrl = "/Content/Images/hingol.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Jeep safari, mud volcanoes, Princess of Hope, Sphinx rock",
                    HowToReach = "On Makran Coastal Highway from Karachi",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Neelum Valley",
                    Description = "Spectacular valley in AJK with waterfalls, rivers, dense forests, and pristine lakes.",
                    Province = "Azad Kashmir",
                    City = "Muzaffarabad",
                    ImageUrl = "/Content/Images/neelum.jpg",
                    BestTimeToVisit = "April - October",
                    ThingsToDo = "Hiking, camping, fishing, Ratti Gali Lake trek",
                    HowToReach = "Drive from Muzaffarabad along Neelum River",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Attabad Lake",
                    Description = "Stunning turquoise lake formed by 2010 landslide. 23 km long on Karakoram Highway.",
                    Province = "Gilgit-Baltistan",
                    City = "Hunza",
                    ImageUrl = "/Content/Images/attabad.jpg",
                    BestTimeToVisit = "May - October",
                    ThingsToDo = "Boating, kayaking, jet skiing, photography",
                    HowToReach = "On KKH, 15 km from Karimabad",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Ratti Gali Lake Trek",
                    Description = "Glacial lake at 3,700m. Moderate 1-2 day trek through meadows and pine forests.",
                    Province = "Azad Kashmir",
                    City = "Neelum",
                    ImageUrl = "/Content/Images/rattigali.jpg",
                    BestTimeToVisit = "June - September",
                    ThingsToDo = "Trekking, camping, photography, fishing",
                    HowToReach = "Trek from Dowarian village, Neelum Valley",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Baltoro Glacier Trek",
                    Description = "One of the world's longest glaciers. Surrounded by 4 eight-thousanders including K2.",
                    Province = "Gilgit-Baltistan",
                    City = "Skardu",
                    ImageUrl = "/Content/Images/baltoro.jpg",
                    BestTimeToVisit = "June - August",
                    ThingsToDo = "Glacier trekking, mountaineering, photography",
                    HowToReach = "Trek starts from Askole village near Skardu",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "River Rafting Kunhar",
                    Description = "White-water rafting on Kunhar River in Naran. Grade II-IV rapids in mountain valley.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Naran",
                    ImageUrl = "/Content/Images/rafting.jpg",
                    BestTimeToVisit = "April - July",
                    ThingsToDo = "White-water rafting, kayaking, riverside camping",
                    HowToReach = "Drive to Naran from Islamabad (8 hours)",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Paragliding Nathia Gali",
                    Description = "Tandem paragliding near Islamabad with views of Margalla Hills and Himalayan foothills.",
                    Province = "Khyber Pakhtunkhwa",
                    City = "Abbottabad",
                    ImageUrl = "/Content/Images/paragliding.jpg",
                    BestTimeToVisit = "March - November",
                    ThingsToDo = "Tandem paragliding, hiking, photography",
                    HowToReach = "2.5 hours from Islamabad",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 5,
                    CreatedAt = DateTime.Now
                },

                // ===== RELIGIOUS (11) =====
                new Destination
                {
                    Name = "Faisal Mosque",
                    Description = "National mosque of Pakistan. Unique tent design, capacity 300,000. Tallest minarets in South Asia.",
                    Province = "Islamabad",
                    City = "Islamabad",
                    ImageUrl = "/Content/Images/faisal.jpg",
                    BestTimeToVisit = "Year-round",
                    ThingsToDo = "Visit mosque, photography from Daman-e-Koh viewpoint",
                    HowToReach = "Located in Islamabad at foot of Margalla Hills",
                    IsFeatured = true,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Data Darbar",
                    Description = "Shrine of 11th-century Sufi saint Hazrat Ali Hajveri. Most visited shrine in South Asia. Open 24/7.",
                    Province = "Punjab",
                    City = "Lahore",
                    ImageUrl = "/Content/Images/datadarbar.jpg",
                    BestTimeToVisit = "Year-round (Thursday for Qawwali)",
                    ThingsToDo = "Spiritual visit, Qawwali music on Thursday nights",
                    HowToReach = "Located in central Lahore",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Lal Shahbaz Qalandar Shrine",
                    Description = "13th-century Sufi saint's tomb. Famous for Dhamaal devotional dance every Thursday.",
                    Province = "Sindh",
                    City = "Sehwan Sharif",
                    ImageUrl = "/Content/Images/lalshahbaz.jpg",
                    BestTimeToVisit = "Year-round",
                    ThingsToDo = "Witness Dhamaal dance, spiritual experience",
                    HowToReach = "3 hours from Hyderabad by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Kartarpur Gurdwara",
                    Description = "Where Guru Nanak lived his final 18 years. Holiest Sikh site. Visa-free corridor since 2019.",
                    Province = "Punjab",
                    City = "Narowal",
                    ImageUrl = "/Content/Images/kartarpur.jpg",
                    BestTimeToVisit = "Year-round",
                    ThingsToDo = "Pilgrimage, explore restored gurdwara",
                    HowToReach = "4 km from India-Pakistan border",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Gurdwara Panja Sahib",
                    Description = "Where Guru Nanak left his handprint on a boulder. Major Sikh pilgrimage site.",
                    Province = "Punjab",
                    City = "Hassan Abdal",
                    ImageUrl = "/Content/Images/panjasahib.jpg",
                    BestTimeToVisit = "April (Baisakhi)",
                    ThingsToDo = "Pilgrimage, see sacred handprint, attend festival",
                    HowToReach = "48 km from Islamabad on GT Road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Hinglaj Mata Temple",
                    Description = "One of 51 Shakti Peethas worldwide. Inside a cave in Hingol National Park. 250,000+ pilgrims yearly.",
                    Province = "Balochistan",
                    City = "Lasbela",
                    ImageUrl = "/Content/Images/hinglaj.jpg",
                    BestTimeToVisit = "March - April",
                    ThingsToDo = "Pilgrimage, cave exploration, Hingol National Park",
                    HowToReach = "Inside Hingol National Park, 250km from Karachi",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Katas Raj Temples",
                    Description = "Ancient Hindu temples around a sacred pond mentioned in Mahabharata.",
                    Province = "Punjab",
                    City = "Chakwal",
                    ImageUrl = "/Content/Images/katasraj.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Temple exploration, sacred pond, archaeological tour",
                    HowToReach = "40 km from Chakwal city",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Nankana Sahib",
                    Description = "Birthplace of Guru Nanak Dev, founder of Sikhism. Major global Sikh pilgrimage site.",
                    Province = "Punjab",
                    City = "Nankana Sahib",
                    ImageUrl = "/Content/Images/nankanasahib.jpg",
                    BestTimeToVisit = "April and November",
                    ThingsToDo = "Pilgrimage, attend festivals, explore gurdwara",
                    HowToReach = "80 km from Lahore by road",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Shah Abdul Latif Bhittai Shrine",
                    Description = "18th-century Sufi poet's tomb. His Shah Jo Risalo is a masterpiece of Sindhi literature.",
                    Province = "Sindh",
                    City = "Bhit Shah",
                    ImageUrl = "/Content/Images/shahlatif.jpg",
                    BestTimeToVisit = "Year-round",
                    ThingsToDo = "Spiritual visit, poetry recitals, Urs festival",
                    HowToReach = "Located in Bhit Shah, Sindh",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Sadhu Bela Temple",
                    Description = "Hindu temple on an island in the Indus River. Dedicated to Lord Krishna, accessible by boat.",
                    Province = "Sindh",
                    City = "Sukkur",
                    ImageUrl = "/Content/Images/sadhubela.jpg",
                    BestTimeToVisit = "October - March",
                    ThingsToDo = "Boat ride to island, temple tour, river views",
                    HowToReach = "Boat from Sukkur riverbank",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                },
                new Destination
                {
                    Name = "Abdullah Shah Ghazi Shrine",
                    Description = "8th-century Sufi saint's tomb on a hill overlooking the sea in Clifton, Karachi.",
                    Province = "Sindh",
                    City = "Karachi",
                    ImageUrl = "/Content/Images/abdullahshah.jpg",
                    BestTimeToVisit = "Year-round (Thursday evenings)",
                    ThingsToDo = "Spiritual visit, sea views, Thursday devotion",
                    HowToReach = "Located in Clifton, Karachi near beach",
                    IsFeatured = false,
                    IsActive = true,
                    CategoryId = 6,
                    CreatedAt = DateTime.Now
                }
            );
        }
    }
}