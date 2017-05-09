<Query Kind="Statements">
  <Connection>
    <ID>1c2e1a44-f376-4dd1-886c-4316c0d6261a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
             select new 
			 {
			  Name = m.Name,
			  Tracks = from t in m.Tracks
			           select new 
				{
				TrackName = t.Name,
				Album = t.Album.Title,
				Artist = t.Album.Artist.Name,
				ReleaseYear = t.Album.ReleaseYear,
				ReleaseLabel = t.Album.ReleaseLabel, 
				Genre = t.Genre.Name
				}
				
			 };
results.Dump();