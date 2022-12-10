﻿namespace Gorse.NET.Tests;

public class Tests
{
    private const string ENDPOINT = "http://192.168.100.246:8088";
    private const string API_KEY = "zhenghaoz";

    private Gorse client = new Gorse(ENDPOINT, API_KEY);

    [Test]
    public void TestUsers()
    {
        // Insert a user
        var user = new User { UserId = "1", Labels = new string[] { "a", "b", "c" } };
        var rowAffected = client.InsertUser(user);
        Assert.Equals(rowAffected.RowAffected, 1);
    }
}