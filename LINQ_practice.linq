<Query Kind="Statements">
  <Connection>
    <ID>53473914-be70-4e91-8d1b-b6b35cb8a01c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
               where x.ArtistId ==1
			   orderby x.Name
			   select new
			   {
			     Artist = x.Name,
				 Albums = from t in x.Albums
				 orderby t. Title
				 select new
				 {
				   Title = t.Title,
				   Tracks = from tr in t.Tracks
				   join g in Genres on tr.GenreId equals g.GenreId
				   select new
				   {
				     TrackName = tr.Name,
					 Genre = tr.Genre.Name,
					 Composer = tr.Composer,
					 Milliseconds = tr.Milliseconds
				   }
				 }
			};
	results.Dump();