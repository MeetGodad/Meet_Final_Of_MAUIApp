using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FinalProjectMAUIAPP;
using MySqlConnector;
using Dapper;

public class EventRepository
{
    private readonly IConfiguration _configuration;

    public EventRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public List<Event> SearchEventsByArtist(string artistName)
    {
        using var connection = GetOpenConnection();
        string query = "SELECT * FROM events_table_csharp WHERE artist LIKE @ArtistName;";
        return connection.Query<Event>(query, new { ArtistName = $"%{artistName}%" }).ToList();
    }

    public void InsertEvent(Event @event)
    {
        using var connection = GetOpenConnection();
        string query = @"INSERT INTO events_table_csharp
                        (ticket_cost, genre, artist, event_date, event_time, venue, city, description)
                        VALUES (@TicketCost, @Genre, @Artist, @EventDate, @EventTime, @Venue, @City, @Description);";
        connection.Execute(query, @event);
    }

    private MySqlConnection GetOpenConnection()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");
        var connection = new MySqlConnection(connectionString);
        if (connection.State != ConnectionState.Open)
            connection.Open();
        return connection;
    }
}