using System;
using Course.Entities;


    class Program
    {
        static void Main(string[] args)
        {

        Comment c1 = new Comment("Tenha uma boa Viagem");
        Comment c2 = new Comment("Isso é demais");
        Post p1 = new Post(
            "Viagem á Nova Zelandia",
            DateTime.Parse("21/06/2018 13:56:33"),
            "Fui visitar esse belo país",
            12);

        p1.AddComment(c1);
        p1.AddComment(c2);

        Comment c3 = new Comment("Boa noite");
        Comment c4 = new Comment("Força");
        Post p2 = new Post(
            "Boa noite",
            DateTime.Parse("22/06/2018 13:56:33"),
            "Vejo você amanhã",
            12);

        p1.AddComment(c3);
        p1.AddComment(c4);

        Console.WriteLine(p1 +"\n"+p2);
    }
    }

