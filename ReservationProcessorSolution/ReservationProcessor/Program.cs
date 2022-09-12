/*
* We will ask the user for their:
* Email Address
* The ID of the course they'd like to take.
* The ID of the offering of that course they'd like to take.
*
* We will return to them:
* (Happy Path): A message that says they are registered, a registration ID, and the date of the course.
* (Error): A message that says they cannot enroll for the course, and reason.
*/


//////Console.WriteLine("Register for a Course!\n"); 
//////Console.Write("Enter your Email Address: "); //"?" says we know it may be null- dont show warnings
//////string? email = Console.ReadLine();
//////Console.Write("Enter the Course ID: ");
//////string? courseID = Console.ReadLine();
//////Console.Write("Enter the Course Offering ID: ");
//////string? courseOfferingID = Console.ReadLine();

//////Console.WriteLine($"I see you are {email} and want to take {courseID} of {courseOfferingID}.\n");

//////CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager();

//////CourseRegistrationResponse response 
//////    = CourseRegistrationManager.RegisterForCourse(email, courseID, courseOfferingID);

//////if (response.IsRegistered)
//////{
//////    Console.WriteLine("Congratulations! You have successfully registered!");
//////    Console.WriteLine($"Your Registration ID is {response.ID}");
//////    Console.WriteLine($"Course start date: {response.courseDate:d}");
//////}

using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder();

builder.Services.AddScoped<CourseRegistrationManager>();

var app = builder.Build();

app.MapPost("/registrations", (
    [FromBody] CourseRegistrationRequest request,
    [FromServices] CourseRegistrationManager manager) =>
{
    var response = manager.RegisterForCourse(request);
    if (response.IsRegistered)
    {
        return Results.Ok(response);
    }
    else
    {
        return Results.BadRequest(response);
    }
});


Console.WriteLine("Fixing to run your web application!");
app.Run();
Console.WriteLine("Done running your web application!");
