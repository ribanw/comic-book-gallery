using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public static class Data
    {
        public static ComicBook[] ComicBooks { get; private set; }
        public static Series[] Series { get; private set; }

        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            var series = new Series[]
            {
                new Series()
                {
                    Id = 1,
                    Title = "The Amazing Spider-Man",
                    DescriptionHtml = "<p>The Amazing Spider-Man (abbreviated as ASM) is an American comic book series published by Marvel Comics, featuring the adventures of the fictional superhero Spider-Man. Being the mainstream continuity of the franchise, it began publication in 1963 as a monthly periodical and was published continuously, with a brief interruption in 1995, until its relaunch with a new numbering order in 1999. In 2003 the series reverted to the numbering order of the first volume. The title has occasionally been published biweekly, and was published three times a month from 2008 to 2010. A film named after the comic was released July 3, 2012.</p>"
                },
                new Series()
                {
                    Id = 2,
                    Title = "Bone",
                    DescriptionHtml = "<p>Bone is an independently published comic book series, written and illustrated by Jeff Smith, originally serialized in 55 irregularly released issues from 1991 to 2004.</p>"
                },
                new Series()
                {
                    Id = 3,
                    Title = "Maestros",
                    DescriptionHtml = "<p>Maestros by Steve Skroce, is more than just fantasy, sci-fi, or even a story. It's a fun journey into a whole new world of magic and chaos. The series began publication in October 2017.</p>"
                }
            };

            var comicBooks = new ComicBook[]
            {
                new ComicBook()
                {
                    Id = 1,
                    Series = series[0],
                    IssueNumber = 700,
                    DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Dan Slott", Role = "Script" },
                        new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                        new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                        new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                        new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                    },
                    Favorite = false
                },
                new ComicBook()
                {
                    Id = 2,
                    Series = series[0],
                    IssueNumber = 657,
                    DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Dan Slott", Role = "Script" },
                        new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                        new Artist() { Name = "Marcos Martin", Role = "Inks" },
                        new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                        new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                    },
                    Favorite = false
                },
                new ComicBook()
                {
                    Id = 3,
                    Series = series[1],
                    IssueNumber = 50,
                    DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Jeff Smith", Role = "Script" },
                        new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                        new Artist() { Name = "Jeff Smith", Role = "Inks" },
                        new Artist() { Name = "Jeff Smith", Role = "Letters" }
                    },
                    Favorite = false
                },
                new ComicBook()
                {
                    Id = 4,
                    Series = series[2],
                    IssueNumber = 1,
                    DescriptionHtml = "<p>The Maestro and his entire royal family have been murdered. Now, his banished son from Earth will inherit the Wizard King's throne along with a spell that turns its user into GOD. With enemies everywhere, will this Orlando-born millennial be able to keep his new magic kingdom?</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Steve Skroce", Role = "Script" },
                        new Artist() { Name = "Steve Skroce", Role = "Pencils" },
                        new Artist() { Name = "Dave Stewart", Role = "Colors" },
                        new Artist() { Name = "Steve Skroce", Role = "Letters" }
                    },
                    Favorite = true
                },
                new ComicBook()
                {
                    Id = 5,
                    Series = series[2],
                    IssueNumber = 2,
                    DescriptionHtml = "<p>The Maestro is dead, long live the Maestro! For William Little, being last in line for the throne didn't grant any exemptions from the brutality of Wizarding school, Hogwarts it wasn't. Now, Willy's family is dead and he's the new Maestro, armed with the most powerful spell in creation, he has a few lessons of his own for the mad mages of his new magical kingdom. What could go wrong?</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Steve Skroce", Role = "Script" },
                        new Artist() { Name = "Steve Skroce", Role = "Pencils" },
                        new Artist() { Name = "Dave Stewart", Role = "Colors" },
                        new Artist() { Name = "Steve Skroce", Role = "Letters" }
                    },
                    Favorite = true
                },
                new ComicBook()
                {
                    Id = 5,
                    Series = series[2],
                    IssueNumber = 3,
                    DescriptionHtml = "<p>The most powerful spell in creation has been stolen. “The Book of Remaking” allows its user to recreate reality in their image, and the new Maestro is the only one who can open it. Now the thieves are coming for him. Willy's reign might be a short one.</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Steve Skroce", Role = "Script" },
                        new Artist() { Name = "Steve Skroce", Role = "Pencils" },
                        new Artist() { Name = "Dave Stewart", Role = "Colors" },
                        new Artist() { Name = "Steve Skroce", Role = "Letters" }
                    },
                    Favorite = true
                },
                new ComicBook()
                {
                    Id = 5,
                    Series = series[2],
                    IssueNumber = 4,
                    DescriptionHtml = "<p>With his enemies in pursuit, Willy travels to the Underworld in hopes of making an alliance with his father's greatest enemy. Meanwhile, his mother reflects upon the events that banished her and her son. Also, Loyal Backstabber’s origins are revealed!</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Steve Skroce", Role = "Script" },
                        new Artist() { Name = "Steve Skroce", Role = "Pencils" },
                        new Artist() { Name = "Dave Stewart", Role = "Colors" },
                        new Artist() { Name = "Steve Skroce", Role = "Letters" }
                    },
                    Favorite = true
                },
                new ComicBook()
                {
                    Id = 5,
                    Series = series[2],
                    IssueNumber = 5,
                    DescriptionHtml = "<p>Sometimes making a deal with the devil is necessary, and if you're smart enough and a clever negotiator, you can come out on top. Unfortunately Willy is neither—he's on the menu, right after the crudites. Meanwhile, Wren and Margaret discover the commonality between magic and shopping wholesale.</p>",
                    Artists = new Artist[]
                    {
                        new Artist() { Name = "Steve Skroce", Role = "Script" },
                        new Artist() { Name = "Steve Skroce", Role = "Pencils" },
                        new Artist() { Name = "Dave Stewart", Role = "Colors" },
                        new Artist() { Name = "Steve Skroce", Role = "Letters" }
                    },
                    Favorite = true
                }    
            };

            Series = series;
            ComicBooks = comicBooks;

        }
    }
}