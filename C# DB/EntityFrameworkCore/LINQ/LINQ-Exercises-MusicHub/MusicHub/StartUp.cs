namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            string result = ExportSongsAboveDuration(context, 4);

            Console.WriteLine(result);
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder sb = new StringBuilder();

            var producerAlbums = context.Albums
                .Where(a => a.ProducerId == producerId)
                .Select(a => new
                {
                    a.Name,
                    a.ReleaseDate,
                    ProducerName = a.Producer!.Name,
                    AlbumSongs = a.Songs
                        .Select(s => new
                        {
                            s.Name,
                            s.Price,
                            WriterName = s.Writer.Name
                        })
                        .OrderByDescending(s => s.Name)
                        .ThenBy(s => s.WriterName)
                        .ToArray(),
                    TotalPrice = a.Price
                })
                .ToArray()
                .OrderByDescending(a => a.TotalPrice)
                .ToArray();

            foreach (var a in producerAlbums)
            {
                sb.AppendLine($"-AlbumName: {a.Name}");
                sb.AppendLine($"-ReleaseDate: {a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)}");
                sb.AppendLine($"-ProducerName: {a.ProducerName}");
                sb.AppendLine($"-Songs:");

                foreach (var song in a.AlbumSongs)
                {
                    int number = 1;
                    sb.AppendLine($"---#{number++}");
                    sb.AppendLine($"---SongName: {song.Name}");
                    sb.AppendLine($"---Price: {song.Price.ToString("f2")}");
                    sb.AppendLine($"---Writer: {song.WriterName}");
                }

                sb.AppendLine($"-AlbumPrice: {a.TotalPrice.ToString("f2")}");

            }

            return sb.ToString().TrimEnd();

        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder sb = new StringBuilder();

            var songs = context.Songs
                .Select(s => new
                {
                    s.Name,
                    PerformersNames = s.SongPerformers
                        .Select(sp => new 
                        {
                            sp.Performer.FirstName,
                            sp.Performer.LastName,
                        })
                        .OrderBy(sp => sp.FirstName)
                        .ThenBy(sp => sp.LastName)
                        .ToArray(),
                    WriterName = s.Writer.Name,
                    AlbumProducerName = s.Album != null ?
                        (s.Album.Producer != null ? s.Album.Producer.Name : null) : null,
                    s.Duration
                })
                .OrderBy(s => s.Name)
                .ThenBy(s => s.WriterName)
                .ToArray()
                .Where(s => s.Duration.TotalSeconds > duration)
                .ToArray();

            int songNumber = 1;
            foreach (var song in songs)
            {
                sb.AppendLine($"-Song #{songNumber++}");
                sb.AppendLine($"---SongName: {song.Name}");
                sb.AppendLine($"---Writer: {song.WriterName}");

                foreach (var performer in song.PerformersNames)
                {
                    sb
                        .AppendLine($"---Performer: {performer.FirstName} {performer.LastName}");
                }

                sb.AppendLine($"---AlbumProducer: {song.AlbumProducerName}");

                sb.AppendLine($"---Duration: {song.Duration.ToString("c")}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}