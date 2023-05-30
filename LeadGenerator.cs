using System;
using System.Collections.Generic;

public class LeadGenerator
{
    public string Name { get; set; }
    public string Expertise { get; set; }

    public void GenerateLeads(string service)
    {
        Console.WriteLine($"Generating leads for {service}...");
        // Actual code for generating leads for the specified service

        // Example code:
        // ...
        Console.WriteLine("Leads generated successfully!");
    }

    public void TrackLeads()
    {
        Console.WriteLine("Tracking leads...");
        // Actual code for tracking and managing leads generated

        // Example code:
        // ...
        Console.WriteLine("Leads tracked successfully!");
    }

    public void CommunicateWithClients()
    {
        Console.WriteLine("Communicating with clients...");
        // Actual code for communicating with clients regarding leads and services

        // Example code:
        // ...
        Console.WriteLine("Communication with clients completed!");
    }
}

public class BlueFireLeads
{
    private List<LeadGenerator> leadGenerators;

    public BlueFireLeads()
    {
        leadGenerators = new List<LeadGenerator>();
    }

    public void AddLeadGenerator(LeadGenerator leadGenerator)
    {
        leadGenerators.Add(leadGenerator);
    }

    public List<LeadGenerator> GetLeadGenerators()
    {
        return leadGenerators;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BlueFireLeads blueFireLeads = new BlueFireLeads();

        LeadGenerator leadGenerator1 = new LeadGenerator
        {
            Name = "John Doe",
            Expertise = "Home Services"
        };

        LeadGenerator leadGenerator2 = new LeadGenerator
        {
            Name = "Jane Smith",
            Expertise = "Home Services"
        };

        blueFireLeads.AddLeadGenerator(leadGenerator1);
        blueFireLeads.AddLeadGenerator(leadGenerator2);

        List<LeadGenerator> leadGenerators = blueFireLeads.GetLeadGenerators();

        foreach (var leadGenerator in leadGenerators)
        {
            Console.WriteLine($"Lead Generator: {leadGenerator.Name}");
            Console.WriteLine($"Expertise: {leadGenerator.Expertise}");

            Console.WriteLine("Enter the service for lead generation:");
            string service = Console.ReadLine();

            leadGenerator.GenerateLeads(service);
            leadGenerator.TrackLeads();
            leadGenerator.CommunicateWithClients();

            Console.WriteLine();
        }
    }
}
