<Query Kind="Statements">
  <Connection>
    <ID>1c2e1a44-f376-4dd1-886c-4316c0d6261a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
			   
				TracksCount = g.Tracks.Count(),
				Tracks =from t in g.Tracks
				        select new
				{
				  TrackName = t.Name,
				  AlbumName = t.Album.Title,
				  Milloseconds = t.Milliseconds,
				  size = (t.Bytes / 1000) + "kb",
				  Price = t.UnitPrice
				}
			  };
results.Dump("Query Math 2");