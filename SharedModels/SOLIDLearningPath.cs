﻿namespace SharedModels;

public class SOLIDLearningPath
{
    public readonly List<ContentMetaData> FullContents = new(6);

    public SOLIDLearningPath()
    {
        FullContents =
        [
            new ContentMetaData
            {
                Order = 1,
                Title = "SOLID Principles Introduction",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/solid-principles-introduction.webp",
                ThumbnailUrl = "image/blogs/solid/solid-principles-introduction.webp",
                ContentUrl = "blogs/solid-principles-introduction",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 2, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 4, 2, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["SRP", "OCP", "LSP", "ISP", "DIP"]
            },
            new ContentMetaData
            {
                Order = 2,
                Title = "Single Responsibility Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/single-responsibility-principle-in-solid.webp",
                ThumbnailUrl = "image/blogs/solid/single-responsibility-principle-in-solid.webp",
                ContentUrl = "blogs/single-responsibility-principle-in-solid",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 16, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 4, 16, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["SRP", "Single Responsibility"]
            },
            new ContentMetaData
            {
                Order = 3,
                Title = "Open Closed Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/open-closed-principle-in-solid.webp",
                ThumbnailUrl = "image/blogs/solid/open-closed-principle-in-solid.webp",
                ContentUrl = "blogs/open-closed-principle-in-solid",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 23, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 4, 23, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["OCP", "Open Closed"]
            },
            new ContentMetaData
            {
                Order = 4,
                Title = "Liskov Substitution Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/liskov-substitution-principle-in-solid.webp",
                ThumbnailUrl = "image/blogs/solid/liskov-substitution-principle-in-solid.webp",
                ContentUrl = "blogs/liskov-substitution-principle-in-solid",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 4, 30, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 4, 30, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["LSP", "Liskov Substitution"]
            },
            new ContentMetaData
            {
                Order = 5,
                Title = "Interface Segregation Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/interface-segregation-principle-in-solid.webp",
                ThumbnailUrl = "image/blogs/solid/interface-segregation-principle-in-solid.webp",
                ContentUrl = "blogs/interface-segregation-principle-in-solid",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 5, 7, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 5, 7, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["ISP", "Interface Segregation"]
            },
            new ContentMetaData
            {
                Order = 6,
                Title = "Dependency Inversion Principle in SOLID",
                Author = "Abdul Rahman",
                PosterUrl = "image/blogs/solid/dependency-inversion-principle-in-solid.webp",
                ThumbnailUrl = "image/blogs/solid/dependency-inversion-principle-in-solid.webp",
                ContentUrl = "blogs/dependency-inversion-principle-in-solid",
                IconUrl = "image/icons/solid.webp",
                Type = "SOLID",
                CreatedOn = new DateTime(2023, 5, 14, 22, 30, 0, DateTimeKind.Utc),
                ModifiedOn = new DateTime(2023, 5, 14, 22, 30, 0, DateTimeKind.Utc),
                Keywords = ["DIP", "Dependency Inversion"]
            },
        ];
    }
}
