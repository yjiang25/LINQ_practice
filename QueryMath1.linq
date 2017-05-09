<Query Kind="Statements">
  <Connection>
    <ID>1c2e1a44-f376-4dd1-886c-4316c0d6261a</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

ar results = from g in Genres
              where g.Name
			  select new
			  {
			  Genre = g.Name,
			  TrackCount = g.Tracks.Count()
			  };
results.Dump("Query Math 1");