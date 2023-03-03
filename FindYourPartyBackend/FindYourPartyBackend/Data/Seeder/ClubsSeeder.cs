﻿using FindYourPartyBackend.Data.Models.DbModels;

namespace FindYourPartyBackend.Data.Seeder
{
    public class ClubsSeeder
    {
        static public IEnumerable<Club> GetClubs()
        {
            var clubs = new List<Club>()
            {
                new Club()
                {
                    ClubId = 1,
                    Id = Guid.NewGuid(),
                    Name = "Moderna",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla venenatis lorem quis neque pretium ornare. Nunc at arcu euismod turpis convallis finibus sit amet ut nunc. Suspendisse id tellus id justo tempor volutpat. Nulla volutpat tortor interdum lectus mattis, quis iaculis massa ultrices. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed lacus est, gravida ac arcu sit amet, pellentesque molestie mauris. Morbi scelerisque, nisi bibendum dictum pellentesque, nulla orci pharetra ipsum, eu condimentum neque dolor eu quam. Donec vulputate dictum arcu, ut accumsan massa iaculis sed. In ut purus at quam blandit imperdiet ac id magna.",
                    ClubSize = Enums.ClubSizeEnum.Medium,
                    NumberOfRooms = Enums.NumberOfRoomsEnum.Two,
                    Links = "https://www.facebook.com/ModernaClub/, http://modernadebica.com.pl/?fbclid=IwAR0mFlAdGeEcNz7hCU1mGO1-1sKJMevq6onsMMGJtsJ1Ark7eTREoRYUNN4#/",
                    PhoneNumber = "661 910 121, 535 454 288",
                    Address = new ClubAddress()
                    {
                        City = "Dębica",
                        Street = "Fabryczna",
                        Number = "12",
                        PostCode = "39-200"
                    },
                    OpeningHours = new ClubOpeningHours()
                    {
                        Monday = "Zamknięte",
                        Tuesday = "Zamknięte",
                        Wednesday = "Zamknięte",
                        Thursday = "Zamknięte",
                        Friday = "21:00 4:00",
                        Saturday = "21:00 4:00",
                        Sunday = "Zamknięte"
                    },
                    ClubClubTypes = new List<ClubClubType>()
                    {
                        new ClubClubType()
                        {
                            ClubId = 1,
                            ClubTypeId = 1
                        },
                        new ClubClubType()
                        {
                            ClubId = 1,
                            ClubTypeId = 3
                        }
                    },
                    ClubMusicTypes = new List<ClubMusicType>()
                    {
                        new ClubMusicType()
                        {
                            ClubId = 1,
                            MusicTypeId = 1
                        },
                        new ClubMusicType()
                        {
                            ClubId = 1,
                            MusicTypeId = 3
                        }
                    }
                },

                new Club()
                {
                    ClubId = 2,
                    Id = Guid.NewGuid(),
                    Name = "Carpe Diem",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla venenatis lorem quis neque pretium ornare. Nunc at arcu euismod turpis convallis finibus sit amet ut nunc. Suspendisse id tellus id justo tempor volutpat. Nulla volutpat tortor interdum lectus mattis, quis iaculis massa ultrices. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed lacus est, gravida ac arcu sit amet, pellentesque molestie mauris. Morbi scelerisque, nisi bibendum dictum pellentesque, nulla orci pharetra ipsum, eu condimentum neque dolor eu quam. Donec vulputate dictum arcu, ut accumsan massa iaculis sed. In ut purus at quam blandit imperdiet ac id magna.",
                    ClubSize = Enums.ClubSizeEnum.Small,
                    NumberOfRooms = Enums.NumberOfRoomsEnum.One,
                    Links = "https://www.facebook.com/carpediemdebica/about?locale=pl_PL",
                    PhoneNumber = "793 206 224",
                    Address = new ClubAddress()
                    {
                        City = "Dębica",
                        Street = "Rynek",
                        Number = "37",
                        PostCode = "39-200"
                    },
                    OpeningHours = new ClubOpeningHours()
                    {
                        Monday = "19:00 3:00",
                        Tuesday = "19:00 3:00",
                        Wednesday = "19:00 3:00",
                        Thursday = "19:00 3:00",
                        Friday = "19:00 3:00",
                        Saturday = "19:00 3:00",
                        Sunday = "19:00 00:00"
                    },
                    ClubClubTypes = new List<ClubClubType>()
                    {
                        new ClubClubType()
                        {
                            ClubId = 2,
                            ClubTypeId = 2
                        },
                        new ClubClubType()
                        {
                            ClubId = 2,
                            ClubTypeId = 4
                        }
                    },
                    ClubMusicTypes = new List<ClubMusicType>()
                    {
                        new ClubMusicType()
                        {
                            ClubId = 2,
                            MusicTypeId = 1
                        },
                        new ClubMusicType()
                        {
                            ClubId = 2,
                            MusicTypeId = 4
                        }
                    }
                },

                new Club()
                {
                    ClubId = 3,
                    Id = Guid.NewGuid(),
                    Name = "Energy2000",
                    Description = "Energy2000 to nie tylko muzyka, bezpieczeństwo oraz doskonały design czy wystrój to także moc doskonałych efektów świetlnych oraz technologii dających ogromne możliwości pokazowe.",
                    ClubSize = Enums.ClubSizeEnum.Large,
                    NumberOfRooms = Enums.NumberOfRoomsEnum.ThreeOrMore,
                    Links = "https://katowice.energy2000.pl, ",
                    PhoneNumber = "33 876 88 12",
                    Address = new ClubAddress()
                    {
                        City = "Katowice",
                        Street = "Plebiscytowa",
                        Number = "3",
                        PostCode = "40-035"
                    },
                    OpeningHours = new ClubOpeningHours()
                    {
                        Monday = "Zamknięte",
                        Tuesday = "Zamknięte",
                        Wednesday = "Zamknięte",
                        Thursday = "Zamknięte",
                        Friday = "21:00 4:00",
                        Saturday = "21:00 4:00",
                        Sunday = "Zamknięte"
                    },
                    ClubClubTypes = new List<ClubClubType>()
                    {
                        new ClubClubType()
                        {
                            ClubId = 3,
                            ClubTypeId = 1
                        },
                        new ClubClubType()
                        {
                            ClubId = 3,
                            ClubTypeId = 3
                        }
                    },
                    ClubMusicTypes = new List<ClubMusicType>()
                    {
                        new ClubMusicType()
                        {
                            ClubId = 3,
                            MusicTypeId = 1
                        },
                        new ClubMusicType()
                        {
                            ClubId = 3,
                            MusicTypeId = 2
                        },
                        new ClubMusicType()
                        {
                            ClubId = 3,
                            MusicTypeId = 3
                        }
                    }
                }
            };
            return clubs;
        }
    }
}
